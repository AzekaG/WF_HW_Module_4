using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW_Module_4
{
    public partial class Form2 : Form
    {
        private string placeHolderName = "Введите имя";
        private string placeHolderSurname = "Введите фамилию";
        private string placeHolderFatherName = "Введите отчество";
        private string placeHolderOtherInfo = "Введите дополниптельную информацию";
        public Human humanTemp;
        public Form2(Human human)
        {
            InitializeComponent();
            humanTemp = human;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = placeHolderName;
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = placeHolderSurname;
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = placeHolderFatherName;
            textBox5.ForeColor = Color.Gray;
            textBox5.Text = placeHolderOtherInfo;
            comboBox1.DataSource = Enum.GetValues(typeof(Sex));
            comboBox2.DataSource = Enum.GetValues(typeof(MaritalStatus));
            


        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == placeHolderName)
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;

            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = placeHolderName;
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == placeHolderSurname)
            {
                textBox3.Text = string.Empty;
                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.ForeColor = Color.Gray;
                textBox3.Text = placeHolderSurname;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == placeHolderFatherName)
            {
                textBox4.Text = string.Empty;
                textBox4.ForeColor = Color.Black;

            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.ForeColor = Color.Gray;
                textBox4.Text = placeHolderFatherName;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == placeHolderOtherInfo)
            {
                textBox5.Text = string.Empty;
                textBox5.ForeColor = Color.Black;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.ForeColor = Color.Gray;
                textBox5.Text = placeHolderOtherInfo;
            }
        }

        public void button1_SaveHuman(object sender, EventArgs e)
        {
            HumanSave();
            this.Close();

        }
        public Human HumanSave()
        {
            return humanTemp;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!=placeHolderName)
            humanTemp.Name = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text != placeHolderSurname)
            humanTemp.Surname = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text!=placeHolderFatherName)
            humanTemp.FatherName = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text!=placeHolderOtherInfo)
            humanTemp.OtherInfo = textBox5.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            humanTemp.sex = (Sex)comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            humanTemp.maritalStatus = (MaritalStatus)comboBox2.SelectedIndex;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            humanTemp.BirthDate = dateTimePicker1.Value;
        }


    }
}
