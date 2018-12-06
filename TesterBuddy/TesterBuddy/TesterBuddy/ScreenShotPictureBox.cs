/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 07-Jun-17
 * Time: 10:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


namespace TesterBuddy
{
	/// <summary>
	/// Description of ScreenShotPictureBox.
	/// </summary>
	public partial class ScreenShotPictureBox : Form
	{
		MainForm mainform;
		public bool waiting=true;
		
		public ScreenShotPictureBox(MainForm mainform)
		{
			this.mainform=mainform;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.Top=0;
			this.Left=0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Cursor = Cursors.Cross;
			
			
			//Create the Bitmap
			Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
			                                Screen.PrimaryScreen.Bounds.Height);
			//Create the Graphic Variable with screen Dimensions
			Graphics graphics = Graphics.FromImage(printscreen as Image);
			//Copy Image from the screen
			graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
			//Create a temporal memory stream for the image
			using (MemoryStream s = new MemoryStream())
			{
				//save graphic variable into memory
				printscreen.Save(s, ImageFormat.Bmp);
				pictureBox1.Size = new System.Drawing.Size(this.Width, this.Height);
				//set the picture box with temporary stream
				pictureBox1.Image = Image.FromStream(s);
			}
		}
		
		//These variables control the mouse position
		int selectX;
		int selectY;
		int selectWidth;
		int selectHeight;
		public Pen selectPen;

		//This variable control when you start the right click
		bool selectionStart = false;

		void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			//validate if there is an image
			if (pictureBox1.Image == null)
				return;
			//validate if right-click was trigger
			if(selectionStart)
			{
				//refresh picture box
				pictureBox1.Refresh();
				//set corner square to mouse coordinates
				selectWidth = Math.Abs(e.X - selectX);
				selectHeight = Math.Abs(e.Y - selectY);
				//draw dotted rectangle
				int x= e.X<selectX?e.X:selectX;
				int y= e.Y<selectY?e.Y:selectY;
				pictureBox1.CreateGraphics().DrawRectangle(selectPen, x, y, selectWidth, selectHeight);
			}
		}
		
		void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			//validate when user right-click
			if (!selectionStart)
			{
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					//starts coordinates for rectangle
					selectX = e.X;
					selectY = e.Y;
					selectPen = new Pen(Color.Red, 1);
					selectPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
				}
				//refresh picture box
				pictureBox1.Refresh();
				//start control variable for draw rectangle
				selectionStart = true;
			}
			else
			{
				//validate if there is image
				if (pictureBox1.Image == null)
					return;
				//same functionality when mouse is over
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					pictureBox1.Refresh();
					selectWidth = Math.Abs(e.X - selectX);
					selectHeight = Math.Abs(e.Y - selectY);
					//draw dotted rectangle
					int x= e.X<selectX?e.X:selectX;
					int y= e.Y<selectY?e.Y:selectY;
					pictureBox1.CreateGraphics().DrawRectangle(selectPen, x, y, selectWidth, selectHeight);

				}
				selectionStart = false;
				//function save image to clipboard
				SaveToClipboard();
				waiting=false;
				mainform.pictureBox1.Image=Clipboard.GetImage();
				this.Close();
			}
		}
		
		void SaveToClipboard()
		{
			//validate if something selected
			if (selectWidth > 0)
			{

				Rectangle rect = new Rectangle(selectX, selectY, selectWidth, selectHeight);
				//create bitmap with original dimensions
				Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
				//create bitmap with selected dimensions
				Bitmap _img = new Bitmap(selectWidth, selectHeight);
				//create graphic variable
				Graphics g = Graphics.FromImage(_img);
				//set graphic attributes
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
				g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
				g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
				//insert image stream into clipboard
				Clipboard.SetImage(_img);
			}
			
		}
		
		
	}
}
