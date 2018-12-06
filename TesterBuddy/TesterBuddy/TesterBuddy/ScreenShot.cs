/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 15/3/2015
 * Time: 12:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.Threading;


namespace TesterBuddy
{
	///
	/// This class shall keep the GDI32 APIs used in our program.
	///
	public class PlatformInvokeGDI32
	{
		#region Class Variables
		public  const int SRCCOPY = 13369376;
		#endregion
		#region Class Functions

		[DllImport("gdi32.dll",EntryPoint="DeleteDC")]
		public static extern IntPtr DeleteDC(IntPtr hDc);

		[DllImport("gdi32.dll",EntryPoint="DeleteObject")]
		public static extern IntPtr DeleteObject(IntPtr hDc);

		[DllImport("gdi32.dll",EntryPoint="BitBlt")]
		public static extern bool BitBlt(IntPtr hdcDest,int xDest,
		                                 int yDest,int wDest,
		                                 int hDest,IntPtr hdcSource,
		                                 int xSrc,int ySrc,int RasterOp);

		[DllImport ("gdi32.dll",EntryPoint="CreateCompatibleBitmap")]
		public static extern IntPtr CreateCompatibleBitmap
			(IntPtr hdc,int nWidth, int nHeight);

		[DllImport ("gdi32.dll",EntryPoint="CreateCompatibleDC")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		[DllImport ("gdi32.dll",EntryPoint="SelectObject")]
		public static extern IntPtr SelectObject(IntPtr hdc,IntPtr bmp);
		#endregion
	}
	#region Public Constructor


	///
	/// This class shall keep the User32 APIs used in our program.
	///
	public class PlatformInvokeUSER32
	{
		#region Class Variables
		public  const int SM_CXSCREEN=0;
		public  const int SM_CYSCREEN=1;
		#endregion

		#region Class Functions
		[DllImport("user32.dll", EntryPoint="GetDesktopWindow")]
		public static extern IntPtr GetDesktopWindow();
		
		[DllImport("user32.dll", EntryPoint="GetForegroundWindow")]
		public static extern IntPtr GetForegroundWindow();
		
		[DllImport("user32.dll",EntryPoint="GetDC")]
		public static extern IntPtr GetDC(IntPtr ptr);

		[DllImport("user32.dll",EntryPoint="GetSystemMetrics")]
		public static extern int GetSystemMetrics(int abc);

		[DllImport("user32.dll",EntryPoint="GetWindowDC")]
		public static extern IntPtr GetWindowDC(Int32 ptr);

		[DllImport("user32.dll",EntryPoint="ReleaseDC")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd,IntPtr hDc);

		#endregion
	}
	#endregion
	
	public enum enmScreenCaptureMode
	{
		Screen,
		Window
	}
	

	//This structure shall be used to keep the size of the screen.
	public struct SIZE
	{
		public int cx;
		public int cy;
	}
	
	///
	/// This class shall keep all the functionality for capturing
	/// the desktop.
	///
	class ScreenCapturer
	{
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

		[StructLayout(LayoutKind.Sequential)]
		private struct Rect
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
		}

		public static Bitmap Capture(enmScreenCaptureMode screenCaptureMode = enmScreenCaptureMode.Window)
		{
			Rectangle bounds;

			if (screenCaptureMode == enmScreenCaptureMode.Screen)
			{
				bounds = Screen.GetBounds(Point.Empty);
				CursorPosition = Cursor.Position;
			}
			else
			{
				var foregroundWindowsHandle = GetForegroundWindow();
				var rect = new Rect();
				GetWindowRect(foregroundWindowsHandle, ref rect);
				bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
				CursorPosition = new Point(Cursor.Position.X - rect.Left, Cursor.Position.Y - rect.Top);
			}

			var result = new Bitmap(bounds.Width, bounds.Height);

			using (var g = Graphics.FromImage(result))
			{
				g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
			}

			return result;
		}

		public static Point CursorPosition
		{
			get;
			protected set;
		}
	}
	
	
	/// <summary> This class allows you to manage a hotkey </summary>
	public class GlobalHotkey : IDisposable
	{
		[DllImport("user32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RegisterHotKey(IntPtr hwnd, int id, uint fsModifiers, uint vk);
		[DllImport("user32", SetLastError = true)]
		public static extern int UnregisterHotKey(IntPtr hwnd, int id);
		[DllImport("kernel32", SetLastError = true)]
		public static extern short GlobalAddAtom(string lpString);
		[DllImport("kernel32", SetLastError = true)]
		public static extern short GlobalDeleteAtom(short nAtom);

		public const int MOD_ALT = 1;
		public const int MOD_CONTROL = 2;
		public const int MOD_SHIFT = 4;
		public const int MOD_WIN = 8;

		public const int WM_HOTKEY = 0x312;

		public GlobalHotkey()
		{
			this.Handle = Process.GetCurrentProcess().Handle;
		}

		/// <summary>Handle of the current process</summary>
		public IntPtr Handle;

		/// <summary>The ID for the hotkey</summary>
		public short HotkeyID { get; private set; }

		/// <summary>Register the hotkey</summary>
		public void RegisterGlobalHotKey(int hotkey, int modifiers, IntPtr handle)
		{
			UnregisterGlobalHotKey();
			this.Handle = handle;
			RegisterGlobalHotKey(hotkey, modifiers);
		}

		/// <summary>Register the hotkey</summary>
		public void RegisterGlobalHotKey(int hotkey, int modifiers)
		{
			UnregisterGlobalHotKey();

			try
			{
				// use the GlobalAddAtom API to get a unique ID (as suggested by MSDN)
				string atomName = Thread.CurrentThread.ManagedThreadId.ToString("X8") +
					this.GetType().FullName;
				HotkeyID = GlobalAddAtom(atomName);
				if (HotkeyID == 0)
					throw new Exception("Unable to generate unique hotkey ID. Error: " +
					                    Marshal.GetLastWin32Error().ToString());

				// register the hotkey, throw if any error
				if (!RegisterHotKey(this.Handle, HotkeyID, (uint)modifiers, (uint)hotkey))
					throw new Exception("Unable to register hotkey. Error: " +
					                    Marshal.GetLastWin32Error().ToString());
			}
			catch (Exception ex)
			{
				// clean up if hotkey registration failed
				Dispose();
				Console.WriteLine(ex);
			}
		}

		/// <summary>Unregister the hotkey</summary>
		public void UnregisterGlobalHotKey()
		{
			if (this.HotkeyID != 0)
			{
				UnregisterHotKey(this.Handle, HotkeyID);
				// clean up the atom list
				GlobalDeleteAtom(HotkeyID);
				HotkeyID = 0;
			}
		}

		public void Dispose()
		{
			UnregisterGlobalHotKey();
		}
	}

}