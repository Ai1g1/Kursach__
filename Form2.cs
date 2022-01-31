using MySqlConnector;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.pas_f.AutoSize = false;
            this.pas_f.Size = new Size(this.pas_f.Size.Width, 64);
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

        private void Exit_B_Click_1(object sender, EventArgs e)
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

        private void log_f_MouseEnter(object sender, EventArgs e)
        {
            log_f.ForeColor = Color.Black;
            if (log_f.Text == "Введите логин")
            {
                log_f.Text = "";
                
            }
        }

        private void pas_f_MouseEnter(object sender, EventArgs e)
        {
            if (pas_f.Text == "Введите пароль")
            {
                pas_f.Text = "";
                pas_f.UseSystemPasswordChar = true;
                pas_f.ForeColor = Color.Black;
            }
        }

        private void log_f_MouseLeave(object sender, EventArgs e)
        {
            if (log_f.Text == "")
            {
                log_f.Text = "Введите логин";
                log_f.ForeColor = Color.Gray;
            }
        }

        private void pas_f_MouseLeave(object sender, EventArgs e)
        {
            if (pas_f.Text == "")
            {
                pas_f.Text = "Введите пароль";
                pas_f.ForeColor = Color.Gray;
                pas_f.UseSystemPasswordChar = false;
            }
        }


        private void B_Reg_Click(object sender, EventArgs e)
        {
            if (log_f.Text=="Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (pas_f.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (checkU())
            {
                return;
            }
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`login`, `pass`) VALUE (@log, @pass)", dB.GetConnection());
            command.Parameters.AddWithValue("@log", log_f.Text);
            command.Parameters.AddWithValue("@pass", pas_f.Text);
            dB.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Aккаунт создан");
            }
            else
            {
                MessageBox.Show("Aккаунт не создан");
            }
         
            dB.CloseConnection();
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }
        public Boolean checkU()
        {
            String log_U = log_f.Text;
            String pas_U = pas_f.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login`= @lU", db.GetConnection());
            command.Parameters.AddWithValue("@lU", log_U);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Имя занято");
                return true;
            }
            else
                return false;
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }
    }
}
