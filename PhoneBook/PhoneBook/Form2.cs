using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using PhoneBook.Models;
using PhoneBook.UOW;

namespace PhoneBook
{
    public partial class Form2 : Form
    {
        private readonly Uow _uow;
        private readonly Person _currentPerson;

        private readonly List<NewControl> _controls = new List<NewControl>();

        public Form2(Uow uow)
        {
            _uow = uow;
            InitializeComponent();
        }

        private Image ByteToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public Form2(Uow uow, Person currentPerson)
        {
            _uow = uow;
            _currentPerson = currentPerson;
            InitializeComponent();

            textBox_name.Text = currentPerson.FirstName;
            textBox_surname.Text = currentPerson.LastName;
            richTextBox_description.Text = currentPerson.Description;
            if(currentPerson.Picture.Length!=0) pictureBox_newImage.Image = ByteToImage(currentPerson.Picture);
            var phones = _currentPerson.Phones.ToList();
            var emails = _currentPerson.Emails.ToList();
            var addresses = _currentPerson.Addresses.ToList();

            if (currentPerson.Phones.Count > 0)
            {
                comboBox_phone.Text = phones[0].DescriptionPhone;
                textBox_phone.Text = phones[0].NumberPhone;
                for (var index = 1; index < currentPerson.Phones.Count; index++)
                {
                    var phone = phones[index];
                    AddNewControls(button_addphone.Location.X, button_addphone.Location.Y, GiveElementsCombobox(comboBox_phone), "phone");
                    button_addphone.Location = new Point(button_addphone.Location.X, button_addphone.Location.Y + 60);
                    _controls[_controls.Count - 1].Key.Text = phone.DescriptionPhone;
                    _controls[_controls.Count - 1].Value.Text = phone.NumberPhone;
                }
            }
            if (currentPerson.Addresses.Count > 0)
            {
                comboBox_address.Text = addresses[0].DesctiptionAddress;
                textBox_address.Text = addresses[0].AddressA;
                for (var index = 1; index < _currentPerson.Addresses.Count; index++)
                {
                    var address = addresses[index];
                    AddNewControls(button_add_newadress.Location.X, button_add_newadress.Location.Y, GiveElementsCombobox(comboBox_address), "address");
                    button_add_newadress.Location = new Point(button_add_newadress.Location.X, button_add_newadress.Location.Y + 60);
                    _controls[_controls.Count - 1].Key.Text = address.DesctiptionAddress;
                    _controls[_controls.Count - 1].Value.Text = address.AddressA;
                }
            }
            if (currentPerson.Emails.Count <= 0) return;
            {
                comboBox_email.Text = emails[0].DescriptionEmail;
                textBox_email.Text = emails[0].EmailAddress;
                for (var index = 1; index < _currentPerson.Emails.Count; index++)
                {
                    var email = emails[index];
                    AddNewControls(button_add_newmail.Location.X, button_add_newmail.Location.Y, GiveElementsCombobox(comboBox_email), "email");
                    button_add_newmail.Location = new Point(button_add_newmail.Location.X, button_add_newmail.Location.Y + 60);
                    _controls[_controls.Count - 1].Key.Text = email.DescriptionEmail;
                    _controls[_controls.Count - 1].Value.Text = email.EmailAddress;
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

        public static byte[] GetByte(Image largeIcon)
        { 
                using (var ms = new MemoryStream())
                {
                    largeIcon.Save(ms, ImageFormat.Bmp);
                    return ms.ToArray();
                }
        }

        public  byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        
        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Trim() == "" || textBox_surname.Text.Trim() == "")
            {
                MessageBox.Show(@"Имя и фамилия!"); return;
            }
            Person p;
            if (_currentPerson != null)
            {
                p = _currentPerson;
                var email = p.Emails.ToList();
                var phones = p.Phones.ToList();
                var addresses = p.Addresses.ToList();
                for(var i=0;i<email.Count;i++) 
                {
                    _uow.Emails.Delete(email[i].IdEmail);
                }
                for (var i = 0; i < addresses.Count; i++)
                {
                    _uow.Addresses.Delete(email[i].IdEmail);
                }
                for (var i = 0; i < phones.Count; i++)
                {
                    _uow.Phones.Delete(phones[i].IdPhone);
                }
            }
            else
            {
                p = new Person();
            }

            p.FirstName = textBox_name.Text;
            p.LastName = textBox_surname.Text;
            p.Description = richTextBox_description.Text;

            if (pictureBox_newImage.Image != null) p.Picture = ImageToByte(pictureBox_newImage.Image);

            if (textBox_phone.Text.Trim() != "") p.Phones.Add(new Phone { DescriptionPhone = comboBox_phone.Text, NumberPhone = textBox_phone.Text });
            if (textBox_address.Text.Trim() != "") p.Addresses.Add(new Address { DesctiptionAddress = comboBox_address.Text, AddressA = textBox_address.Text });
            if (textBox_email.Text.Trim() != "") p.Emails.Add(new Email { DescriptionEmail = comboBox_email.Text, EmailAddress = textBox_email.Text });
            foreach (var i in _controls.Where(i => i.Value.Text.Trim() != ""))
            {
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (i.Type)
                {
                    case "phone": { p.Phones.Add(new Phone { DescriptionPhone = i.Key.Text, NumberPhone = i.Value.Text }); break; }
                    case "Address": { p.Addresses.Add(new Address { DesctiptionAddress = i.Key.Text, AddressA = i.Value.Text }); break; }
                    case "email": { p.Emails.Add(new Email { DescriptionEmail = i.Key.Text, EmailAddress = i.Value.Text }); break; }
                }
            }

            var main = Owner as Form1;

            if (main != null)
            {
                if (_currentPerson != null)
                {
                    main.listView_persons.Items.RemoveByKey(_currentPerson.IdPerson.ToString());
                    _uow.Persons.Update(p);
                    main.AddNewPerson(p);
                    _uow.Save();
                }
                else
                {
                    _uow.Persons.Create(p);
                    _uow.Save();

                    main.AddNewPerson();
                }
                main.ShowQuickNavigation();
                main.Visible = true;
            }
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var main = Owner as Form1;
            if (main != null)
            {
                main.Visible = true;
            }
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
    }
}
