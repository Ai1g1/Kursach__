
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.pas_f.AutoSize = false;
            this.pas_f.Size = new Size(this.pas_f.Size.Width, 64);

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
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - l.X;
                this.Top += e.Y - l.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            l = new Point(e.X, e.Y);
        }

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

        private void B_Log_Click(object sender, EventArgs e)
        {
            String log_U = log_f.Text;
            String pas_U = pas_f.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login`= @lU AND `pass`= @pU", db.GetConnection());
            command.Parameters.AddWithValue("@lU", log_U);
            command.Parameters.AddWithValue("@pU", pas_U);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                Form3 atk = new Form3();
                atk.Show();
            }
            else
                MessageBox.Show("Авторизация не прошла");
        }

        private void B_Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 reg = new Form2();
            reg.Show();
        }
    }
}
