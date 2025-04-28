using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAppOpgave
{
    public partial class Form1 : Form
    {
        public List<Person> personList = new List<Person>();

        private BindingSource bindingSource1 = new BindingSource();
       

        public Form1()
        {
            //initializeDataGridView();
            InitializeComponent();
            personList = new List<Person>();
            {
                personList.Add(new Person("Hans", "Hansen", 25));
                personList.Add(new Person("Peter", "Petersen", 30));
                personList.Add(new Person("Jens", "Jensen", 35));
            }
            bindingSource1.DataSource = personList;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Update();
        }


        public void fornavnTextBox_TextChanged(object sender, EventArgs e)
        {
            string fornavn = fornavnTextBox.Text;
        }

        public void efternavnTextBox_TextChanged(object sender, EventArgs e)
        {
            string efternavn = efternavnTextBox.Text;
        }

        public void alderTextBox_TextChanged(object sender, EventArgs e)
        {
            int alder = Convert.ToInt32(alderTextBox.Text);
        }

        private void addPersonBotten_Click(object sender, EventArgs e)
        {
            bindingSource1.Add(new Person(fornavnTextBox.Text, efternavnTextBox.Text, Convert.ToInt32(alderTextBox.Text)));
        }
    }
}