namespace ContactsApp.View
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.ButtonContactAppPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            this.ButtonContactAppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(118, 178);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.DateOfBirthDateTimePicker.TabIndex = 37;
            this.DateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirthDateTimePicker_ValueChanged);
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(46, 118);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoButton.TabIndex = 36;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            // 
            // ButtonContactAppPanel
            // 
            this.ButtonContactAppPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonContactAppPanel.Controls.Add(this.CancelButton);
            this.ButtonContactAppPanel.Controls.Add(this.OKButton);
            this.ButtonContactAppPanel.Location = new System.Drawing.Point(-3, 276);
            this.ButtonContactAppPanel.Name = "ButtonContactAppPanel";
            this.ButtonContactAppPanel.Size = new System.Drawing.Size(514, 45);
            this.ButtonContactAppPanel.TabIndex = 35;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(424, 9);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(343, 9);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(118, 226);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(180, 20);
            this.VKTextBox.TabIndex = 34;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(118, 210);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 33;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 161);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 32;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 128);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.PhoneNumberTextBox.TabIndex = 31;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 111);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 30;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(118, 78);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(379, 20);
            this.EmailTextBox.TabIndex = 29;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 62);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 28;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 28);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(379, 20);
            this.FullNameTextBox.TabIndex = 27;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 12);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 26;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 25;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 318);
            this.Controls.Add(this.DateOfBirthDateTimePicker);
            this.Controls.Add(this.AddPhotoButton);
            this.Controls.Add(this.ButtonContactAppPanel);
            this.Controls.Add(this.VKTextBox);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            this.ButtonContactAppPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.PictureBox AddPhotoButton;
        private System.Windows.Forms.Panel ButtonContactAppPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
    }
}