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
    public partial class Form4 : Form
    {
       
       
        public Form4()
        {
            
            InitializeComponent(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            button1.Visible = false;
           
        }
      
       
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이쪽문이야.");
            pictureBox14.Visible = true;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이 문인것 같은데..");
            pictureBox14.Visible = true;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("여기 문이 맞길..");
            pictureBox14.Visible = true;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이쪽이 맞는것 같다.하지만 또 4개의 문이 있다");
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왠지 이 문인 것 같다");
            pictureBox14.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왠지 이 문인 것 같다");
            pictureBox14.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("문이 열렸다.이 다음 문만 열면 이 건물에서 나갈 수 있을 것 같다.");
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왠지 이 문인 것 같다");
            pictureBox14.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("여기인것 같은데..");
            pictureBox14.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("문을 빠져나왔더니 길목이 보인다... 탈출..한 건가?\n 도대체 그 숲은 뭐였던걸까..");
            MessageBox.Show("게임 클리어");
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\rhxhd.wav");
            splayer.Stop();
            /*foreach (Control c in m_parent.Controls)
            {
                if (c.Name == "pictureBox2") c.Visible = true;
            }*/
            Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("여기인것 같은데..");
            pictureBox14.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");
            Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("여기인것 같은데..");
            pictureBox14.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\Freddy_s-Dead-Sound.wav");
            splayer.Play();
            MessageBox.Show("게임 종료");

            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "\\rhxhd.wav");
            splayer.PlayLooping();
        }
    }
}
