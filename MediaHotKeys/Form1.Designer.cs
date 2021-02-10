namespace MediaHotKeys
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btMinimize = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Notify icon hotkeys";
            this.notifyIcon.BalloonTipTitle = "Título do balão";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Media Hotkeys";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(378, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift + Alt + seta para a direita = Próxima música";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(376, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shift + Alt + seta para a esquerda = Música anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(378, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift + Alt + seta para baixo = Play/Pause";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(538, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Atalhos";
            // 
            // btMinimize
            // 
            this.btMinimize.AutoSize = true;
            this.btMinimize.Font = new System.Drawing.Font("Consolas", 25F);
            this.btMinimize.ForeColor = System.Drawing.Color.White;
            this.btMinimize.Location = new System.Drawing.Point(745, 9);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(36, 40);
            this.btMinimize.TabIndex = 5;
            this.btMinimize.Text = "-";
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Font = new System.Drawing.Font("Consolas", 25F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(787, 7);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(36, 40);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "x";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(9, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 151);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mantenha o app aberto para utilizar os comandos. Os comandos estão descritos ao l" +
    "ado. Ahhh, e você pode clicar em minimizar para minimizar o app na bandeja do si" +
    "stema :D ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(59, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Media Hotkeys - Atalhos de mídia no teclado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(58, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "Como utilizar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(313, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Desenvolvido por ";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.ForeColor = System.Drawing.Color.Teal;
            this.lbLink.LinkColor = System.Drawing.Color.Teal;
            this.lbLink.Location = new System.Drawing.Point(400, 292);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(81, 13);
            this.lbLink.TabIndex = 11;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "Ricardo Colzani";
            this.lbLink.VisitedLinkColor = System.Drawing.Color.White;
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(835, 314);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Media Hotkeys - Atalhos de teclado para execução de comandos de mída";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btMinimize;
        private System.Windows.Forms.Label btClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lbLink;
    }
}

