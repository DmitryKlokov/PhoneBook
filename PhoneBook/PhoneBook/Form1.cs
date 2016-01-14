using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PhoneBook.Models;
using PhoneBook.UOW;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Uow _uow = new Uow();

        private void AddPersons(IEnumerable<Person> persons)
        {
            foreach (var p in persons)
            {
                if (!ImageList1.Images.ContainsKey(p.IdPerson.ToString()))
                {
                    ImageList1.Images.Add(p.IdPerson.ToString(), ByteToImage(p.Picture));
                    listView_persons.SmallImageList = ImageList1;
                }
                listView_persons.Items.Add(new ListViewItem { Text = p.FirstName + @" " + p.LastName, Name = p.IdPerson.ToString(), ImageKey = p.IdPerson.ToString() });
            }
        }

        public ImageList ImageList1 = new ImageList();

        private void Form1_Load(object sender, EventArgs e)
        {
            AddPersons(_uow.Persons.GetAll().ToList());
            ShowQuickNavigation();
        }

        public void ShowQuickNavigation()
        {
            ClearInformationAboutPerson();
            for (var i = 0; i < listView_persons.Items.Count; i++)
            {
                if (listView_persons.Items[i].Name.Contains(@"Navigation")) listView_persons.Items.RemoveAt(i);
            }
            listView_quickNavigation.Items.Clear();
            for (var i = 0; i < listView_persons.Items.Count; i++)
            {
                var s = listView_persons.Items[i].Text;
                if (listView_persons.Items[@"Navigation" + s.Substring(0, 1).ToUpper()] != null) continue;
                var li = new ListViewItem() { Name = @"Navigation" + s.Substring(0, 1).ToUpper(), Text = s.Substring(0, 1).ToUpper() };
                var li2 = new ListViewItem() { Name = @"Navigation" + s.Substring(0, 1).ToUpper(), Text = s.Substring(0, 1).ToUpper() };
                listView_persons.Items.Insert(i, li);
                listView_persons.Items[i].ForeColor = Color.DodgerBlue;
                listView_quickNavigation.Items.Add(li2);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _edit = false;
            ClearPanel();
            panel_editperson.Visible = true;
        }

        private void ClearPanel()
        {
            textBox_namePerson.Text = "";
            textBox_SurnamePerson.Text = "";
            richTextBox_desc.Text = "";
            pictureBox_edit.Image = Properties.Resources.newperson;
            dataGridView_addresses.Rows.Clear();
            dataGridView_emails.Rows.Clear();
            dataGridView_phones.Rows.Clear();
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            _edit = true;
            ClearPanel();
            _currentPerson = _uow.Persons.Get(Convert.ToInt32(listView_persons.Items[listView_persons.SelectedIndices[0]].Name));
            textBox_namePerson.Text = _currentPerson.FirstName;
            textBox_SurnamePerson.Text = _currentPerson.LastName;
            richTextBox_desc.Text = _currentPerson.Description;
            pictureBox_edit.Image = ByteToImage(_currentPerson.Picture);
            foreach (var ph in _currentPerson.Phones)
            {
                var rowNumber = dataGridView_phones.Rows.Add();
                dataGridView_phones.Rows[rowNumber].Cells[0].Value = ph.NumberPhone;
                dataGridView_phones.Rows[rowNumber].Cells[1].Value = ph.DescriptionPhone;
            }
            foreach (var em in _currentPerson.Emails)
            {
                var rowNumber = dataGridView_emails.Rows.Add();
                dataGridView_emails.Rows[rowNumber].Cells[0].Value = em.EmailAddress;
                dataGridView_emails.Rows[rowNumber].Cells[1].Value = em.DescriptionEmail;
            }
            foreach (var ad in _currentPerson.Addresses)
            {
                var rowNumber = dataGridView_addresses.Rows.Add();
                dataGridView_addresses.Rows[rowNumber].Cells[0].Value = ad.AddressA;
                dataGridView_addresses.Rows[rowNumber].Cells[1].Value = ad.DesctiptionAddress;
            }
            panel_editperson.Visible = true;
        }

        private void listView_quickNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_quickNavigation.SelectedIndices.Count <= 0) return;
            listView_quickNavigation.Visible = false;
            var index = listView_persons.Items[listView_quickNavigation.SelectedItems[0].Name].Index;
            listView_persons.EnsureVisible(listView_persons.Items.Count - 1);
            listView_persons.EnsureVisible(index);
        }

        private void listView_persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_persons.SelectedIndices.Count <= 0) return;
            if (!listView_persons.Items[listView_persons.SelectedIndices[0]].Name.Contains(@"Navigation"))
            {
                var p = _uow.Persons.Get(Convert.ToInt32(listView_persons.Items[listView_persons.SelectedIndices[0]].Name));
                ClearInformationAboutPerson();
                ShowInformationAboutPerson(p);
                button_edit.Visible = true;
                button_removePerson.Visible = true;
            }
            else
            {
                listView_quickNavigation.Visible = true;
                button_edit.Visible = false;
                button_removePerson.Visible = false;
            }
        }

        private int FindLast()
        {
            return _uow.Persons.GetAll().Select(person => person.IdPerson).Concat(new[] {0}).Max();
        }

        public void AddNewPerson()
        {
            var last = _uow.Persons.Get(FindLast());
            ImageList1.Images.Add(last.IdPerson.ToString(), ByteToImage(last.Picture));
            listView_persons.Items.Add(new ListViewItem { Text = last.FirstName + @" " + last.LastName, Name = last.IdPerson.ToString(), ImageKey = last.IdPerson.ToString() });
            
        }
        public void AddNewPerson(Person last)
        {
            ImageList1.Images.Add(last.IdPerson.ToString(), ByteToImage(last.Picture));
            listView_persons.Items.Add(new ListViewItem { Text = last.FirstName + @" " + last.LastName, Name = last.IdPerson.ToString(), ImageKey = last.IdPerson.ToString() });
        }

        private static Image ByteToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ShowInformationAboutPerson(Person p)
        {
            pictureBox_person.Image = null;
            if(p.Picture!=null) pictureBox_person.Image = ByteToImage(p.Picture);
            textBox_name.Text += p.FirstName + @" " + p.LastName;
            label_phones.Visible = p.Phones.Count > 0;
            foreach (var phone in p.Phones)
            {
                listView_phones.Items.Add(new ListViewItem(new[] {phone.NumberPhone,phone.DescriptionPhone}));
            }
            label_Addresses.Visible = p.Addresses.Count > 0;
            foreach (var address in p.Addresses)
            {
                listView_addresses.Items.Add(new ListViewItem(new[] { address.AddressA, address.DesctiptionAddress}));
            }
            label_Mails.Visible = p.Emails.Count > 0;
            foreach (var email in p.Emails)
            {
                listView_mails.Items.Add(new ListViewItem(new[] { email.EmailAddress, email.DescriptionEmail}));
            }
            label_description.Visible = p.Description != "";
            richTextBox_person.Text += p.Description;
        }

        private void button_removePerson_Click(object sender, EventArgs e)
        {
            _uow.Persons.Delete(Convert.ToInt32(listView_persons.Items[listView_persons.SelectedIndices[0]].Name));
            _uow.Save();
            listView_persons.Items.RemoveByKey(listView_persons.Items[listView_persons.SelectedIndices[0]].Name);
            listView_quickNavigation.Items.Clear();
            ShowQuickNavigation();
        }

        private void ClearInformationAboutPerson()
        {
            richTextBox_person.Text = "";
            pictureBox_person.Image = null;
            textBox_name.Text = "";
            listView_addresses.Items.Clear();
            listView_mails.Items.Clear();
            listView_phones.Items.Clear();
        }

        private bool Find(Person person)
        {
            if (person.FirstName.Contains(textBox_find.Text)) return true;
            if (person.LastName.Contains(textBox_find.Text)) return true;
            if (person.Patronymic!=null && person.Patronymic.Contains(textBox_find.Text)) return true;
            if (person.Description.Contains(textBox_find.Text)) return true;
            if (person.Phones.Any(phone => phone.NumberPhone.Contains(textBox_find.Text)))
            {
                return true;
            }
            if (person.Addresses.Any(address => address.AddressA.Contains(textBox_find.Text)))
            {
                return true;
            }
            if (person.Emails.Any(email => email.EmailAddress.Contains(textBox_find.Text)))
            {
                return true;
            }
            return false;
        }

        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            var all = _uow.Persons.GetAll();
            var abc = all.Where(Find).ToList();
            listView_persons.Items.Clear();
            listView_quickNavigation.Items.Clear();
            AddPersons(abc);
            ShowQuickNavigation();
        }

        public static byte[] GetByte(Image largeIcon)
        {
            using (var ms = new MemoryStream())
            {
                largeIcon.Save(ms, ImageFormat.Bmp);
                return ms.ToArray();
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private bool _edit;
        private Person _currentPerson;


        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_namePerson.Text.Trim() == "" || textBox_SurnamePerson.Text.Trim() == "")
            {
                MessageBox.Show(@"Имя и фамилия!"); return;
            }
            Person p;
            if (_edit)
            {
                p = _currentPerson;
                var emails = p.Emails.ToList();
                var phones = p.Phones.ToList();
                var addresses = p.Addresses.ToList();
                for (var i = 0; i < emails.Count; i++)
                {
                    _uow.Emails.Delete(emails[i].IdEmail);
                }
                for (var i = 0; i < addresses.Count; i++)
                {
                    _uow.Addresses.Delete(addresses[i].IdAddress);
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

            p.FirstName = textBox_namePerson.Text;
            p.LastName = textBox_SurnamePerson.Text;
            p.Description = richTextBox_desc.Text;

            if (pictureBox_edit.Image != null) p.Picture = ImageToByte(pictureBox_edit.Image);

            for(var i=0;i< dataGridView_phones.Rows.Count-1;i++)
            { 
                p.Phones.Add(new Phone
                {
                    DescriptionPhone = dataGridView_phones.Rows[i].Cells[1].Value.ToString(),
                    NumberPhone = dataGridView_phones.Rows[i].Cells[0].Value.ToString()
                });
            }
            for (var i = 0; i < dataGridView_addresses.Rows.Count - 1; i++)
            {
                p.Addresses.Add(new Address
                {
                    DesctiptionAddress = dataGridView_addresses.Rows[i].Cells[1].Value.ToString(),
                    AddressA = dataGridView_addresses.Rows[i].Cells[0].Value.ToString()
                });
            }
            for (var i = 0; i < dataGridView_emails.Rows.Count - 1; i++)
            {
                p.Emails.Add(new Email
                {
                    DescriptionEmail = dataGridView_emails.Rows[i].Cells[1].Value.ToString(),
                    EmailAddress = dataGridView_emails.Rows[i].Cells[0].Value.ToString()
                });
            }
            if (_edit)
            {
                listView_persons.Items.RemoveByKey(_currentPerson.IdPerson.ToString());
                _uow.Persons.Update(p);
                AddNewPerson(p);
                _uow.Save();
            }
            else
            {
                _uow.Persons.Create(p);
                _uow.Save();
                AddNewPerson();
            }
            ShowQuickNavigation();
            panel_editperson.Visible = false;
        }

        private void pictureBox_edit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                var myImage = new Bitmap(openFileDialog1.FileName);
                pictureBox_edit.Image = myImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            panel_editperson.Visible = false;
        }
    }
}
