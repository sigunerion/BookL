using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AddressList.Control
{
    class CSVWriter
    {
        const string MessageBoxError = "エラー";
        const string MessageBoxWarning = "警告";
        const string MessageBoxInfo = "情報";
        
        string DefaultFilePath { get; set; }
        SaveFileDialog SaveCSVDialog;

        StreamWriter Writer;
        List<BookList> WriteData;



        public CSVWriter(List<BookList> Books)
        {
            DefaultFilePath = "C:\\";
            WriteData = Books;
        }

        public void Write()
        {
            SaveCSVDialog = new SaveFileDialog();
            SetCSVDialog();
            
            if (SaveCSVDialog.ShowDialog() == DialogResult.OK)
            {
                WriteText();
            }
            
        }

        private void SetCSVDialog()
        {
            
            SaveCSVDialog.FileName = "NewBookList.csv";
            SaveCSVDialog.Filter = "csvファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            SaveCSVDialog.FilterIndex = 1;
            SaveCSVDialog.Title = "CSVを保存するファイルを指定してください。";
            SaveCSVDialog.RestoreDirectory = true;
            
        }

        private void WriteText()
        {
            Stream CsvStream = SaveCSVDialog.OpenFile();            

            try
            {
                Writer = new StreamWriter(CsvStream, System.Text.Encoding.GetEncoding("shift-jis"));

                WriteRows();
                MessageBox.Show("CSVを作成しました。", MessageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (IOException )
            {
                MessageBox.Show("CSVの出力に失敗しました。", MessageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Writer.Close();
            }

        }

        private void WriteRows()
        {
            foreach (BookList Row in WriteData)
            {
                Writer.Write(RewriteColumn(Row.BookName));
                Writer.Write(",");
                Writer.Write(RewriteColumn(Row.ISBN));
                Writer.Write(",");
                Writer.Write(RewriteColumn(Row.Author));
                Writer.Write(",");
                Writer.Write(RewriteColumn(Row.Price.ToString()));
                Writer.Write(",");
                Writer.Write(RewriteColumn(Row.BookType));
                Writer.Write(",");
                Writer.Write(RewriteColumn(Row.ReadStatus));
                Writer.Write(",");
                Writer.Write(RewriteColumn(Row.RentalStatus));                
                Writer.Write(Environment.NewLine);
                
            }
        }

        private string RewriteColumn(string Column)
        {
            string Result = Column;

            if(Result.Contains("\""))
            {
                Result.Replace("\"","\"\"");
            }

            Result = "\"" + Result + "\"";

            return Result;
        }

    }
}
