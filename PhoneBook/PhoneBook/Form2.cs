using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form2 : Form
    {
        private readonly PersonsManager _pm;
        private readonly Person _currentPerson;
        private readonly List<NewControl> _controls = new List<NewControl>();

        

        public Form2(PersonsManager pm)
        {
            _pm = pm;
            InitializeComponent();
            pictureBox_newImage.SizeMode = PictureBoxSizeMode.StretchImage;
            var myImage = new Bitmap("newperson.png");
            pictureBox_newImage.Image = myImage;
        }

        public Form2(PersonsManager pm, Person currentPerson)
        {
            _pm = pm;
            _currentPerson = currentPerson;
            InitializeComponent();

            textBox_name.Text = currentPerson.Name;
            textBox_surname.Text = currentPerson.Surname;
            richTextBox_description.Text = currentPerson.Description;
            pictureBox_newImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_newImage.Image = currentPerson.LargeIcon;
            if (currentPerson.Phones.Count > 0)
            {
                comboBox_phone.Text = currentPerson.Phones[0].Name;
                textBox_phone.Text = currentPerson.Phones[0].Value;
                for (var index = 1; index < currentPerson.Phones.Count; index++)
                {
                    var phone = currentPerson.Phones[index];
                    AddNewControls(button_addphone.Location.X, button_addphone.Location.Y,GiveElementsCombobox(comboBox_phone), "phone");
                    button_addphone.Location = new Point(button_addphone.Location.X, button_addphone.Location.Y + 60);
                    _controls[_controls.Count - 1].Key.Text = phone.Name;
                    _controls[_controls.Count - 1].Value.Text = phone.Value;
                }
            }
            if (currentPerson.Addresses.Count > 0)
            {
                comboBox_address.Text = currentPerson.Addresses[0].Name;
                textBox_address.Text = currentPerson.Addresses[0].Value;
                for (var index = 1; index < _currentPerson.Addresses.Count; index++)
                {
                    var address = _currentPerson.Addresses[index];
                    AddNewControls(button_add_newadress.Location.X, button_add_newadress.Location.Y,GiveElementsCombobox(comboBox_address), "address");
                    button_add_newadress.Location = new Point(button_add_newadress.Location.X,button_add_newadress.Location.Y + 60);
                    _controls[_controls.Count - 1].Key.Text = address.Name;
                    _controls[_controls.Count - 1].Value.Text = address.Value;
                }
            }
            if (currentPerson.Emails.Count <= 0) return;
            {
                comboBox_email.Text = currentPerson.Emails[0].Name;
                textBox_email.Text = currentPerson.Emails[0].Value;
                for (var index = 1; index < _currentPerson.Emails.Count; index++)
                {
                    var email = _currentPerson.Emails[index];
                    AddNewControls(button_add_newmail.Location.X, button_add_newmail.Location.Y,GiveElementsCombobox(comboBox_email), "email");
                    button_add_newmail.Location = new Point(button_add_newmail.Location.X,button_add_newmail.Location.Y + 60);
                    _controls[_controls.Count - 1].Key.Text = email.Name;
                    _controls[_controls.Count - 1].Value.Text = email.Value;
                }
            }
        }


        private static string[] GiveElementsCombobox(ComboBox combobox)
        {
            return (from object i in combobox.Items select i.ToString()).ToArray();
        }

        private void AddNewControls(int x, int y, string[] items, string name)
        {
            var cb = new ComboBox() { Location = new Point(x, y), Width = 190, Height = 20, Name = "comboBox_" + name, Text = items[0] };
            cb.Items.AddRange(items);
            panel1.Controls.Add(cb);
            var b = new TextBox()
            {
                Location = new Point(x, y + 20),
                Width = 190,
                Height = 20,
                Name = "textBox_" + name
            };
            panel1.Controls.Add(b);
            _controls.Add(new NewControl(name, cb, b));
        }

        private void pictureBox_newImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
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
            AddNewControls(button_addphone.Location.X, button_addphone.Location.Y, GiveElementsCombobox(comboBox_phone), "phone");
            button_addphone.Location = new Point(button_addphone.Location.X, button_addphone.Location.Y + 60);
        }

        private void button_add_newmail_Click(object sender, EventArgs e)
        {
            AddNewControls(button_add_newmail.Location.X, button_add_newmail.Location.Y, GiveElementsCombobox(comboBox_email), "email");
            button_add_newmail.Location = new Point(button_add_newmail.Location.X, button_add_newmail.Location.Y + 60);
        }

        private void button_add_newadress_Click(object sender, EventArgs e)
        {
            AddNewControls(button_add_newadress.Location.X, button_add_newadress.Location.Y, GiveElementsCombobox(comboBox_address), "address");
            button_add_newadress.Location = new Point(button_add_newadress.Location.X, button_add_newadress.Location.Y + 60);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Trim() == "" || textBox_surname.Text.Trim() == "")
            {
                MessageBox.Show(@"Имя и фамилия!"); return;
            }
            var p = new Person
            {
                Name = textBox_name.Text.Trim(),
                Surname = textBox_surname.Text.Trim()
            };

            if(textBox_phone.Text.Trim()!="") p.Phones.Add(new Field(comboBox_phone.Text, textBox_phone.Text));
            if(textBox_address.Text.Trim()!="") p.Addresses.Add(new Field(comboBox_address.Text, textBox_address.Text));
            if(textBox_email.Text.Trim()!="") p.Emails.Add(new Field(comboBox_email.Text, textBox_email.Text));
            foreach (var i in _controls.Where(i => i.Value.Text.Trim() != ""))
            {
                switch (i.Type)
                {
                    case "phone":{ p.Phones.Add(new Field(i.Key.Text, i.Value.Text)); break; }
                    case "email": { p.Emails.Add(new Field(i.Key.Text, i.Value.Text)); break; }
                    default: { p.Addresses.Add(new Field(i.Key.Text, i.Value.Text)); break; }//address
                }
            }
            p.Description = richTextBox_description.Text;
            p.LargeIcon = (Bitmap)pictureBox_newImage.Image;
            
            
            var main = Owner as Form1;

            if (_pm.Exists(p)) {  Close(); main.Visible = true; MessageBox.Show(@"Запись уже создана"); return;  }
            if (main != null)
            {
                if (_currentPerson != null)
                {
                    _pm.RemovePerson(_currentPerson);
                    main.listView_persons.Items.RemoveByKey(_currentPerson.Id);
                    main.ImageList1.Images.RemoveByKey(p.Id);
                    main.listView_persons.SmallImageList = main.ImageList1;
                }
            }
            main.ImageList1.Images.Add(p.Id, p.LargeIcon); 
            main.listView_persons.Items.Add(new ListViewItem { Text = p.Name + @" " + p.Surname, Name = p.Id, ImageKey = p.Id});
            main.ShowQuickNavigation();
            main.Visible = true;

            _pm.AddNewPerson(p);

            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            var main = Owner as Form1;
            if (main != null)
            {
                main.Visible = true;
            }
        }
    }
}
