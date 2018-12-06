/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 9/3/2013
 * Time: 2:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ArchiveHelperNS
{
	/// <summary>
	/// Description of ArchiveExtractOptions.
	/// </summary>
	public class ArchiveExtractOptions
	{
		public string archive_file_name;
		public bool recursive, delete_archive, delete_tokens, limit_recursion;
		public int max_recursions;		
		public List<string> tokens_to_delete_from_file_name=new List<string>();
		public List<string> file_ext_to_ignore_tok_del=new List<string>();
		
		public ArchiveExtractOptions()
		{
			recursive=false;
			delete_archive=false;
			delete_tokens=false;
			limit_recursion=true;
			max_recursions=1;			
		}
		
		public ArchiveExtractOptions(ArchiveExtractOptions aeo)
		{
			this.archive_file_name=aeo.archive_file_name;
			this.recursive=aeo.recursive;
			this.delete_archive=aeo.delete_archive;
			this.delete_tokens=aeo.delete_tokens;
			this.limit_recursion=aeo.limit_recursion;
			this.max_recursions=aeo.max_recursions;
			
			foreach(string token in aeo.tokens_to_delete_from_file_name)
			{
				this.tokens_to_delete_from_file_name.Add(token);
			}
			
			
			foreach(string fileext in aeo.file_ext_to_ignore_tok_del)
			{
				this.file_ext_to_ignore_tok_del.Add(fileext);
			}
		}
		
		public void AddTokenToDeleteFromFileName(string token)
		{
			delete_tokens=true;
			
			if(!tokens_to_delete_from_file_name.Contains(token))
			{
				tokens_to_delete_from_file_name.Add(token);
			}
		}
		
		public void AddFileExtIgnoreForTokenDel(string fileext)
		{
			delete_tokens=true;
			
			if(!file_ext_to_ignore_tok_del.Contains(fileext))
			{
				file_ext_to_ignore_tok_del.Add(fileext);
			}
		}
	}
}
