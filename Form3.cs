using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursach
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Exit_B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_B_MouseEnter(object sender, EventArgs e)
        {
            Exit_B.ForeColor = Color.White;
        }

        private void Exit_B_MouseLeave(object sender, EventArgs e)
        {
            Exit_B.ForeColor = Color.Black;
        }
        Point l;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            l = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - l.X;
                this.Top += e.Y - l.Y;
            }
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            int l = 250;
            int s_l = Convert.ToInt32(Math.Sqrt(l));
            int n;
            bool[] p = new bool[l];
            if (N_TB.Text == "")
            {
                MessageBox.Show("Введите число от 1 до 49");
                return;
            }
            if (Convert.ToInt32(N_TB.Text) >= 50 || Convert.ToInt32(N_TB.Text) < 1)
            {
                MessageBox.Show("Введите число от 1 до 49");
                return;
            }
            int num = Convert.ToInt32(N_TB.Text);
            num = num;
            for (int i=0; i < num; i++)
            {
                p[i] = false;
            }
            p[2] = true;
            p[3] = true;
            int x2;
            int y2;
            for (int i=1; i < s_l; i++)
            {
                x2 = i * i; 
                for(int j = 0; j < s_l; j++)
                {
                    y2 = j * j;
                    n = 4 * x2 + y2;//4x2+y2
                    if (n <= l && (n % 12 == 1 || n % 12 == 5))
                        p[n] = !p[n];
                    n -= x2;//3x2+y2
                    if (n <= l && n % 12 == 7)
                        p[n] = !p[n];
                    n -= 2 * y2;//3x2-y2
                    if (n <= l && i > j && n % 12 == 11)
                        p[n] = !p[n];
                }
            }
            for (int i=5; i < s_l; i++)
            {
                n = i * i;
                for(int j=n; j < l; j += n)
                {
                    p[n] = false;
                }
            }
            n = 2;
            int k = 0;
            string s = Application.StartupPath  ;
            resheto.Image = Image.FromFile(s.Remove(s.IndexOf(@"\bin\Debug"),10) + "\\img\\12345.png");
            //resheto.Image = Image.FromFile("C:\\Users\\acer\\Desktop\\Учеба\\2 курс\\ОП\\1234.png");
            Brush brush = new SolidBrush(Color.Black);
            Graphics g = Graphics.FromImage(resheto.Image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            while (n < l && num> k)
            {

                if (n < 6 && p[n])
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    g.DrawString(Convert.ToString(n), new Font ("Times New Roman", 20, FontStyle.Bold), brush, 20 + 70 * (k % 7), 20 + 70 * (k/ 7));
                    k++;
                }
                else if (p[n] && n % 3 != 0 && n % 5 != 0)
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    g.DrawString(Convert.ToString(n), new Font("Times New Roman", 20,FontStyle.Bold), brush, 20 + 70 * (k % 7), 20 + 70 * (k / 7));
                    k++;
                }
                n++;
            }
            
        }

        private void Text_Click(object sender, EventArgs e)
        {
            if (resheto.Image != null)
            {
                SaveFileDialog saves = new SaveFileDialog();
                saves.Title = "Save picture";
                saves.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
                if (saves.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        resheto.Image.Save(saves.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save");
                    }
                }
            }

        }
    }
}
