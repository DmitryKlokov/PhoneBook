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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> persons = new List<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 84; i++)
                listView_persons.Items.Add("sdsdd");


            listView_persons.Items[43].Selected = true;
            listView_persons.EnsureVisible(listView_persons.Items.Count-1);
            listView_persons.EnsureVisible(43);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel_newPerson.Visible = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            panel_newPerson.Visible = false;
        }
    }
}
