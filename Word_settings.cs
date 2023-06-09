﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;


namespace Dogovor
{
    internal class Word_settings
    {
        private FileInfo _fileinfo;

        public Word_settings(string fileName) 
        {
            if(File.Exists(fileName)) 
            {
                _fileinfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("Файл не найден!");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileinfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var item in items )
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text= item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: false,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                Object newFileName = Path.Combine(_fileinfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss ") + _fileinfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                

                return true;
            }
            catch (Exception ex)
            {
            
            }
            finally
            {
                if(app != null)
                app.Quit();
            }
            return false;
        }
    }
}
