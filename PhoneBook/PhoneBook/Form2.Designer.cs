namespace PhoneBook
{
    partial class Form2
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.labelsurname = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.button_add_newadress = new System.Windows.Forms.Button();
            this.button_add_newmail = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.button_addphone = new System.Windows.Forms.Button();
            this.comboBox_address = new System.Windows.Forms.ComboBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.comboBox_phone = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_newImage = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(78, 45);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(265, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(17, 52);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Name";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(78, 87);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(265, 20);
            this.textBox_surname.TabIndex = 4;
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.Location = new System.Drawing.Point(17, 94);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(49, 13);
            this.labelsurname.TabIndex = 5;
            this.labelsurname.Text = "Surname";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(17, 174);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(730, 126);
            this.richTextBox_description.TabIndex = 19;
            this.richTextBox_description.Text = "";
            // 
            // button_add_newadress
            // 
            this.button_add_newadress.BackColor = System.Drawing.SystemColors.Window;
            this.button_add_newadress.Location = new System.Drawing.Point(557, 386);
            this.button_add_newadress.Name = "button_add_newadress";
            this.button_add_newadress.Size = new System.Drawing.Size(190, 40);
            this.button_add_newadress.TabIndex = 29;
            this.button_add_newadress.Text = "+ adress";
            this.button_add_newadress.UseVisualStyleBackColor = false;
            this.button_add_newadress.Click += new System.EventHandler(this.button_add_newadress_Click);
            // 
            // button_add_newmail
            // 
            this.button_add_newmail.BackColor = System.Drawing.SystemColors.Window;
            this.button_add_newmail.Location = new System.Drawing.Point(294, 386);
            this.button_add_newmail.Name = "button_add_newmail";
            this.button_add_newmail.Size = new System.Drawing.Size(190, 40);
            this.button_add_newmail.TabIndex = 28;
            this.button_add_newmail.Text = "+ mail";
            this.button_add_newmail.UseVisualStyleBackColor = false;
            this.button_add_newmail.Click += new System.EventHandler(this.button_add_newmail_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(557, 350);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(190, 20);
            this.textBox_address.TabIndex = 25;
            // 
            // button_addphone
            // 
            this.button_addphone.BackColor = System.Drawing.SystemColors.Window;
            this.button_addphone.Location = new System.Drawing.Point(17, 386);
            this.button_addphone.Name = "button_addphone";
            this.button_addphone.Size = new System.Drawing.Size(190, 40);
            this.button_addphone.TabIndex = 27;
            this.button_addphone.Text = "+phone";
            this.button_addphone.UseVisualStyleBackColor = false;
            this.button_addphone.Click += new System.EventHandler(this.button_addphone_Click);
            // 
            // comboBox_address
            // 
            this.comboBox_address.FormattingEnabled = true;
            this.comboBox_address.Items.AddRange(new object[] {
            "Personal address",
            "Working address",
            "Another address"});
            this.comboBox_address.Location = new System.Drawing.Point(557, 332);
            this.comboBox_address.Name = "comboBox_address";
            this.comboBox_address.Size = new System.Drawing.Size(190, 21);
            this.comboBox_address.TabIndex = 24;
            this.comboBox_address.Text = "Personal address";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(294, 350);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(190, 20);
            this.textBox_email.TabIndex = 23;
            // 
            // comboBox_email
            // 
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.Items.AddRange(new object[] {
            "Personal mail",
            "Working mail",
            "Another mail"});
            this.comboBox_email.Location = new System.Drawing.Point(294, 332);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(190, 21);
            this.comboBox_email.TabIndex = 22;
            this.comboBox_email.Text = "Personal mail";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(17, 350);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(190, 20);
            this.textBox_phone.TabIndex = 21;
            // 
            // comboBox_phone
            // 
            this.comboBox_phone.FormattingEnabled = true;
            this.comboBox_phone.Items.AddRange(new object[] {
            "Mobile",
            "Home",
            "Working",
            "Organization",
            "Pager",
            "Home fax",
            "Business fax"});
            this.comboBox_phone.Location = new System.Drawing.Point(17, 332);
            this.comboBox_phone.Name = "comboBox_phone";
            this.comboBox_phone.Size = new System.Drawing.Size(190, 21);
            this.comboBox_phone.TabIndex = 20;
            this.comboBox_phone.Text = "Mobile";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox_newImage);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.labelsurname);
            this.panel1.Controls.Add(this.richTextBox_description);
            this.panel1.Controls.Add(this.textBox_surname);
            this.panel1.Controls.Add(this.button_add_newadress);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.comboBox_email);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.button_add_newmail);
            this.panel1.Controls.Add(this.comboBox_phone);
            this.panel1.Controls.Add(this.textBox_address);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.button_addphone);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.comboBox_address);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 509);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox_newImage
            // 
            this.pictureBox_newImage.Image = global::PhoneBook.Properties.Resources.newperson;
            this.pictureBox_newImage.Location = new System.Drawing.Point(440, 14);
            this.pictureBox_newImage.Name = "pictureBox_newImage";
            this.pictureBox_newImage.Size = new System.Drawing.Size(171, 144);
            this.pictureBox_newImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_newImage.TabIndex = 30;
            this.pictureBox_newImage.TabStop = false;
            this.pictureBox_newImage.Click += new System.EventHandler(this.pictureBox_newImage_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(662, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(85, 85);
            this.button_save.TabIndex = 26;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(794, 533);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "PhoneBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Button button_add_newadress;
        private System.Windows.Forms.Button button_add_newmail;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Button button_addphone;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_address;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.ComboBox comboBox_phone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_newImage;
    }
}