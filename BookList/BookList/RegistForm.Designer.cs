namespace AddressList
{
    partial class RegistForm
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
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BookTypeLabel = new System.Windows.Forms.Label();
            this.ReadStatus = new System.Windows.Forms.Label();
            this.RentalStatus = new System.Windows.Forms.Label();
            this.RegistButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.BookTypeTextBox = new System.Windows.Forms.TextBox();
            this.ReadStatusComboBox = new System.Windows.Forms.ComboBox();
            this.RentalStatusComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(14, 9);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(41, 12);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "書籍名";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(14, 34);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(31, 12);
            this.ISBNLabel.TabIndex = 1;
            this.ISBNLabel.Text = "ISBN";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(14, 59);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(29, 12);
            this.AuthorName.TabIndex = 2;
            this.AuthorName.Text = "著者";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(14, 84);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(29, 12);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "金額";
            // 
            // BookTypeLabel
            // 
            this.BookTypeLabel.AutoSize = true;
            this.BookTypeLabel.Location = new System.Drawing.Point(14, 109);
            this.BookTypeLabel.Name = "BookTypeLabel";
            this.BookTypeLabel.Size = new System.Drawing.Size(55, 12);
            this.BookTypeLabel.TabIndex = 4;
            this.BookTypeLabel.Text = "書籍タイプ";
            // 
            // ReadStatus
            // 
            this.ReadStatus.AutoSize = true;
            this.ReadStatus.Location = new System.Drawing.Point(14, 134);
            this.ReadStatus.Name = "ReadStatus";
            this.ReadStatus.Size = new System.Drawing.Size(53, 12);
            this.ReadStatus.TabIndex = 5;
            this.ReadStatus.Text = "積読状態";
            // 
            // RentalStatus
            // 
            this.RentalStatus.AutoSize = true;
            this.RentalStatus.Location = new System.Drawing.Point(14, 159);
            this.RentalStatus.Name = "RentalStatus";
            this.RentalStatus.Size = new System.Drawing.Size(53, 12);
            this.RentalStatus.TabIndex = 6;
            this.RentalStatus.Text = "貸出状態";
            // 
            // RegistButton
            // 
            this.RegistButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistButton.Location = new System.Drawing.Point(145, 184);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(75, 23);
            this.RegistButton.TabIndex = 14;
            this.RegistButton.Text = "登録";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(226, 184);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(145, 6);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(156, 19);
            this.BookNameTextBox.TabIndex = 7;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(145, 31);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(156, 19);
            this.ISBNTextBox.TabIndex = 8;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(145, 56);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(156, 19);
            this.AuthorTextBox.TabIndex = 9;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(145, 81);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(156, 19);
            this.PriceTextBox.TabIndex = 10;
            // 
            // BookTypeTextBox
            // 
            this.BookTypeTextBox.Location = new System.Drawing.Point(145, 106);
            this.BookTypeTextBox.Name = "BookTypeTextBox";
            this.BookTypeTextBox.Size = new System.Drawing.Size(156, 19);
            this.BookTypeTextBox.TabIndex = 11;
            // 
            // ReadStatusComboBox
            // 
            this.ReadStatusComboBox.FormattingEnabled = true;
            this.ReadStatusComboBox.Items.AddRange(new object[] {
            "未読",
            "読書中",
            "読了"});
            this.ReadStatusComboBox.Location = new System.Drawing.Point(145, 131);
            this.ReadStatusComboBox.Name = "ReadStatusComboBox";
            this.ReadStatusComboBox.Size = new System.Drawing.Size(66, 20);
            this.ReadStatusComboBox.TabIndex = 12;
            // 
            // RentalStatusComboBox
            // 
            this.RentalStatusComboBox.FormattingEnabled = true;
            this.RentalStatusComboBox.Items.AddRange(new object[] {
            "所持",
            "貸出"});
            this.RentalStatusComboBox.Location = new System.Drawing.Point(145, 156);
            this.RentalStatusComboBox.Name = "RentalStatusComboBox";
            this.RentalStatusComboBox.Size = new System.Drawing.Size(66, 20);
            this.RentalStatusComboBox.TabIndex = 13;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(145, 184);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 223);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RentalStatusComboBox);
            this.Controls.Add(this.ReadStatusComboBox);
            this.Controls.Add(this.BookTypeTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.RentalStatus);
            this.Controls.Add(this.ReadStatus);
            this.Controls.Add(this.BookTypeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Name = "RegistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistForm";
            this.Load += new System.EventHandler(this.RegistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label BookTypeLabel;
        private System.Windows.Forms.Label ReadStatus;
        private System.Windows.Forms.Label RentalStatus;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox BookTypeTextBox;
        private System.Windows.Forms.ComboBox ReadStatusComboBox;
        private System.Windows.Forms.ComboBox RentalStatusComboBox;
        private System.Windows.Forms.Button UpdateButton;
    }
}