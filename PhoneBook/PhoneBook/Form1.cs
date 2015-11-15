using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private readonly PersonsManager _pm = new PersonsManager();


        private void Form1_Load(object sender, EventArgs e)
        {
            Deserialize();
            foreach (var p in _pm.GetPersons())
            {
                listView_persons.Items.Add(p.Name+" "+p.Surname, p.Name + " " + p.Surname);
            }
            ShowQuickNavigation();
        }
        private readonly List<string> _quickNavigation = new List<string>();
        public void ShowQuickNavigation()
        {
            for(var i=0;i<listView_persons.Items.Count;i++)
            {
                var s = listView_persons.Items[i].Text;
                if (_quickNavigation.Contains(s.Substring(0, 1).ToUpper())) return;
                var li = new ListViewItem(Text = s.Substring(0, 1).ToUpper());
                li.Name = s.Substring(0, 1).ToUpper();
                listView_persons.Items.Insert(i, li);
                listView_persons.Items[i].BackColor = Color.Beige;
                _quickNavigation.Add(s.Substring(0, 1).ToUpper());
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var f = new Form2(_pm);
            Visible = false;
            f.Owner = this;
            f.Show();
        }

        

        private void listView_persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_persons.SelectedIndices.Count <= 0) return;
            richTextBox_person.Text = "";
            pictureBox_person.Image = null;
            var p = _pm.GetPerson(listView_persons.Items[listView_persons.SelectedIndices[0]].Text);
            if (p.Name!=null)
            {
                 richTextBox_person.Text += p.ToString();
                 pictureBox_person.SizeMode = PictureBoxSizeMode.StretchImage;
                 pictureBox_person.Image = p.LargeIcon;
            }
            else
            {
                listView_navigation.Visible = true;
                listView_navigation.Items.Clear();
                foreach (var s in _quickNavigation)
                {
                    listView_navigation.Items.Add( s , s);
                }
            }
        }
    
        
        private void Serialize()
        {
            FileStream fs = new FileStream("crc.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            serializer.Serialize(fs, _pm.GetPersons());
            fs.Close();
        }

        private void Deserialize()
        {
            FileStream fs = new FileStream("crc.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            _pm.SetPersons((List<Person>)serializer.Deserialize(fs));
            fs.Close();
        }

        private void button_prop_Click(object sender, EventArgs e)
        {
            //Serialize();
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

       
    }
}
