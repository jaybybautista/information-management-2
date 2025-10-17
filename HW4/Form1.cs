using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mobilePhone1 = maskedTextBox1.Text;
            string firstName1 = textBox2.Text;
            string lastName1 = textBox3.Text;
            string status1 = comboBox1.Text;
            string sex1 = "";
            DateTime dateTime1 = dateTimePicker1.Value;
            string location1 = textBox4.Text;
            PictureBox pictureBox = pictureBox1;

            if (radioButton1.Checked)
                sex1 = radioButton1.Text;
            else if (radioButton2.Checked)
                sex1 = radioButton2.Text;

            Form2 frm2 = new Form2(mobilePhone: mobilePhone1, firstName: firstName1, lastName: lastName1, status: status1, sex: sex1, dateTime: dateTime1, location: location1, pictureBox: pictureBox);
            frm2.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Open an Image File";

            dialog.Filter = "Image Files | *.jpg; *.jpeg; *.png";

            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
