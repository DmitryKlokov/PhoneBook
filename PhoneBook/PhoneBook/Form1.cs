using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> persons = new List<Person>();
        List<NewControl> phones = new List<NewControl>(); 


        private void Form1_Load(object sender, EventArgs e)
        {
            Deserialize();
            foreach (var p in persons)
            {
                listView_persons.Items.Add(p.Name+" "+p.Surname, p.Name + " " + p.Surname);
            }
            listview();
        }
        List<string> bukvi = new List<string>();
        void listview()
        {
            for(int i=0;i<listView_persons.Items.Count;i++)
            {
                string s = listView_persons.Items[i].Text;
                if (!bukvi.Contains(s.Substring(0, 1).ToUpper()))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = s.Substring(0, 1).ToUpper();
                    li.Name = s.Substring(0, 1).ToUpper();
                    listView_persons.Items.Insert(i, li);
                    listView_persons.Items[i].BackColor = Color.Beige;
                    bukvi.Add(s.Substring(0, 1).ToUpper());
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel_newPerson.Visible = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "" && textBox_surname.Text != "" && textBox_phone.Text != "")
            {
                Person p = new Person();
                p.Name = textBox_name.Text;
                p.Surname = textBox_surname.Text;

                if(textBox_phone.Text!="") p.Numbers.Add(new PhoneNumber(comboBox_phone.Text, long.Parse(textBox_phone.Text)));
                foreach (NewControl nc in phones.FindAll(c=>c.type=="phone"))
                {
                    if(nc.value.Text!="") p.Numbers.Add(new PhoneNumber(nc.key.Text, long.Parse(nc.value.Text)));
                }

                if (textBox_email.Text != "") p.Emails.Add(new Email(comboBox_email.Text, textBox_email.Text));
                foreach (NewControl nc in phones.FindAll(c => c.type == "email"))
                {
                    if (nc.value.Text != "") p.Emails.Add(new Email(nc.key.Text, nc.value.Text));
                }
                if (textBox_address.Text != "") p.Addresses.Add(new Address(comboBox_address.Text, textBox_address.Text));
                foreach (NewControl nc in phones.FindAll(c => c.type == "address"))
                {
                    if (nc.value.Text != "") p.Addresses.Add(new Address(nc.key.Text, nc.value.Text));
                }
                p.Description = richTextBox_description.Text;
                if (pictureBox_newImage.Image != null) p.LargeIcon = (Bitmap)pictureBox_newImage.Image;
                persons.Add(p);
                persons.Sort();
                listView_persons.Items.Add(p.Name + " " + p.Surname);
                vsenazad();
                listview();
            }
        }

        private void listView_persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_persons.SelectedIndices.Count > 0)
            {
                richTextBox_person.Text = "";
                pictureBox_person.Image = null;
                int index =
                    persons.FindIndex(
                        (per) =>
                            per.Name + " " + per.Surname ==
                            listView_persons.Items[listView_persons.SelectedIndices[0]].Text);
                if (index >= 0)
                {
                    richTextBox_person.Text += persons[index].ToString();
                    pictureBox_person.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_person.Image = persons[index].LargeIcon;
                }
                else
                {
                    listView_navigation.Visible = true;
                    listView_navigation.Items.Clear();
                    foreach (string s in bukvi)
                    {
                        listView_navigation.Items.Add(s, s);
                    }
                }
        }
    }
        
        private void Serialize()
        {
            FileStream fs = new FileStream("crc.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            serializer.Serialize(fs, persons);
            fs.Close();
        }

        private void Deserialize()
        {
            FileStream fs = new FileStream("crc.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            persons = (List<Person>)serializer.Deserialize(fs);
            fs.Close();
        }

        private void button_prop_Click(object sender, EventArgs e)
        {
            Serialize();
        }

        void addNewControls(int x, int y, string[] items,string name)
        {
            var cb = new ComboBox() { Location = new Point(x, y), Width = 190, Height = 20,Name = "comboBox_"+name,Text = items[0]};
            cb.Items.AddRange(items);
            panel_newPerson.Controls.Add(cb);
            var b = new TextBox()
            {
                Location = new Point(x, y + 20),
                Width = 190,
                Height = 20,
                Name = "textBox_"+name
            };
            panel_newPerson.Controls.Add(b);
            if(y+80> button_save.Location.Y) button_save.Location = new Point(button_save.Location.X, button_save.Location.Y + 60);
            phones.Add(new NewControl(name,cb,b) );
        }

        string[] give_elementscombobox(ComboBox c)
        {
            List<string> s = new List<string>();
            foreach (var i in c.Items)
            {
               s.Add(i.ToString());
            }
            return s.ToArray();
        }

        private void button_addphone_Click(object sender, EventArgs e)
        {
            addNewControls(button_addphone.Location.X, button_addphone.Location.Y, give_elementscombobox(comboBox_phone),"phone");
            button_addphone.Location = new Point(button_addphone.Location.X, button_addphone.Location.Y+60);
        }

        private void button_add_newmail_Click(object sender, EventArgs e)
        {
            addNewControls(button_add_newmail.Location.X, button_add_newmail.Location.Y, give_elementscombobox(comboBox_email), "email");
            button_add_newmail.Location = new Point(button_add_newmail.Location.X, button_add_newmail.Location.Y + 60);
        }

        private void button_add_newadress_Click(object sender, EventArgs e)
        {
            addNewControls(button_add_newadress.Location.X, button_add_newadress.Location.Y, give_elementscombobox(comboBox_address), "address");
            button_add_newadress.Location = new Point(button_add_newadress.Location.X, button_add_newadress.Location.Y + 60);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            vsenazad();
        }
        public void vsenazad()
        {
            for(int i=0;i< phones.Count;i++)
            {
                panel_newPerson.Controls.Remove((ComboBox)phones[i].key);
                panel_newPerson.Controls.Remove((TextBox)phones[i].value);
                phones.Remove(phones[i]);
            }
            panel_newPerson.Visible = false;
            button_addphone.Location = new Point(textBox_phone.Location.X, textBox_phone.Location.Y + 36);
            button_add_newmail.Location = new Point(textBox_email.Location.X, textBox_email.Location.Y + 36);
            button_add_newadress.Location = new Point(textBox_address.Location.X, textBox_address.Location.Y + 36);
            button_save.Location = new Point(button_save.Location.X, button_add_newadress.Location.Y + 105);
            textBox_phone.Text = "";
            textBox_address.Text = "";
            textBox_email.Text = "";
            textBox_name.Text = "";
            textBox_surname.Text = "";
            richTextBox_description.Text = "";
        }

        private void listView_navigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_navigation.SelectedIndices.Count > 0)
            {
                listView_navigation.Visible = false;
                int index = listView_persons.Items[listView_navigation.Items[listView_navigation.SelectedIndices[0]].Text].Index;
                listView_persons.Items[index].Selected = true;
                listView_persons.EnsureVisible(listView_persons.Items.Count - 1);
                listView_persons.EnsureVisible(index);
            }
        }

        private void pictureBox_newImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox_newImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    Bitmap MyImage = new Bitmap(openFileDialog1.FileName);
                    pictureBox_newImage.Image = MyImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
