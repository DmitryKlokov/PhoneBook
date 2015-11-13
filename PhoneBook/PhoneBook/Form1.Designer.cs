namespace PhoneBook
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_prop = new System.Windows.Forms.Button();
            this.panel_newPerson = new System.Windows.Forms.Panel();
            this.pictureBox_newImage = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_add_newadress = new System.Windows.Forms.Button();
            this.button_add_newmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.button_addphone = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_address = new System.Windows.Forms.ComboBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.comboBox_phone = new System.Windows.Forms.ComboBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.labelsurname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.listView_persons = new System.Windows.Forms.ListView();
            this.Contacts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox_person = new System.Windows.Forms.RichTextBox();
            this.listView_navigation = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_person = new System.Windows.Forms.PictureBox();
            this.panel_newPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_person)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone book";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(320, 34);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(42, 37);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_prop
            // 
            this.button_prop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prop.Location = new System.Drawing.Point(368, 34);
            this.button_prop.Name = "button_prop";
            this.button_prop.Size = new System.Drawing.Size(42, 37);
            this.button_prop.TabIndex = 4;
            this.button_prop.Text = "...";
            this.button_prop.UseVisualStyleBackColor = true;
            this.button_prop.Click += new System.EventHandler(this.button_prop_Click);
            // 
            // panel_newPerson
            // 
            this.panel_newPerson.AutoScroll = true;
            this.panel_newPerson.Controls.Add(this.pictureBox_newImage);
            this.panel_newPerson.Controls.Add(this.button_back);
            this.panel_newPerson.Controls.Add(this.button_add_newadress);
            this.panel_newPerson.Controls.Add(this.button_add_newmail);
            this.panel_newPerson.Controls.Add(this.label2);
            this.panel_newPerson.Controls.Add(this.richTextBox_description);
            this.panel_newPerson.Controls.Add(this.textBox_address);
            this.panel_newPerson.Controls.Add(this.button_addphone);
            this.panel_newPerson.Controls.Add(this.button_save);
            this.panel_newPerson.Controls.Add(this.comboBox_address);
            this.panel_newPerson.Controls.Add(this.textBox_email);
            this.panel_newPerson.Controls.Add(this.comboBox_email);
            this.panel_newPerson.Controls.Add(this.textBox_phone);
            this.panel_newPerson.Controls.Add(this.comboBox_phone);
            this.panel_newPerson.Controls.Add(this.textBox_surname);
            this.panel_newPerson.Controls.Add(this.labelsurname);
            this.panel_newPerson.Controls.Add(this.textBox_name);
            this.panel_newPerson.Controls.Add(this.labelname);
            this.panel_newPerson.Location = new System.Drawing.Point(12, 12);
            this.panel_newPerson.Name = "panel_newPerson";
            this.panel_newPerson.Size = new System.Drawing.Size(822, 546);
            this.panel_newPerson.TabIndex = 5;
            this.panel_newPerson.Visible = false;
            // 
            // pictureBox_newImage
            // 
            this.pictureBox_newImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox_newImage.Location = new System.Drawing.Point(585, 7);
            this.pictureBox_newImage.Name = "pictureBox_newImage";
            this.pictureBox_newImage.Size = new System.Drawing.Size(208, 168);
            this.pictureBox_newImage.TabIndex = 17;
            this.pictureBox_newImage.TabStop = false;
            this.pictureBox_newImage.Click += new System.EventHandler(this.pictureBox_newImage_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(25, 22);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 16;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_add_newadress
            // 
            this.button_add_newadress.Location = new System.Drawing.Point(603, 387);
            this.button_add_newadress.Name = "button_add_newadress";
            this.button_add_newadress.Size = new System.Drawing.Size(190, 23);
            this.button_add_newadress.TabIndex = 15;
            this.button_add_newadress.Text = "+ adress";
            this.button_add_newadress.UseVisualStyleBackColor = true;
            this.button_add_newadress.Click += new System.EventHandler(this.button_add_newadress_Click);
            // 
            // button_add_newmail
            // 
            this.button_add_newmail.Location = new System.Drawing.Point(323, 387);
            this.button_add_newmail.Name = "button_add_newmail";
            this.button_add_newmail.Size = new System.Drawing.Size(190, 23);
            this.button_add_newmail.TabIndex = 14;
            this.button_add_newmail.Text = "+ mail";
            this.button_add_newmail.UseVisualStyleBackColor = true;
            this.button_add_newmail.Click += new System.EventHandler(this.button_add_newmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(25, 189);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(768, 126);
            this.richTextBox_description.TabIndex = 12;
            this.richTextBox_description.Text = "";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(603, 351);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(190, 20);
            this.textBox_address.TabIndex = 9;
            // 
            // button_addphone
            // 
            this.button_addphone.Location = new System.Drawing.Point(25, 387);
            this.button_addphone.Name = "button_addphone";
            this.button_addphone.Size = new System.Drawing.Size(190, 23);
            this.button_addphone.TabIndex = 11;
            this.button_addphone.Text = "+phone";
            this.button_addphone.UseVisualStyleBackColor = true;
            this.button_addphone.Click += new System.EventHandler(this.button_addphone_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(308, 492);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(218, 51);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_address
            // 
            this.comboBox_address.FormattingEnabled = true;
            this.comboBox_address.Items.AddRange(new object[] {
            "Personal address",
            "Working address",
            "Another address"});
            this.comboBox_address.Location = new System.Drawing.Point(603, 333);
            this.comboBox_address.Name = "comboBox_address";
            this.comboBox_address.Size = new System.Drawing.Size(190, 21);
            this.comboBox_address.TabIndex = 8;
            this.comboBox_address.Text = "Personal address";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(323, 351);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(190, 20);
            this.textBox_email.TabIndex = 7;
            // 
            // comboBox_email
            // 
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.Items.AddRange(new object[] {
            "Personal mail",
            "Working mail",
            "Another mail"});
            this.comboBox_email.Location = new System.Drawing.Point(323, 333);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(190, 21);
            this.comboBox_email.TabIndex = 6;
            this.comboBox_email.Text = "Personal mail";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(25, 351);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(190, 20);
            this.textBox_phone.TabIndex = 5;
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
            this.comboBox_phone.Location = new System.Drawing.Point(25, 333);
            this.comboBox_phone.Name = "comboBox_phone";
            this.comboBox_phone.Size = new System.Drawing.Size(190, 21);
            this.comboBox_phone.TabIndex = 4;
            this.comboBox_phone.Text = "Mobile";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(76, 103);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(265, 20);
            this.textBox_surname.TabIndex = 3;
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.Location = new System.Drawing.Point(22, 110);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(49, 13);
            this.labelsurname.TabIndex = 2;
            this.labelsurname.Text = "Surname";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(76, 58);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(265, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(22, 64);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name";
            // 
            // listView_persons
            // 
            this.listView_persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contacts});
            this.listView_persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_persons.FullRowSelect = true;
            this.listView_persons.Location = new System.Drawing.Point(12, 103);
            this.listView_persons.Name = "listView_persons";
            this.listView_persons.Size = new System.Drawing.Size(398, 455);
            this.listView_persons.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_persons.TabIndex = 6;
            this.listView_persons.UseCompatibleStateImageBehavior = false;
            this.listView_persons.View = System.Windows.Forms.View.Details;
            this.listView_persons.SelectedIndexChanged += new System.EventHandler(this.listView_persons_SelectedIndexChanged);
            // 
            // Contacts
            // 
            this.Contacts.Text = "Contacts";
            this.Contacts.Width = 359;
            // 
            // richTextBox_person
            // 
            this.richTextBox_person.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_person.Enabled = false;
            this.richTextBox_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_person.Location = new System.Drawing.Point(423, 169);
            this.richTextBox_person.Name = "richTextBox_person";
            this.richTextBox_person.Size = new System.Drawing.Size(422, 389);
            this.richTextBox_person.TabIndex = 7;
            this.richTextBox_person.Text = "";
            // 
            // listView_navigation
            // 
            this.listView_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_navigation.Location = new System.Drawing.Point(12, 103);
            this.listView_navigation.Name = "listView_navigation";
            this.listView_navigation.Size = new System.Drawing.Size(398, 454);
            this.listView_navigation.TabIndex = 8;
            this.listView_navigation.UseCompatibleStateImageBehavior = false;
            this.listView_navigation.Visible = false;
            this.listView_navigation.SelectedIndexChanged += new System.EventHandler(this.listView_navigation_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox_person
            // 
            this.pictureBox_person.Location = new System.Drawing.Point(423, 19);
            this.pictureBox_person.Name = "pictureBox_person";
            this.pictureBox_person.Size = new System.Drawing.Size(173, 150);
            this.pictureBox_person.TabIndex = 9;
            this.pictureBox_person.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 570);
            this.Controls.Add(this.panel_newPerson);
            this.Controls.Add(this.listView_navigation);
            this.Controls.Add(this.button_prop);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox_person);
            this.Controls.Add(this.listView_persons);
            this.Controls.Add(this.pictureBox_person);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_newPerson.ResumeLayout(false);
            this.panel_newPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_prop;
        private System.Windows.Forms.Panel panel_newPerson;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.ComboBox comboBox_address;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.ComboBox comboBox_phone;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.ListView listView_persons;
        private System.Windows.Forms.ColumnHeader Contacts;
        private System.Windows.Forms.RichTextBox richTextBox_person;
        private System.Windows.Forms.Button button_addphone;
        private System.Windows.Forms.Button button_add_newmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Button button_add_newadress;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ListView listView_navigation;
        private System.Windows.Forms.PictureBox pictureBox_newImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_person;
    }
}

