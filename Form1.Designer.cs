using System;
using System.Globalization;
using System.Windows.Forms;

namespace homework14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num;
        int count = 0;
        bool k = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 9);
        }

        // Çıxış düyməsi / etiketi
        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        // Yeni oyun düyməsi
        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            label3.Text = count.ToString();
            Random r = new Random();
            num = r.Next(1, 9);

            if (k == false)
            {
                k = true;
                pictureBox1.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
                pictureBox2.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
                pictureBox3.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
                pictureBox4.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
                pictureBox5.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
                pictureBox6.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
                pictureBox7.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
                pictureBox8.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
            }
            else
            {
                k = false;
                pictureBox1.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
                pictureBox2.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
                pictureBox3.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
                pictureBox4.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
                pictureBox5.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
                pictureBox6.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
                pictureBox7.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
                pictureBox8.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                count = 0;
                pictureBox1.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox1.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (num == 2)
            {
                count = 0;
                pictureBox2.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox2.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (num == 3)
            {
                count = 0;
                pictureBox3.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox3.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\narincireng.png";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (num == 4)
            {
                count = 0;
                pictureBox4.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox4.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\goyreng1.jpeg";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (num == 5)
            {
                count = 0;
                pictureBox5.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox5.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (num == 6)
            {
                count = 0;
                pictureBox6.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox6.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (num == 7)
            {
                count = 0;
                pictureBox7.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox7.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\qirmizi.jpg";
            }
            label3.Text = count.ToString();
        }

        private void pictureBox8_Click(object slash, EventArgs args)
        {
            if (num == 8)
            {
                count = 0;
                pictureBox8.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
                DialogResult d = MessageBox.Show("Oyun bitdi, yeni oyun üçün ok basın", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox8.ImageLocation = "C:\\Users\\USER\\OneDrive\\Desktop\\yasilreng.jpg";
            }
            label3.Text = count.ToString();
        }
    }
}
