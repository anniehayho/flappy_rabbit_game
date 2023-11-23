using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyRabbitGame
{
    public partial class LevelForm : Form
    {
        public LevelForm()
        {
            InitializeComponent();
        }

        private void LevelForm_Load(object sender, EventArgs e)
        {
            string path = @"..\..\..\FlappyRabbitGame\assets\images\background.png";
            string rabbit = @"..\..\..\FlappyRabbitGame\assets\images\rabbit.png";

            this.BackgroundImage = Image.FromFile(path);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.BackColor = ColorTranslator.FromHtml("#71C5CF");
            pictureBox1.Image = Image.FromFile(rabbit);
            pictureBox1.BackColor = ColorTranslator.FromHtml("#71C5CF");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.setspeed(5);
            this.Hide();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.setspeed(10);
            this.Hide();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.setspeed(15);
            this.Hide();
            form1.ShowDialog();
        }
    }
}
