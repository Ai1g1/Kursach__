namespace Kursach
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Text = new System.Windows.Forms.Button();
            this.resheto = new System.Windows.Forms.PictureBox();
            this.B_Start = new System.Windows.Forms.Button();
            this.N_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resheto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.Text);
            this.panel1.Controls.Add(this.resheto);
            this.panel1.Controls.Add(this.B_Start);
            this.panel1.Controls.Add(this.N_TB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 761);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Text
            // 
            this.Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Text.AutoSize = true;
            this.Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(11)))));
            this.Text.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(237)))));
            this.Text.FlatAppearance.BorderSize = 0;
            this.Text.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(83)))), ((int)(((byte)(5)))));
            this.Text.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text.Font = new System.Drawing.Font("Casual Contact MF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.Location = new System.Drawing.Point(559, 647);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(87, 82);
            this.Text.TabIndex = 13;
            this.Text.Text = "Save";
            this.Text.UseVisualStyleBackColor = false;
            this.Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // resheto
            // 
            this.resheto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.resheto.Image = ((System.Drawing.Image)(resources.GetObject("resheto.Image")));
            this.resheto.Location = new System.Drawing.Point(154, 134);
            this.resheto.Name = "resheto";
            this.resheto.Size = new System.Drawing.Size(492, 492);
            this.resheto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resheto.TabIndex = 12;
            this.resheto.TabStop = false;
            this.resheto.WaitOnLoad = true;
            // 
            // B_Start
            // 
            this.B_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.B_Start.AutoSize = true;
            this.B_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(11)))));
            this.B_Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(237)))));
            this.B_Start.FlatAppearance.BorderSize = 0;
            this.B_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(83)))), ((int)(((byte)(5)))));
            this.B_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.B_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Start.Font = new System.Drawing.Font("Casual Contact MF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Start.Location = new System.Drawing.Point(271, 647);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(282, 78);
            this.B_Start.TabIndex = 7;
            this.B_Start.Text = "Запуск алгоритма";
            this.B_Start.UseVisualStyleBackColor = false;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // N_TB
            // 
            this.N_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(11)))));
            this.N_TB.Font = new System.Drawing.Font("Casual Contact MF", 20.25F);
            this.N_TB.Location = new System.Drawing.Point(184, 647);
            this.N_TB.Multiline = true;
            this.N_TB.Name = "N_TB";
            this.N_TB.Size = new System.Drawing.Size(81, 78);
            this.N_TB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Casual Contact MF", 20.25F);
            this.label2.Location = new System.Drawing.Point(3, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 66);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите N  *\r\nот 1 до 49   *\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(11)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.Exit_B);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 117);
            this.panel2.TabIndex = 0;
            // 
            // Exit_B
            // 
            this.Exit_B.AutoSize = true;
            this.Exit_B.Font = new System.Drawing.Font("mr_BenzaG", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_B.Location = new System.Drawing.Point(755, 0);
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
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Решето аткина";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resheto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.TextBox N_TB;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox resheto;
        private System.Windows.Forms.Button Text;
    }
}