namespace AddressList
{
    partial class BookListMainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.PriceName = new System.Windows.Forms.Label();
            this.BookType = new System.Windows.Forms.Label();
            this.ReadStatus = new System.Windows.Forms.Label();
            this.RentalStatus = new System.Windows.Forms.Label();
            this.DisplayBookName = new System.Windows.Forms.Label();
            this.DisplayISBN = new System.Windows.Forms.Label();
            this.DisplayAuthorName = new System.Windows.Forms.Label();
            this.DisplayPrice = new System.Windows.Forms.Label();
            this.DisplayBookType = new System.Windows.Forms.Label();
            this.DisplayReadStatus = new System.Windows.Forms.Label();
            this.DisplayRentalStatus = new System.Windows.Forms.Label();
            this.RegistButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExportCSVData = new System.Windows.Forms.Button();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.SearchInputTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 12;
            this.BookListBox.Location = new System.Drawing.Point(12, 46);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(103, 148);
            this.BookListBox.TabIndex = 0;
            this.BookListBox.SelectedIndexChanged += new System.EventHandler(this.BookListBox_SelectedIndexChanged);
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(121, 46);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(41, 12);
            this.BookNameLabel.TabIndex = 1;
            this.BookNameLabel.Text = "書籍名";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(121, 68);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(31, 12);
            this.ISBNLabel.TabIndex = 2;
            this.ISBNLabel.Text = "ISBN";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(121, 89);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(41, 12);
            this.AuthorName.TabIndex = 3;
            this.AuthorName.Text = "著者名";
            // 
            // PriceName
            // 
            this.PriceName.AutoSize = true;
            this.PriceName.Location = new System.Drawing.Point(121, 111);
            this.PriceName.Name = "PriceName";
            this.PriceName.Size = new System.Drawing.Size(29, 12);
            this.PriceName.TabIndex = 4;
            this.PriceName.Text = "金額";
            // 
            // BookType
            // 
            this.BookType.AutoSize = true;
            this.BookType.Location = new System.Drawing.Point(121, 132);
            this.BookType.Name = "BookType";
            this.BookType.Size = new System.Drawing.Size(55, 12);
            this.BookType.TabIndex = 5;
            this.BookType.Text = "書籍タイプ";
            // 
            // ReadStatus
            // 
            this.ReadStatus.AutoSize = true;
            this.ReadStatus.Location = new System.Drawing.Point(121, 154);
            this.ReadStatus.Name = "ReadStatus";
            this.ReadStatus.Size = new System.Drawing.Size(53, 12);
            this.ReadStatus.TabIndex = 6;
            this.ReadStatus.Text = "積読状態";
            // 
            // RentalStatus
            // 
            this.RentalStatus.AutoSize = true;
            this.RentalStatus.Location = new System.Drawing.Point(123, 175);
            this.RentalStatus.Name = "RentalStatus";
            this.RentalStatus.Size = new System.Drawing.Size(53, 12);
            this.RentalStatus.TabIndex = 7;
            this.RentalStatus.Text = "貸出状態";
            // 
            // DisplayBookName
            // 
            this.DisplayBookName.AutoSize = true;
            this.DisplayBookName.Location = new System.Drawing.Point(223, 46);
            this.DisplayBookName.Name = "DisplayBookName";
            this.DisplayBookName.Size = new System.Drawing.Size(41, 12);
            this.DisplayBookName.TabIndex = 8;
            this.DisplayBookName.Text = "書籍名";
            // 
            // DisplayISBN
            // 
            this.DisplayISBN.AutoSize = true;
            this.DisplayISBN.Location = new System.Drawing.Point(223, 68);
            this.DisplayISBN.Name = "DisplayISBN";
            this.DisplayISBN.Size = new System.Drawing.Size(31, 12);
            this.DisplayISBN.TabIndex = 9;
            this.DisplayISBN.Text = "ISBN";
            // 
            // DisplayAuthorName
            // 
            this.DisplayAuthorName.AutoSize = true;
            this.DisplayAuthorName.Location = new System.Drawing.Point(223, 89);
            this.DisplayAuthorName.Name = "DisplayAuthorName";
            this.DisplayAuthorName.Size = new System.Drawing.Size(41, 12);
            this.DisplayAuthorName.TabIndex = 10;
            this.DisplayAuthorName.Text = "著者名";
            // 
            // DisplayPrice
            // 
            this.DisplayPrice.AutoSize = true;
            this.DisplayPrice.Location = new System.Drawing.Point(223, 111);
            this.DisplayPrice.Name = "DisplayPrice";
            this.DisplayPrice.Size = new System.Drawing.Size(29, 12);
            this.DisplayPrice.TabIndex = 11;
            this.DisplayPrice.Text = "金額";
            // 
            // DisplayBookType
            // 
            this.DisplayBookType.AutoSize = true;
            this.DisplayBookType.Location = new System.Drawing.Point(223, 132);
            this.DisplayBookType.Name = "DisplayBookType";
            this.DisplayBookType.Size = new System.Drawing.Size(55, 12);
            this.DisplayBookType.TabIndex = 12;
            this.DisplayBookType.Text = "書籍タイプ";
            // 
            // DisplayReadStatus
            // 
            this.DisplayReadStatus.AutoSize = true;
            this.DisplayReadStatus.Location = new System.Drawing.Point(223, 154);
            this.DisplayReadStatus.Name = "DisplayReadStatus";
            this.DisplayReadStatus.Size = new System.Drawing.Size(53, 12);
            this.DisplayReadStatus.TabIndex = 13;
            this.DisplayReadStatus.Text = "積読状態";
            // 
            // DisplayRentalStatus
            // 
            this.DisplayRentalStatus.AutoSize = true;
            this.DisplayRentalStatus.Location = new System.Drawing.Point(223, 175);
            this.DisplayRentalStatus.Name = "DisplayRentalStatus";
            this.DisplayRentalStatus.Size = new System.Drawing.Size(53, 12);
            this.DisplayRentalStatus.TabIndex = 14;
            this.DisplayRentalStatus.Text = "貸出状態";
            // 
            // RegistButton
            // 
            this.RegistButton.Location = new System.Drawing.Point(12, 200);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(63, 28);
            this.RegistButton.TabIndex = 15;
            this.RegistButton.Text = "新規登録";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(81, 200);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(63, 28);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ExportCSVData
            // 
            this.ExportCSVData.Location = new System.Drawing.Point(219, 200);
            this.ExportCSVData.Name = "ExportCSVData";
            this.ExportCSVData.Size = new System.Drawing.Size(63, 28);
            this.ExportCSVData.TabIndex = 17;
            this.ExportCSVData.Text = "CSV出力";
            this.ExportCSVData.UseVisualStyleBackColor = true;
            this.ExportCSVData.Click += new System.EventHandler(this.ExportCSVData_Click);
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.Location = new System.Drawing.Point(288, 201);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(63, 28);
            this.ShutDownButton.TabIndex = 18;
            this.ShutDownButton.Text = "閉じる";
            this.ShutDownButton.UseVisualStyleBackColor = true;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // SearchInputTextBox
            // 
            this.SearchInputTextBox.Location = new System.Drawing.Point(12, 12);
            this.SearchInputTextBox.Name = "SearchInputTextBox";
            this.SearchInputTextBox.Size = new System.Drawing.Size(270, 19);
            this.SearchInputTextBox.TabIndex = 19;
            this.SearchInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInputTextBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(288, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(63, 28);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(150, 200);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 28);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BookListMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(365, 241);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchInputTextBox);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.ExportCSVData);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.DisplayRentalStatus);
            this.Controls.Add(this.DisplayReadStatus);
            this.Controls.Add(this.DisplayBookType);
            this.Controls.Add(this.DisplayPrice);
            this.Controls.Add(this.DisplayAuthorName);
            this.Controls.Add(this.DisplayISBN);
            this.Controls.Add(this.DisplayBookName);
            this.Controls.Add(this.RentalStatus);
            this.Controls.Add(this.ReadStatus);
            this.Controls.Add(this.BookType);
            this.Controls.Add(this.PriceName);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.BookListBox);
            this.Name = "BookListMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "書籍管理リスト";
            this.Load += new System.EventHandler(this.BookListMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label PriceName;
        private System.Windows.Forms.Label BookType;
        private System.Windows.Forms.Label ReadStatus;
        private System.Windows.Forms.Label RentalStatus;
        private System.Windows.Forms.Label DisplayBookName;
        private System.Windows.Forms.Label DisplayISBN;
        private System.Windows.Forms.Label DisplayAuthorName;
        private System.Windows.Forms.Label DisplayPrice;
        private System.Windows.Forms.Label DisplayBookType;
        private System.Windows.Forms.Label DisplayReadStatus;
        private System.Windows.Forms.Label DisplayRentalStatus;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExportCSVData;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.TextBox SearchInputTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

