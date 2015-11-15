using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form2 : Form
    {
        private readonly PersonsManager _pm;
        public Form2(PersonsManager pm)
        {
            this._pm = pm;
            InitializeComponent();
        }

        private readonly List<NewControl> _newControls = new List<NewControl>();

        string[] give_elementscombobox(ComboBox c)
        {
            List<string> s = new List<string>();
            foreach (var i in c.Items)
            {
                s.Add(i.ToString());
            }
            return s.ToArray();
        }

        private void AddNewControls(int x, int y, string[] items, string name)
        {
            var cb = new ComboBox() { Location = new Point(x, y), Width = 190, Height = 20, Name = "comboBox_" + name, Text = items[0] };
            cb.Items.AddRange(items);
            Controls.Add(cb);
            var b = new TextBox()
            {
                Location = new Point(x, y + 20),
                Width = 190,
                Height = 20,
                Name = "textBox_" + name
            };
            Controls.Add(b);
            if (y + 80 > button_save.Location.Y) button_save.Location = new Point(button_save.Location.X, button_save.Location.Y + 60);
            _newControls.Add(new NewControl(name, cb, b));
        }

        private void pictureBox_newImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                pictureBox_newImage.SizeMode = PictureBoxSizeMode.StretchImage;
                var myImage = new Bitmap(openFileDialog1.FileName);
                pictureBox_newImage.Image = myImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void button_addphone_Click(object sender, EventArgs e)
        {
            AddNewControls(button_addphone.Location.X, button_addphone.Location.Y, give_elementscombobox(comboBox_phone), "phone");
            button_addphone.Location = new Point(button_addphone.Location.X, button_addphone.Location.Y + 60);
        }

        private void button_add_newmail_Click(object sender, EventArgs e)
        {
            AddNewControls(button_add_newmail.Location.X, button_add_newmail.Location.Y, give_elementscombobox(comboBox_email), "email");
            button_add_newmail.Location = new Point(button_add_newmail.Location.X, button_add_newmail.Location.Y + 60);
        }

        private void button_add_newadress_Click(object sender, EventArgs e)
        {
            AddNewControls(button_add_newadress.Location.X, button_add_newadress.Location.Y, give_elementscombobox(comboBox_address), "address");
            button_add_newadress.Location = new Point(button_add_newadress.Location.X, button_add_newadress.Location.Y + 60);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_surname.Text == "" || textBox_phone.Text == "") return;
            var p = new Person();
            p.Name = textBox_name.Text;
            p.Surname = textBox_surname.Text;
            if (textBox_phone.Text != "") p.Phones.Add(new Field(comboBox_phone.Text, textBox_phone.Text));
            foreach (var nc in _newControls.FindAll(c => c.type == "phone"))
            {
                if (nc.value.Text != "") p.Phones.Add(new Field(nc.key.Text, nc.value.Text));
            }
            if (textBox_email.Text != "") p.Emails.Add(new Field(comboBox_email.Text, textBox_email.Text));
            foreach (var nc in _newControls.FindAll(c => c.type == "email"))
            {
                if (nc.value.Text != "") p.Emails.Add(new Field(nc.key.Text, nc.value.Text));
            }
            if (textBox_address.Text != "") p.Addresses.Add(new Field(comboBox_address.Text, textBox_address.Text));
            foreach (var nc in _newControls.FindAll(c => c.type == "address"))
            {
                 if (nc.value.Text != "") p.Addresses.Add(new Field(nc.key.Text, nc.value.Text));
            }
            p.Description = richTextBox_description.Text;
            if (pictureBox_newImage.Image != null) p.LargeIcon = (Bitmap)pictureBox_newImage.Image;
            _pm.AddNewPerson(p);

            var main = this.Owner as Form1;
            if (main != null)
            {
                main.listView_persons.Items.Add(p.Name + " " + p.Surname);
            }
            main.ShowQuickNavigation();
            main.Visible = true;
            Close();
        }
    }
}
