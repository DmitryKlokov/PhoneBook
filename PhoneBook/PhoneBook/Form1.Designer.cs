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
            this.richTextBox_person = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_person = new System.Windows.Forms.PictureBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_removePerson = new System.Windows.Forms.Button();
            this.listView_persons = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_quickNavigation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_person)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(59, 77);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(351, 20);
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
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(347, 19);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(63, 56);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // richTextBox_person
            // 
            this.richTextBox_person.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox_person.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_person.Location = new System.Drawing.Point(423, 169);
            this.richTextBox_person.Name = "richTextBox_person";
            this.richTextBox_person.ReadOnly = true;
            this.richTextBox_person.Size = new System.Drawing.Size(422, 389);
            this.richTextBox_person.TabIndex = 7;
            this.richTextBox_person.Text = "";
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
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.Window;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.Location = new System.Drawing.Point(759, 19);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 10;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Visible = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search";
            // 
            // button_removePerson
            // 
            this.button_removePerson.BackColor = System.Drawing.SystemColors.Window;
            this.button_removePerson.Location = new System.Drawing.Point(759, 49);
            this.button_removePerson.Name = "button_removePerson";
            this.button_removePerson.Size = new System.Drawing.Size(75, 23);
            this.button_removePerson.TabIndex = 12;
            this.button_removePerson.Text = "Remove";
            this.button_removePerson.UseVisualStyleBackColor = false;
            this.button_removePerson.Visible = false;
            this.button_removePerson.Click += new System.EventHandler(this.button_removePerson_Click);
            // 
            // listView_persons
            // 
            this.listView_persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView_persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_persons.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_persons.Location = new System.Drawing.Point(12, 114);
            this.listView_persons.Name = "listView_persons";
            this.listView_persons.Size = new System.Drawing.Size(398, 444);
            this.listView_persons.TabIndex = 13;
            this.listView_persons.UseCompatibleStateImageBehavior = false;
            this.listView_persons.View = System.Windows.Forms.View.Details;
            this.listView_persons.SelectedIndexChanged += new System.EventHandler(this.listView_persons_SelectedIndexChanged_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 375;
            // 
            // listView_quickNavigation
            // 
            this.listView_quickNavigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_quickNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_quickNavigation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listView_quickNavigation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_quickNavigation.Location = new System.Drawing.Point(12, 114);
            this.listView_quickNavigation.Name = "listView_quickNavigation";
            this.listView_quickNavigation.Size = new System.Drawing.Size(398, 444);
            this.listView_quickNavigation.TabIndex = 14;
            this.listView_quickNavigation.UseCompatibleStateImageBehavior = false;
            this.listView_quickNavigation.View = System.Windows.Forms.View.Details;
            this.listView_quickNavigation.Visible = false;
            this.listView_quickNavigation.SelectedIndexChanged += new System.EventHandler(this.listView_quickNavigation_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(846, 570);
            this.Controls.Add(this.listView_quickNavigation);
            this.Controls.Add(this.button_removePerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.richTextBox_person);
            this.Controls.Add(this.pictureBox_person);
            this.Controls.Add(this.listView_persons);
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
        private System.Windows.Forms.RichTextBox richTextBox_person;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_person;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_removePerson;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView_persons;
        private System.Windows.Forms.ListView listView_quickNavigation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

