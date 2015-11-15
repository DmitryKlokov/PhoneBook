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
            this.listView_persons = new System.Windows.Forms.ListView();
            this.Contacts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox_person = new System.Windows.Forms.RichTextBox();
            this.listView_navigation = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_person = new System.Windows.Forms.PictureBox();
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
            this.listView_navigation.Location = new System.Drawing.Point(12, 104);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_prop;
        private System.Windows.Forms.ColumnHeader Contacts;
        private System.Windows.Forms.RichTextBox richTextBox_person;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_person;
        private System.Windows.Forms.ListView listView_navigation;
        public System.Windows.Forms.ListView listView_persons;
    }
}

