using FormUI.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            int id =  int.Parse(tbID.Text);
            string fname = tbFN.Text;
            string lname = tbLN.Text;
            string phone = tbPhoneNumber.Text;

            PersonProcessor.CreatePerson(id, fname, lname, email, phone);
            resetForm();
        }

        private void resetForm()
        {
            tbEmail.Text = "";
            tbID.Text = "";
            tbFN.Text = "";
            tbLN.Text = "";
            tbPhoneNumber.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var personId = textBox1.Text;
            var personData = PersonProcessor.LoadPerson(int.Parse(personId));
            foreach(var row in personData)
            {
                listBox1.Items.Add(
                    row.FirstName);
                listBox1.Items.Add(
                    row.LastName);
                listBox1.Items.Add(
                    row.Id);
                listBox1.Items.Add(
                    row.PhoneNumber);
                listBox1.Items.Add(
                    row.EmailAddress);

            }
            
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
