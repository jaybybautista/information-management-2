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
    public partial class Form2 : Form
    {
        string mp;
        string fn;
        string ln;
        string stat;
        string sx;
        DateTime dt;
        string loc;
        PictureBox pic;
        public Form2(string mobilePhone, string firstName, string lastName, string status, string sex, DateTime dateTime, string location, PictureBox pictureBox)
        {
            InitializeComponent();
            mp = mobilePhone;
            fn = firstName;
            ln = lastName;
            stat = status;
            sx = sex;
            dt = dateTime;
            loc = location;
            pic = pictureBox;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = mp;
            textBox2.Text = fn;
            textBox3.Text = ln;
            comboBox1.Text = stat;
            dateTimePicker1.Value = dt;
            textBox4.Text = loc;
            pictureBox1.Image = pic.Image;

            if (sx == "Male")
                radioButton1.Checked = true;
            else if (sx == "Female")
                radioButton2.Checked = true;
        }
    }
}
