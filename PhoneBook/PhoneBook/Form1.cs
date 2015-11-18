using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly PersonsManager _pm = new PersonsManager();
        private Person _currentPerson = new Person();

        public ImageList ImageList1 = new ImageList();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var p in _pm.GetPersons())
            {
                if (!ImageList1.Images.ContainsKey(p.Id))
                {
                    ImageList1.Images.Add(p.Id, p.LargeIcon);
                    listView_persons.SmallImageList = ImageList1;
                }
                listView_persons.Items.Add(new ListViewItem { Text = p.Name + @" " + p.Surname, Name = p.Id ,ImageKey = p.Id});
            }
            ShowQuickNavigation();
        }
        

        public void ShowQuickNavigation()
        {
            for (var i = 0; i < listView_persons.Items.Count; i++)
            {
                if(listView_persons.Items[i].Name.Contains(@"Navigation")) listView_persons.Items.RemoveAt(i);
            }
            listView_quickNavigation.Items.Clear();
            for (var i=0; i < listView_persons.Items.Count; i++)
            {
                var s = listView_persons.Items[i].Text;
                if (listView_persons.Items[@"Navigation" + s.Substring(0, 1).ToUpper()] != null) continue;
                var li = new ListViewItem() {Name = @"Navigation"+ s.Substring(0, 1).ToUpper(),Text = s.Substring(0, 1).ToUpper() };
                var li2 = new ListViewItem() { Name = @"Navigation" + s.Substring(0, 1).ToUpper(), Text = s.Substring(0, 1).ToUpper() };
                listView_persons.Items.Insert(i, li);
                listView_persons.Items[i].ForeColor = Color.DodgerBlue;
                listView_quickNavigation.Items.Add(li2);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var f = new Form2(_pm);
            Visible = false;
            f.Owner = this;
            f.Show();
        }

        public void ShowPerson(Person p)
        {
            richTextBox_person.Text += p.ToString();
            pictureBox_person.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_person.Image = p.LargeIcon;
            button_edit.Visible = true;
            button_removePerson.Visible = true;
            _currentPerson = p;
            var allIp = Regex.Matches(richTextBox_person.Text, textBox_find.Text);
            foreach (Match ip in allIp)
            {
                richTextBox_person.SelectionStart = ip.Index;
                richTextBox_person.SelectionLength = ip.Length;
                richTextBox_person.SelectionBackColor = Color.FromArgb(255, 160, 122);
            }
        }
        

        private void ClearPerson()
        {
            richTextBox_person.Text = "";
            pictureBox_person.Image = null;
        }
        
        private void button_edit_Click(object sender, EventArgs e)
        {
            var f = new Form2(_pm,_currentPerson);
            Visible = false;
            f.Owner = this;
            ClearPerson();
            f.Show();
        }
        
        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            if (textBox_find.Text.Trim() == "") return;
            listView_persons.Items.Clear();
            foreach (var p in _pm.GetPersons().Where(p=>p.Id.ToString().Contains(textBox_find.Text)))
            {
                listView_persons.Items.Add(new ListViewItem { Text = p.Name + @" " + p.Surname, Name = p.Id,ImageKey = p.Id});
                ShowQuickNavigation();
            }
        }

        private void button_removePerson_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure?", @"Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            listView_persons.Items[_currentPerson.Id].Remove();
            _pm.RemovePerson(_currentPerson);
            ShowQuickNavigation();
            ClearPerson();
        }

        private void listView_persons_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView_persons.SelectedIndices.Count <= 0) return;
            ClearPerson();
            var p = _pm.GetPerson(listView_persons.Items[listView_persons.SelectedIndices[0]].Text);
            if (p.Name != null)
            {
                ShowPerson(p);
            }
            else
            {
                listView_quickNavigation.Visible = true;
                button_edit.Visible = false;
                button_removePerson.Visible = false;
            }
        }

        private void listView_quickNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_quickNavigation.SelectedIndices.Count <= 0) return;
            listView_quickNavigation.Visible = false;
            var index = listView_persons.Items[listView_quickNavigation.SelectedItems[0].Name].Index;
            listView_persons.EnsureVisible(listView_persons.Items.Count - 1);
            listView_persons.EnsureVisible(index);
        }
    }
}
