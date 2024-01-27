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
    public partial class Form3 : Form
    {
        Form1 m_parent;

        public String m_f3_msg { get; set; }
        public Form3(Form1 f1)
        {
            m_parent = f1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\rhxhd.wav");
            splayer.PlayLooping();
            MessageBox.Show("신경이 쓰이는 곳으로 왔더니 길 한가운데에\n이상한 인형이 있었다. 이건 대체...?");
        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("일단 신경쓰이는 인형을 들고가보자...\n(인형을 클릭하세요.)");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("이 소리는? 무척 가까이서 들린 것 같다.\n무언가 쫓아오고 있다 빨리 다른 길을 찾아야한다.\n잘못된 길로 나아가거나 멈춰선 안 될 것 같은 예감이 든다...");
            SoundPlayer player = new SoundPlayer(Application.StartupPath + "\\vuswlq.wav");
            player.PlayLooping();
            this.button1.Visible = false;
            this.pictureBox2.Visible = false;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.pictureBox3.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tkrwp();
            Tkrwprmfla();
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            pictureBox8.Visible = true;
            Tkrwprmfla();
            MessageBox.Show("게임 오버");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("맞는 길인 것 같지만 한번 더 갈림길이 나왔다....\n어느 쪽으로 가야하지? 빨리 도망쳐야 한다.");
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            tkrwp();
            
        }
        private void tkrwp()
        {
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("옆으로 나아간다.");
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            pictureBox8.Visible = true;
            Tkrwprmfla();
            MessageBox.Show("게임 오버");
            Close();
        }
        private void Tkrwprmfla()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내 감이 맞길...");
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            pictureBox8.Visible = true;
            Tkrwprmfla();
            MessageBox.Show("게임 오버");
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("하아...하아...\n이상한 소리를 내는 생물을 따돌린 것 같다.\n그런데 이 건물은 대체...?");
            MessageBox.Show("2챕터가 끝났습니다. 메인 화면의 3챕터를 클릭하여 진행해 주세요.");
            foreach (Control c in m_parent.Controls)
            {
                if (c.Name == "button3") c.Visible = true;
            }
            SoundPlayer player = new SoundPlayer(Application.StartupPath + "\\vuswlq.wav");
            player.Stop();
            timer1.Stop();
            Close();
        }
    }
}
