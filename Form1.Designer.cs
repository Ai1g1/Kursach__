namespace Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Reg = new System.Windows.Forms.Button();
            this.B_Log = new System.Windows.Forms.Button();
            this.pas_f = new System.Windows.Forms.TextBox();
            this.log_f = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.B_Reg);
            this.panel1.Controls.Add(this.B_Log);
            this.panel1.Controls.Add(this.pas_f);
            this.panel1.Controls.Add(this.log_f);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 411);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // B_Reg
            // 
            this.B_Reg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.B_Reg.AutoSize = true;
            this.B_Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(11)))));
            this.B_Reg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(237)))));
            this.B_Reg.FlatAppearance.BorderSize = 0;
            this.B_Reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(83)))), ((int)(((byte)(5)))));
            this.B_Reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.B_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Reg.Font = new System.Drawing.Font("Casual Contact MF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Reg.Location = new System.Drawing.Point(241, 314);
            this.B_Reg.Name = "B_Reg";
            this.B_Reg.Size = new System.Drawing.Size(206, 90);
            this.B_Reg.TabIndex = 6;
            this.B_Reg.Text = "Регистрация";
            this.B_Reg.UseVisualStyleBackColor = false;
            this.B_Reg.Click += new System.EventHandler(this.B_Reg_Click);
            // 
            // B_Log
            // 
            this.B_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.B_Log.AutoSize = true;
            this.B_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(11)))));
            this.B_Log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(237)))));
            this.B_Log.FlatAppearance.BorderSize = 0;
            this.B_Log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(83)))), ((int)(((byte)(5)))));
            this.B_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.B_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Log.Font = new System.Drawing.Font("Casual Contact MF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Log.Location = new System.Drawing.Point(111, 314);
            this.B_Log.Name = "B_Log";
            this.B_Log.Size = new System.Drawing.Size(124, 90);
            this.B_Log.TabIndex = 5;
            this.B_Log.Text = "Войти";
            this.B_Log.UseVisualStyleBackColor = false;
            this.B_Log.Click += new System.EventHandler(this.B_Log_Click);
            // 
            // pas_f
            // 
            this.pas_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pas_f.Location = new System.Drawing.Point(111, 218);
            this.pas_f.Name = "pas_f";
            this.pas_f.PasswordChar = '*';
            this.pas_f.Size = new System.Drawing.Size(336, 53);
            this.pas_f.TabIndex = 4;
            this.pas_f.UseSystemPasswordChar = true;
            // 
            // log_f
            // 
            this.log_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_f.Location = new System.Drawing.Point(111, 133);
            this.log_f.Multiline = true;
            this.log_f.Name = "log_f";
            this.log_f.Size = new System.Drawing.Size(336, 64);
            this.log_f.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(11)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.Exit_B);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 117);
            this.panel2.TabIndex = 0;
            // 
            // Exit_B
            // 
            this.Exit_B.AutoSize = true;
            this.Exit_B.Font = new System.Drawing.Font("mr_BenzaG", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_B.Location = new System.Drawing.Point(430, 0);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(29, 32);
            this.Exit_B.TabIndex = 1;
            this.Exit_B.Text = "X";
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            this.Exit_B.MouseEnter += new System.EventHandler(this.Exit_B_MouseEnter);
            this.Exit_B.MouseLeave += new System.EventHandler(this.Exit_B_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Casual Contact MF", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit_B;
        private System.Windows.Forms.TextBox pas_f;
        private System.Windows.Forms.TextBox log_f;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_Log;
        private System.Windows.Forms.Button B_Reg;
    }
}

