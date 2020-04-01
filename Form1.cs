using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> RusWords = new Dictionary<string, string>();
        Dictionary<string, string> EngWords = new Dictionary<string, string>();
        Dictionary<string, string> UcrWords = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            RusWords.Add("Профи", "Профи");
            RusWords.Add("Новичок", "Новичок");
            RusWords.Add("Любитель", "Любитель");
            RusWords.Add("Выберите язык", "Выберите язык");
            RusWords.Add("выберите сложность", "выберите сложность");
            EngWords.Add("Новичок", "Newbie");
            EngWords.Add("Любитель", "Amateur");
            EngWords.Add("Профи", "professional");
            EngWords.Add("Выберите язык", "Choose language" );
            EngWords.Add("Choose tongue", "Choose tongue");
            EngWords.Add("выберите сложность", "choose difficulty");
            UcrWords.Add("выберите сложность", "виберіть складність");
            UcrWords.Add("Выберите язык", "Виберіть мову");
            UcrWords.Add("Новичок", "новачок");
            UcrWords.Add("Любитель", "Любiтiль");
            UcrWords.Add("Профи", "Профессіанал");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button1.Text = EngWords["Новичок"];
            button2.Text = EngWords["Любитель"];
            button3.Text = EngWords["Профи"];
            label1.Text = EngWords["Выберите язык"];
            label2.Text = EngWords["Choose tongue"];
            label3.Text = EngWords["выберите сложность"];

        }   

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.Text = RusWords["Новичок"];
            button2.Text = RusWords["Любитель"];
            button3.Text = RusWords["Профи"];
            label1.Text = RusWords["Выберите язык"];
            label2.Text = RusWords["Выберите язык"];
            label3.Text = RusWords["выберите сложность"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Text = UcrWords["Новичок"];
            button2.Text = UcrWords["Любитель"];
            button3.Text = UcrWords["Профи"];
            label1.Text = UcrWords["Выберите язык"];
            label2.Text = UcrWords["Выберите язык"];
            label3.Text = UcrWords["выберите сложность"];
        }
    }
}
