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
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_persons = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_quickNavigation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_removePerson = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.pictureBox_person = new System.Windows.Forms.PictureBox();
            this.richTextBox_person = new System.Windows.Forms.RichTextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_phones = new System.Windows.Forms.Label();
            this.listView_phones = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Mails = new System.Windows.Forms.Label();
            this.listView_mails = new System.Windows.Forms.ListView();
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Addresses = new System.Windows.Forms.Label();
            this.listView_addresses = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesriptionAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_person)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_find
            // 
            this.textBox_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_find.Location = new System.Drawing.Point(111, 95);
            this.textBox_find.Multiline = true;
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(299, 29);
            this.textBox_find.TabIndex = 1;
            this.textBox_find.TextChanged += new System.EventHandler(this.textBox_find_TextChanged);
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
            this.button_add.BackColor = System.Drawing.SystemColors.Window;
            this.button_add.BackgroundImage = global::PhoneBook.Properties.Resources.addContact;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(325, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 85);
            this.button_add.TabIndex = 3;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search";
            // 
            // listView_persons
            // 
            this.listView_persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView_persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_persons.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_persons.Location = new System.Drawing.Point(12, 130);
            this.listView_persons.Name = "listView_persons";
            this.listView_persons.Size = new System.Drawing.Size(398, 499);
            this.listView_persons.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_persons.TabIndex = 13;
            this.listView_persons.UseCompatibleStateImageBehavior = false;
            this.listView_persons.View = System.Windows.Forms.View.Details;
            this.listView_persons.SelectedIndexChanged += new System.EventHandler(this.listView_persons_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 375;
            // 
            // listView_quickNavigation
            // 
            this.listView_quickNavigation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_quickNavigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_quickNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_quickNavigation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listView_quickNavigation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_quickNavigation.Location = new System.Drawing.Point(12, 130);
            this.listView_quickNavigation.Name = "listView_quickNavigation";
            this.listView_quickNavigation.Size = new System.Drawing.Size(398, 499);
            this.listView_quickNavigation.TabIndex = 14;
            this.listView_quickNavigation.UseCompatibleStateImageBehavior = false;
            this.listView_quickNavigation.View = System.Windows.Forms.View.Details;
            this.listView_quickNavigation.Visible = false;
            this.listView_quickNavigation.SelectedIndexChanged += new System.EventHandler(this.listView_quickNavigation_SelectedIndexChanged);
            // 
            // button_removePerson
            // 
            this.button_removePerson.BackColor = System.Drawing.SystemColors.Window;
            this.button_removePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_removePerson.FlatAppearance.BorderSize = 0;
            this.button_removePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removePerson.Location = new System.Drawing.Point(759, 19);
            this.button_removePerson.Name = "button_removePerson";
            this.button_removePerson.Size = new System.Drawing.Size(85, 30);
            this.button_removePerson.TabIndex = 12;
            this.button_removePerson.Text = "Remove";
            this.button_removePerson.UseVisualStyleBackColor = false;
            this.button_removePerson.Visible = false;
            this.button_removePerson.Click += new System.EventHandler(this.button_removePerson_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.Window;
            this.button_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Location = new System.Drawing.Point(668, 19);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(85, 30);
            this.button_edit.TabIndex = 10;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Visible = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // pictureBox_person
            // 
            this.pictureBox_person.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_person.Location = new System.Drawing.Point(423, 4);
            this.pictureBox_person.Name = "pictureBox_person";
            this.pictureBox_person.Size = new System.Drawing.Size(231, 199);
            this.pictureBox_person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_person.TabIndex = 15;
            this.pictureBox_person.TabStop = false;
            // 
            // richTextBox_person
            // 
            this.richTextBox_person.BackColor = System.Drawing.Color.Gray;
            this.richTextBox_person.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_person.Location = new System.Drawing.Point(440, 550);
            this.richTextBox_person.Name = "richTextBox_person";
            this.richTextBox_person.ReadOnly = true;
            this.richTextBox_person.Size = new System.Drawing.Size(404, 79);
            this.richTextBox_person.TabIndex = 7;
            this.richTextBox_person.Text = "";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.Gray;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(436, 209);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(398, 31);
            this.textBox_name.TabIndex = 16;
            // 
            // label_phones
            // 
            this.label_phones.AutoSize = true;
            this.label_phones.BackColor = System.Drawing.Color.Gray;
            this.label_phones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_phones.Location = new System.Drawing.Point(432, 234);
            this.label_phones.Name = "label_phones";
            this.label_phones.Size = new System.Drawing.Size(71, 22);
            this.label_phones.TabIndex = 17;
            this.label_phones.Text = "Phones";
            // 
            // listView_phones
            // 
            this.listView_phones.BackColor = System.Drawing.Color.Gray;
            this.listView_phones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_phones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Description});
            this.listView_phones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_phones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_phones.Location = new System.Drawing.Point(436, 259);
            this.listView_phones.Name = "listView_phones";
            this.listView_phones.Size = new System.Drawing.Size(398, 71);
            this.listView_phones.TabIndex = 18;
            this.listView_phones.UseCompatibleStateImageBehavior = false;
            this.listView_phones.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Width = 191;
            // 
            // Description
            // 
            this.Description.Width = 173;
            // 
            // label_Mails
            // 
            this.label_Mails.AutoSize = true;
            this.label_Mails.BackColor = System.Drawing.Color.Gray;
            this.label_Mails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Mails.Location = new System.Drawing.Point(432, 324);
            this.label_Mails.Name = "label_Mails";
            this.label_Mails.Size = new System.Drawing.Size(51, 22);
            this.label_Mails.TabIndex = 19;
            this.label_Mails.Text = "Mails";
            // 
            // listView_mails
            // 
            this.listView_mails.BackColor = System.Drawing.Color.Gray;
            this.listView_mails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_mails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mail,
            this.DescriptionMail});
            this.listView_mails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_mails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_mails.Location = new System.Drawing.Point(436, 349);
            this.listView_mails.Name = "listView_mails";
            this.listView_mails.Size = new System.Drawing.Size(398, 71);
            this.listView_mails.TabIndex = 20;
            this.listView_mails.UseCompatibleStateImageBehavior = false;
            this.listView_mails.View = System.Windows.Forms.View.Details;
            // 
            // Mail
            // 
            this.Mail.Width = 192;
            // 
            // DescriptionMail
            // 
            this.DescriptionMail.Width = 174;
            // 
            // label_Addresses
            // 
            this.label_Addresses.AutoSize = true;
            this.label_Addresses.BackColor = System.Drawing.Color.Gray;
            this.label_Addresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Addresses.Location = new System.Drawing.Point(435, 423);
            this.label_Addresses.Name = "label_Addresses";
            this.label_Addresses.Size = new System.Drawing.Size(95, 22);
            this.label_Addresses.TabIndex = 21;
            this.label_Addresses.Text = "Addresses";
            // 
            // listView_addresses
            // 
            this.listView_addresses.BackColor = System.Drawing.Color.Gray;
            this.listView_addresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_addresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.DesriptionAddress});
            this.listView_addresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_addresses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_addresses.Location = new System.Drawing.Point(439, 443);
            this.listView_addresses.Name = "listView_addresses";
            this.listView_addresses.Size = new System.Drawing.Size(395, 71);
            this.listView_addresses.TabIndex = 22;
            this.listView_addresses.UseCompatibleStateImageBehavior = false;
            this.listView_addresses.View = System.Windows.Forms.View.Details;
            // 
            // Address
            // 
            this.Address.Width = 189;
            // 
            // DesriptionAddress
            // 
            this.DesriptionAddress.Width = 170;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.Color.Gray;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.Location = new System.Drawing.Point(436, 521);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(100, 22);
            this.label_description.TabIndex = 23;
            this.label_description.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PhoneBook.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(846, 641);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.listView_addresses);
            this.Controls.Add(this.label_Addresses);
            this.Controls.Add(this.listView_mails);
            this.Controls.Add(this.label_Mails);
            this.Controls.Add(this.listView_phones);
            this.Controls.Add(this.label_phones);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_person);
            this.Controls.Add(this.listView_quickNavigation);
            this.Controls.Add(this.button_removePerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.richTextBox_person);
            this.Controls.Add(this.listView_persons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_removePerson;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView_persons;
        private System.Windows.Forms.ListView listView_quickNavigation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox_person;
        private System.Windows.Forms.RichTextBox richTextBox_person;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_phones;
        private System.Windows.Forms.ListView listView_phones;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label_Mails;
        private System.Windows.Forms.ListView listView_mails;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader DescriptionMail;
        private System.Windows.Forms.Label label_Addresses;
        private System.Windows.Forms.ListView listView_addresses;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader DesriptionAddress;
        private System.Windows.Forms.Label label_description;
    }
}

