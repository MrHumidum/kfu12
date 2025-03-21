namespace kfu12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.readTxtFileButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.saveTxtFileButton = new System.Windows.Forms.Button();
            this.readImageFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(488, 493);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(506, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(279, 394);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectItem);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Title = "Open";
            // 
            // readTxtFileButton
            // 
            this.readTxtFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readTxtFileButton.Location = new System.Drawing.Point(506, 474);
            this.readTxtFileButton.Name = "readTxtFileButton";
            this.readTxtFileButton.Size = new System.Drawing.Size(140, 34);
            this.readTxtFileButton.TabIndex = 6;
            this.readTxtFileButton.Text = "Открыть txt файл";
            this.readTxtFileButton.UseVisualStyleBackColor = true;
            this.readTxtFileButton.Click += new System.EventHandler(this.readfileButton_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(12, 517);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(488, 20);
            this.textBox.TabIndex = 7;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // saveTxtFileButton
            // 
            this.saveTxtFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTxtFileButton.Location = new System.Drawing.Point(506, 511);
            this.saveTxtFileButton.Name = "saveTxtFileButton";
            this.saveTxtFileButton.Size = new System.Drawing.Size(280, 34);
            this.saveTxtFileButton.TabIndex = 0;
            this.saveTxtFileButton.Text = "Сохранить список";
            this.saveTxtFileButton.UseVisualStyleBackColor = true;
            this.saveTxtFileButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readImageFileButton
            // 
            this.readImageFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readImageFileButton.Location = new System.Drawing.Point(506, 436);
            this.readImageFileButton.Name = "readImageFileButton";
            this.readImageFileButton.Size = new System.Drawing.Size(140, 34);
            this.readImageFileButton.TabIndex = 7;
            this.readImageFileButton.Text = "Открыть изображение";
            this.readImageFileButton.UseVisualStyleBackColor = true;
            this.readImageFileButton.Click += new System.EventHandler(this.readImageFileButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRowButton.Location = new System.Drawing.Point(646, 436);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(140, 34);
            this.deleteRowButton.TabIndex = 8;
            this.deleteRowButton.Text = "Удалить элемент";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(646, 474);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 34);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Очистить список";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "По алфавиту",
            "Против алфавита"});
            this.sortComboBox.Location = new System.Drawing.Point(646, 412);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(139, 21);
            this.sortComboBox.TabIndex = 10;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сортировка:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(793, 549);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.readImageFileButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.readTxtFileButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.saveTxtFileButton);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(809, 588);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kfu12";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button readTxtFileButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button saveTxtFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button readImageFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label label1;
    }
}

