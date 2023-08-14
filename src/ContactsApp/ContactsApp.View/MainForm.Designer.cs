namespace ContactsApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddContactbutton = new System.Windows.Forms.PictureBox();
            this.EditContactbutton = new System.Windows.Forms.PictureBox();
            this.RemoveContactbutton = new System.Windows.Forms.PictureBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.PictureBox();
            this.TodayIsBirthdayOfLabel = new System.Windows.Forms.Label();
            this.ImageInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactbutton)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.LeftPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.RightPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.LeftPanel.Controls.Add(this.FindLabel);
            this.LeftPanel.Controls.Add(this.FindTextBox);
            this.LeftPanel.Controls.Add(this.ContactsListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(244, 444);
            this.LeftPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactbutton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactbutton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveContactbutton, 2, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 405);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 36);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // AddContactbutton
            // 
            this.AddContactbutton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactbutton.Location = new System.Drawing.Point(0, 0);
            this.AddContactbutton.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactbutton.Name = "AddContactbutton";
            this.AddContactbutton.Size = new System.Drawing.Size(79, 36);
            this.AddContactbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactbutton.TabIndex = 0;
            this.AddContactbutton.TabStop = false;
            this.AddContactbutton.Click += new System.EventHandler(this.AddContactbutton_Click);
            this.AddContactbutton.MouseEnter += new System.EventHandler(this.AddContactbutton_MouseEnter);
            this.AddContactbutton.MouseLeave += new System.EventHandler(this.AddContactbutton_MouseLeave);
            // 
            // EditContactbutton
            // 
            this.EditContactbutton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactbutton.Location = new System.Drawing.Point(79, 0);
            this.EditContactbutton.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactbutton.Name = "EditContactbutton";
            this.EditContactbutton.Size = new System.Drawing.Size(79, 36);
            this.EditContactbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactbutton.TabIndex = 1;
            this.EditContactbutton.TabStop = false;
            this.EditContactbutton.Click += new System.EventHandler(this.EditContactbutton_Click);
            this.EditContactbutton.MouseEnter += new System.EventHandler(this.EditContactbutton_MouseEnter);
            this.EditContactbutton.MouseLeave += new System.EventHandler(this.EditContactbutton_MouseLeave);
            // 
            // RemoveContactbutton
            // 
            this.RemoveContactbutton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactbutton.Location = new System.Drawing.Point(158, 0);
            this.RemoveContactbutton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactbutton.Name = "RemoveContactbutton";
            this.RemoveContactbutton.Size = new System.Drawing.Size(80, 36);
            this.RemoveContactbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveContactbutton.TabIndex = 2;
            this.RemoveContactbutton.TabStop = false;
            this.RemoveContactbutton.Click += new System.EventHandler(this.RemoveContactbutton_Click);
            this.RemoveContactbutton.MouseEnter += new System.EventHandler(this.RemoveContactbutton_MouseEnter);
            this.RemoveContactbutton.MouseLeave += new System.EventHandler(this.RemoveContactbutton_MouseLeave);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(9, 6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(55, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(186, 20);
            this.FindTextBox.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 29);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 376);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.BirthdayPanel);
            this.RightPanel.Controls.Add(this.VKTextBox);
            this.RightPanel.Controls.Add(this.VKLabel);
            this.RightPanel.Controls.Add(this.DateOfBirthTextBox);
            this.RightPanel.Controls.Add(this.DateOfBirthLabel);
            this.RightPanel.Controls.Add(this.PhoneNumberTextBox);
            this.RightPanel.Controls.Add(this.PhoneNumberLabel);
            this.RightPanel.Controls.Add(this.EmailTextBox);
            this.RightPanel.Controls.Add(this.EmailLabel);
            this.RightPanel.Controls.Add(this.FullNameTextBox);
            this.RightPanel.Controls.Add(this.FullNameLabel);
            this.RightPanel.Controls.Add(this.PhotoPictureBox);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(253, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(544, 444);
            this.RightPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelCloseButton);
            this.BirthdayPanel.Controls.Add(this.TodayIsBirthdayOfLabel);
            this.BirthdayPanel.Controls.Add(this.ImageInfoPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 366);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(538, 75);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(503, 3);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(32, 32);
            this.BirthdayPanelCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BirthdayPanelCloseButton.TabIndex = 3;
            this.BirthdayPanelCloseButton.TabStop = false;
            this.BirthdayPanelCloseButton.Click += new System.EventHandler(this.BirthdayPanelCloseButton_Click);
            // 
            // TodayIsBirthdayOfLabel
            // 
            this.TodayIsBirthdayOfLabel.AutoSize = true;
            this.TodayIsBirthdayOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayIsBirthdayOfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.TodayIsBirthdayOfLabel.Location = new System.Drawing.Point(69, 22);
            this.TodayIsBirthdayOfLabel.Name = "TodayIsBirthdayOfLabel";
            this.TodayIsBirthdayOfLabel.Size = new System.Drawing.Size(124, 13);
            this.TodayIsBirthdayOfLabel.TabIndex = 1;
            this.TodayIsBirthdayOfLabel.Text = "Today is Birthday of:";
            // 
            // ImageInfoPictureBox
            // 
            this.ImageInfoPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.ImageInfoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ImageInfoPictureBox.Name = "ImageInfoPictureBox";
            this.ImageInfoPictureBox.Size = new System.Drawing.Size(61, 69);
            this.ImageInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageInfoPictureBox.TabIndex = 0;
            this.ImageInfoPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(110, 220);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(180, 20);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(110, 204);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(110, 171);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(180, 20);
            this.DateOfBirthTextBox.TabIndex = 8;
            this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(110, 155);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(110, 122);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(110, 105);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(110, 72);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(431, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(110, 56);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(110, 22);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(431, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(110, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddContactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactbutton)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.PictureBox AddContactbutton;
        private System.Windows.Forms.PictureBox EditContactbutton;
        private System.Windows.Forms.PictureBox RemoveContactbutton;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.PictureBox BirthdayPanelCloseButton;
        private System.Windows.Forms.Label TodayIsBirthdayOfLabel;
        private System.Windows.Forms.PictureBox ImageInfoPictureBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
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

