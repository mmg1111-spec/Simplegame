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
    public partial class Form2 : Form
    {
        Form1 m_parent;

        public String m_f2_msg { get; set; }
        //private SoundPlayer play1;

        public Form2(Form1 f1)
        {
            m_parent = f1;
            InitializeComponent();
            // string path = Application.StartupPath;
            //path = path.Remove(path.IndexOf("\\bin"));
            //this.play1 = new SoundPlayer(path + "\\rhxhd.wav");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Screen.PrimaryScreen.Bounds. 이 모니터의 해상도 확인
            // this.play1.PlayLooping();
            
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\rhxhd.wav");
            splayer.PlayLooping();
            //리사이즈에서 설정하면 폼크기에따라 같이 움직이지않음
            button1.Location = new Point((int)(this.Width * 0.4), (int)(this.Height * 0.7));
            // 이상한곳감 pictureBox1.Location = new Point((int)(this.Width), (int)(this.Height));
            MessageBox.Show("아무래도 이 숲속에는 야생동물들이 살고 있는 것 같다.\n잘못된 길로 나아가면 안될 것 같다. 신중하게 나아가자");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이 길이 맞는 것 같다. 더 앞으로 나아가보자.");
           // 이상하게 다른 버튼들이 보이지 않음 this.point2.Visible = true;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왼쪽으로 나아간다.");
            this.freddy.Visible = true;
            this.point2.Visible = false;
            this.point1.Visible = false;
            // SoundPlayer splayer = new SoundPlayer(@"C:\Nexon\asd\Freddy_s-Dead-Sound.wav");
            //splayer.Play();
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 오버");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오른쪽으로 나아간다.");
            this.freddy.Visible = true;
            this.point2.Visible = false;
            this.point1.Visible = false;
            //SoundPlayer splayer = new SoundPlayer(@"C:\Nexon\asd\Freddy_s-Dead-Sound.wav");
            // splayer.Play();
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 오버");
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("앞으로 나아간다.");
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.freddy.Visible = true;
            this.point2.Visible = false;
            this.point1.Visible = false;

            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 오버");
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("나아 갈 수록 점점 어두워 지는 것 같다. 그리고 왼쪽 저편에 검은 무언가가 보인다... 내 착각인가? 확인하기 위해 왼쪽으로 이동하자");
            this.point3.Visible = true;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오른쪽으로 나아간다..");
            this.freddy.Visible = true;
            this.point2.Visible = false;
            this.point1.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 오버");
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("확인하기 위해 왼쪽으로 나아가보자.\n(2챕터가 열렸습니다. 첫 번째 창에서 2챕터를 클릭해 진행해주세요..)");
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\rhxhd.wav");
            splayer.Stop();
            foreach (Control c in m_parent.Controls)
            {
                if (c.Name == "button2") c.Visible = true;
            }
            Close();

        }
    }
}
