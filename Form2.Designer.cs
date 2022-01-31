namespace Kursach
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.log_f = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Reg = new System.Windows.Forms.Button();
            this.B_Back = new System.Windows.Forms.Button();
            this.pas_f = new System.Windows.Forms.TextBox();
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
            // log_f
            // 
            this.log_f.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_f.ForeColor = System.Drawing.Color.Gray;
            this.log_f.Location = new System.Drawing.Point(111, 133);
            this.log_f.Multiline = true;
            this.log_f.Name = "log_f";
            this.log_f.Size = new System.Drawing.Size(336, 64);
            this.log_f.TabIndex = 3;
            this.log_f.Text = "Введите логин";
            this.log_f.MouseEnter += new System.EventHandler(this.log_f_MouseEnter);
            this.log_f.MouseLeave += new System.EventHandler(this.log_f_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.B_Reg);
            this.panel1.Controls.Add(this.B_Back);
            this.panel1.Controls.Add(this.pas_f);
            this.panel1.Controls.Add(this.log_f);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 465);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
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
            this.B_Reg.Location = new System.Drawing.Point(242, 314);
            this.B_Reg.Name = "B_Reg";
            this.B_Reg.Size = new System.Drawing.Size(206, 119);
            this.B_Reg.TabIndex = 6;
            this.B_Reg.Text = "Регистрация";
            this.B_Reg.UseVisualStyleBackColor = false;
            this.B_Reg.Click += new System.EventHandler(this.B_Reg_Click);
            // 
            // B_Back
            // 
            this.B_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.B_Back.AutoSize = true;
            this.B_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(11)))));
            this.B_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(237)))));
            this.B_Back.FlatAppearance.BorderSize = 0;
            this.B_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(83)))), ((int)(((byte)(5)))));
            this.B_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.B_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Back.Font = new System.Drawing.Font("Casual Contact MF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Back.Location = new System.Drawing.Point(112, 314);
            this.B_Back.Name = "B_Back";
            this.B_Back.Size = new System.Drawing.Size(124, 119);
            this.B_Back.TabIndex = 5;
            this.B_Back.Text = "Назад";
            this.B_Back.UseVisualStyleBackColor = false;
            this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
            // 
            // pas_f
            // 
            this.pas_f.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pas_f.ForeColor = System.Drawing.Color.Gray;
            this.pas_f.Location = new System.Drawing.Point(111, 218);
            this.pas_f.Name = "pas_f";
            this.pas_f.Size = new System.Drawing.Size(336, 53);
            this.pas_f.TabIndex = 4;
            this.pas_f.Text = "Введите пароль";
            this.pas_f.MouseEnter += new System.EventHandler(this.pas_f_MouseEnter);
            this.pas_f.MouseLeave += new System.EventHandler(this.pas_f_MouseLeave);
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
            this.panel2.Size = new System.Drawing.Size(461, 117);
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
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click_1);
            this.Exit_B.MouseEnter += new System.EventHandler(this.Exit_B_MouseEnter);
            this.Exit_B.MouseLeave += new System.EventHandler(this.Exit_B_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Casual Contact MF", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox log_f;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Reg;
        private System.Windows.Forms.Button B_Back;
        private System.Windows.Forms.TextBox pas_f;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit_B;
        private System.Windows.Forms.Label label1;
    }
}