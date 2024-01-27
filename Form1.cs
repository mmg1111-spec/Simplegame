using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace gametestttt
{
    public partial class Form1 : Form
    {
        private SoundPlayer Player = new SoundPlayer();
        //private SoundPlayer play1;

        public Form1()
        {
            InitializeComponent();
            /*  string path = Application.StartupPath;
           path = path.Remove(path.IndexOf("\\bin"));
           this.play1 = new SoundPlayer(path + "\\rhxhd.wav");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);

            f2.Show();
           // this.button2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.play1.PlayLooping();
            //SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\rhxhd.wav");
            //splayer.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);

            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();
        }
        //SoundPlayer splayer = new SoundPlayer(@"C:\Nexon\asd\rhxhd.wav");
        // splayer.Play();
        /*this.Player.SoundLocation = @"C:\Nexon\asd\rhxhd.wav";
             this.Player.PlayLooping();*/
        /* this.Player.SoundLocation = Application.StartupPath + "rhxhd.wav";
        this.Player.PlayLooping();*/
        /*this.Player.SoundLocation = Application.StartupPath + "\rhxhd.wav";
        this.Player.PlayLooping();*/
    }
}
