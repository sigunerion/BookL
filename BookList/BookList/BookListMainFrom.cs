using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AddressList.Control;


namespace AddressList
{
    public partial class BookListMainForm : Form
    {

        const string MessageBoxError = "エラー";
        const string MessageBoxWarning = "警告";
        const string MessageBoxInfo = "情報";

        RegistForm NewRegistForm;
        RegistForm UpdateForm;
        
        BookListReader ListReader;
        string ConnectionString;

        List<BookList> BooksList;

        public BookListMainForm()
        {            
            InitializeComponent();
            ConnectionString = AddressList.Properties.Settings.Default.BookDataConnectionString;
            ListReader = new BookListReader(ConnectionString);
        }

        private void BookListMainForm_Load(object sender, EventArgs e)
        {
            ModifyBookList();
        }

        private void ModifyBookList()
        {
            BooksList = ListReader.GetBookList();
            BookListBox.DataSource = BooksList;
            BookListBox.DisplayMember = "BookName";
            this.BookListBox.Select();
        }        

        private void RegistButton_Click(object sender, EventArgs e)
        {
            ShowNewRegistForm();
        }

        private void ShowNewRegistForm()
        {
            NewRegistForm = new RegistForm();
                        
            NewRegistForm.HideUpdateButton();
            NewRegistForm.ShowDialog();
            ModifyBookList();            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (BookListBox.Text == string.Empty)
            {
                MessageBox.Show("更新対象を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShowUpdateButton();
            }
        }

        private void ShowUpdateButton()
        {
            BookList SelectedBook = (BookList)BookListBox.SelectedItem;

            UpdateForm = new RegistForm(SelectedBook);
            
            UpdateForm.HideRegistButton();
            UpdateForm.ShowDialog();
            ModifyBookList();
            
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            BooksList = ListReader.GetBookList(SearchInputTextBox.Text);
            BookListBox.DataSource = BooksList;
            BookListBox.DisplayMember = "BookName";
        }

        private void SearchInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                SearchData();
            }
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookList SelectedBook = (BookList)BookListBox.SelectedItem;

            DisplayBookName.Text = SelectedBook.BookName;
            DisplayISBN.Text = SelectedBook.ISBN;
            DisplayAuthorName.Text = SelectedBook.Author;
            DisplayBookType.Text = SelectedBook.BookType;
            DisplayPrice.Text = SelectedBook.Price.ToString();
            DisplayReadStatus.Text = SelectedBook.ReadStatus;
            DisplayRentalStatus.Text = SelectedBook.RentalStatus;
        }

        private void ExportCSVData_Click(object sender, EventArgs e)
        {
            CSVWriter Writer = new CSVWriter(BooksList);
            Writer.Write();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            DialogResult IsDelete =  MessageBox.Show("このデータを削除しますか？", MessageBoxInfo, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (IsDelete == System.Windows.Forms.DialogResult.OK)
            {
                BookDataDeleter Deleter = new BookDataDeleter(ConnectionString);

                BookList SelectedBook = (BookList)BookListBox.SelectedItem;
                string DeleteBook = SelectedBook.ISBN;
                Deleter.Delete(DeleteBook);
                MessageBox.Show("削除しました", MessageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModifyBookList();
            }
        }


        

    }
}
