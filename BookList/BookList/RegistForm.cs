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
    public partial class RegistForm : Form
    {
        const string MessageBoxError = "エラー";
        const string MessageBoxWarning = "警告";
        const string MessageBoxInfo = "情報";
        string ConnectionString;

        BookDataWriter BookRecordWirter;

        public RegistForm()
        {
            InitializeComponent();
            ConnectionString = AddressList.Properties.Settings.Default.BookDataConnectionString;
            BookRecordWirter = new BookDataWriter(ConnectionString);

            ReadStatusComboBox.SelectedItem = "未読";
            RentalStatusComboBox.SelectedItem = "所持";

        }

        public RegistForm(BookList SelectedData)
        {
            InitializeComponent();

            ConnectionString = AddressList.Properties.Settings.Default.BookDataConnectionString;
            BookRecordWirter = new BookDataWriter(ConnectionString);
            ISBNTextBox.Enabled = false;
            SetSelectedData(SelectedData);

        }

        private void SetSelectedData(BookList SelectedData)
        {
            BookNameTextBox.Text = SelectedData.BookName.ToString();
            ISBNTextBox.Text = SelectedData.ISBN;
            AuthorTextBox.Text = SelectedData.Author;
            PriceTextBox.Text = SelectedData.Price.ToString();
            BookTypeTextBox.Text = SelectedData.BookType;
            ReadStatusComboBox.Text =SelectedData.ReadStatus;
            RentalStatusComboBox.Text = SelectedData.RentalStatus;
            
        }

        private void RegistForm_Load(object sender, EventArgs e)
        {
            
        }

        public void HideRegistButton()
        {
            RegistButton.Hide();
        }

        public void HideUpdateButton()
        {
            UpdateButton.Hide();
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            if (!IsErrorData())
            {
                RegistantData();
                MessageBox.Show("新規登録しました", MessageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void RegistantData()
        {
            BookList RegistData = BookDataSet();
            BookRecordWirter.Insert(RegistData);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!IsErrorData())
            {
                UpdateData();
                MessageBox.Show("更新しました", MessageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void UpdateData()
        {
            BookList UpdateData = BookDataSet();
            BookRecordWirter.Update(UpdateData);
        }

        /// <summary>
        /// エラーチェック
        /// </summary>
        private bool IsErrorData()
        {
            bool IsError = true;
            
            try
            {
                CheckBookData();
                IsError = false;
            }
            catch (BookListException BookEx)
            {
                MessageBox.Show(BookEx.Message, MessageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsError;
        }

        private BookList BookDataSet()
        {
            BookList InputData = new BookList();

            InputData.BookName = BookNameTextBox.Text;
            InputData.ISBN = ISBNTextBox.Text;

            InputData.Author = AuthorTextBox.Text;
            InputData.Price = float.Parse(PriceTextBox.Text);
            InputData.BookType = BookTypeTextBox.Text;
            InputData.ReadStatus = ReadStatusComboBox.Text;
            InputData.RentalStatus = RentalStatusComboBox.Text;

            return InputData;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CheckBookData()
        {
            try
            {
                Check();

            }
            catch (AddressList.BookListException)
            {
                throw;
            }

        }

        private void Check()
        {
            BookNameCheck();

            ISBNCheck();

            AuthorCheck();

            PriceCheck();

            BookTypeCheck();

            ReadStatusCheck();

            RentalStatusCheck();

        }

        private void BookNameCheck()
        {
            if (BookNameTextBox.Text == string.Empty)
            {
                throw new BookListException("書籍名がセットされていません。");
            }
        }

        private void ISBNCheck()
        {
            if (ISBNTextBox.Text == string.Empty)
            {
                throw new BookListException("ISBNがセットされていません。");
            }

        }

        private void AuthorCheck()
        {
            
        }

        private void PriceCheck()
        {
            double TryDouble = 0;

            if(!double.TryParse(PriceTextBox.Text,out TryDouble))
            {
                throw new BookListException("値段の入力が正しくありません。");
            }
        }

        private void BookTypeCheck()
        {
            

        }

        private void ReadStatusCheck()
        {
            if (ReadStatusComboBox.SelectedItem == string.Empty)
            {
                throw new BookListException("積読状態の設定が正しくありません。");
            }

        }

        private void RentalStatusCheck()
        {
            if (RentalStatusComboBox.SelectedItem == string.Empty)
            {
                throw new BookListException("貸出状態の設定が正しくありません");
            }

        }
    }
}
