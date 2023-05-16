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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_HW_Module_4
{
    public partial class Form1 : Form
    {

        private string placeHolderName = "Введите имя";
        private string placeHolderSurname = "Введите фамилию";
        private string placeHolderFatherName = "Введите отчество";
        private string placeHolderOtherInfo = "Введите дополниптельную информацию";
        HumanBase humanBase = new HumanBase();
        Human humanTemp = new Human();
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 720;
            this.Height = 480;
            if (humanBase.humans.Count == 0)
            {
                humanBase.AddHuman(new Human
                {
                    Name = "Сергей",
                    FatherName = "Михайлович",
                    maritalStatus = MaritalStatus.Холост,
                    sex = Sex.male,
                    Surname = "Матвейчук",
                    OtherInfo = "Карлсон, который живет на крыше, подрался с бездомным, который хотел жить там же.",
                    BirthDate = new DateTime(1994, 5, 15)
                });

                humanBase.AddHuman(new Human
                {
                    Name = "Пал",
                    FatherName = "Палыч",
                    maritalStatus = MaritalStatus.женат,
                    sex = Sex.male,
                    Surname = "Пилипенко",
                    OtherInfo = "– Фима, я шубу хочу!– Софа, ты ж оливье еще не доела!",
                    BirthDate = new DateTime(1987, 2, 19)
                });

            }


            foreach (var item in humanBase.humans) 
            { 
                listBox_humans.Items.Add(item.Name+" "+item.Surname);
            }
            comboBox2.DataSource = Enum.GetValues(typeof(Sex));
            comboBox1.DataSource = Enum.GetValues(typeof(MaritalStatus));
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = placeHolderName;
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = placeHolderSurname;
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = placeHolderFatherName;
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = placeHolderOtherInfo;

        }





        private void listBox_humans_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1_Info.Text = humanBase.humans[listBox_humans.SelectedIndex].ToString();
            button4.Enabled = true;

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            humanBase.humans.RemoveAt(listBox_humans.SelectedIndex);
            label1_Info.Text = "";
            listBox_humans.Items.Clear();
            foreach (var item in humanBase.humans)
            {
                listBox_humans.Items.Add(item.Name + " " + item.Surname);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != placeHolderName) humanTemp.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != placeHolderSurname)
                humanTemp.Surname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != placeHolderFatherName)
                humanTemp.FatherName = textBox3.Text;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != placeHolderOtherInfo) humanTemp.OtherInfo = textBox4.Text;
        }
      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) => humanTemp.sex = (Sex)comboBox2.SelectedItem;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => humanTemp.BirthDate = dateTimePicker1.Value;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => humanTemp.maritalStatus = (MaritalStatus)comboBox1.SelectedItem;

        private void button1_Click(object sender, EventArgs e)
        {
            humanBase.humans.Add(humanTemp);
            humanTemp = new Human();
            label1_Info.Text = "";
            listBox_humans.Items.Clear();
            foreach (var item in humanBase.humans)
            {
                listBox_humans.Items.Add(item.Name + " " + item.Surname);
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            f2 = new Form2(humanBase.humans[listBox_humans.SelectedIndex]);
            f2.Show();
            humanBase.humans[listBox_humans.SelectedIndex] = f2.HumanSave();
            label1_Info.Text = "";
            listBox_humans.Items.Clear();
            foreach (var item in humanBase.humans)
            {
                listBox_humans.Items.Add(item.Name + " " + item.Surname);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = placeHolderName;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeHolderName)
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = placeHolderSurname;
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == placeHolderSurname)
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == placeHolderFatherName)
            {
                textBox3.Text = string.Empty;
                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.ForeColor = Color.Gray;
                textBox4.Text = placeHolderOtherInfo;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == placeHolderOtherInfo)
            {
                textBox4.Text = string.Empty;
                textBox4.ForeColor = Color.Black;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            saver.SaveToFile(humanBase, "FILE HUMANS!.xml");
            MessageBox.Show("File saved to FILE HUMANS!.xml");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            humanBase =  saver.DownloadFromFile("FILE HUMANS!.xml");
            

            label1_Info.Text = "";
            listBox_humans.Items.Clear();
            foreach (var item in humanBase.humans)
            {
                listBox_humans.Items.Add(item.Name + " " + item.Surname);
            }
        }
    }




    [Serializable]
    public enum MaritalStatus
    {
        Холост,
        женат,
        разведен,
        вдовец,
        вечный_ребёнок

    }
    [Serializable]
    public enum Sex
    {
        male,
        female
    }
    [Serializable]
    public class HumanBase
    {
        Human human;
        public List<Human> humans = new List<Human>();

        public HumanBase(Human human)
        {
            if (humans.Count == 0) { humans = new List<Human>(); }
            this.human = human;
        }
        public HumanBase()
        {

        }
        public HumanBase(List<Human> humans)
        {
            this.humans = humans;
        }

        public void CreateHuman() => human = new Human();
        public void AddHuman(Human human) => humans.Add(human);

    }
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public Sex sex { get; set; }
        public DateTime BirthDate { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public string OtherInfo { get; set; }

        public Human()
        {
            BirthDate = DateTime.Now;
        }
        public override string ToString()
        {
            return "Имя : "+Name + "\n" + "Фамилия : " + Surname + "\n" + "Отчество : " 
                + FatherName + "\n" + "Пол : " + sex + "\n" + "Доп. Информация : " + OtherInfo+ "\n"+ 
                "Семейное положение : " + maritalStatus + "\n" + "Дата рождения : " + BirthDate.ToShortDateString();
        }

        
    }
    public class Saver
    {
        public void SaveToFile(HumanBase obj, string path)
        {

            FileStream stream = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Human>));
            xmlSerializer.Serialize(stream, obj.humans);
            MessageBox.Show("Saving was OK");
            stream.Close();
        }
        public HumanBase DownloadFromFile( string path)
        {

            FileStream stream = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Human>));
            HumanBase obj = new HumanBase((List<Human>)xmlSerializer.Deserialize(stream));
            MessageBox.Show("Downloading  was OK");
            stream.Close();
            return obj;
        }


    }
}
