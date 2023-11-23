namespace FlappyRabbitGame
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.rabbit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipeup2 = new System.Windows.Forms.PictureBox();
            this.pipedown2 = new System.Windows.Forms.PictureBox();
            this.pipedown3 = new System.Windows.Forms.PictureBox();
            this.pipeup3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup3)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.LightPink;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-2, 394);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(859, 117);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // rabbit
            // 
            this.rabbit.BackColor = System.Drawing.Color.Transparent;
            this.rabbit.Image = ((System.Drawing.Image)(resources.GetObject("rabbit.Image")));
            this.rabbit.Location = new System.Drawing.Point(52, 70);
            this.rabbit.Name = "rabbit";
            this.rabbit.Size = new System.Drawing.Size(55, 53);
            this.rabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rabbit.TabIndex = 1;
            this.rabbit.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Moccasin;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.HotPink;
            this.lbScore.Location = new System.Drawing.Point(12, 452);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(95, 29);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "Score: 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pipeup
            // 
            this.pipeup.BackColor = System.Drawing.Color.Transparent;
            this.pipeup.Image = ((System.Drawing.Image)(resources.GetObject("pipeup.Image")));
            this.pipeup.Location = new System.Drawing.Point(459, -69);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(70, 204);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 4;
            this.pipeup.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.BackColor = System.Drawing.Color.Transparent;
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(459, 265);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(70, 160);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 5;
            this.pipedown.TabStop = false;
            // 
            // pipeup2
            // 
            this.pipeup2.BackColor = System.Drawing.Color.Transparent;
            this.pipeup2.Image = ((System.Drawing.Image)(resources.GetObject("pipeup2.Image")));
            this.pipeup2.Location = new System.Drawing.Point(259, -40);
            this.pipeup2.Name = "pipeup2";
            this.pipeup2.Size = new System.Drawing.Size(70, 204);
            this.pipeup2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup2.TabIndex = 6;
            this.pipeup2.TabStop = false;
            // 
            // pipedown2
            // 
            this.pipedown2.BackColor = System.Drawing.Color.Transparent;
            this.pipedown2.Image = ((System.Drawing.Image)(resources.GetObject("pipedown2.Image")));
            this.pipedown2.Location = new System.Drawing.Point(259, 284);
            this.pipedown2.Name = "pipedown2";
            this.pipedown2.Size = new System.Drawing.Size(70, 160);
            this.pipedown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown2.TabIndex = 7;
            this.pipedown2.TabStop = false;
            // 
            // pipedown3
            // 
            this.pipedown3.BackColor = System.Drawing.Color.Transparent;
            this.pipedown3.Image = ((System.Drawing.Image)(resources.GetObject("pipedown3.Image")));
            this.pipedown3.Location = new System.Drawing.Point(659, 284);
            this.pipedown3.Name = "pipedown3";
            this.pipedown3.Size = new System.Drawing.Size(70, 160);
            this.pipedown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown3.TabIndex = 8;
            this.pipedown3.TabStop = false;
            // 
            // pipeup3
            // 
            this.pipeup3.BackColor = System.Drawing.Color.Transparent;
            this.pipeup3.Image = ((System.Drawing.Image)(resources.GetObject("pipeup3.Image")));
            this.pipeup3.Location = new System.Drawing.Point(659, -40);
            this.pipeup3.Name = "pipeup3";
            this.pipeup3.Size = new System.Drawing.Size(70, 204);
            this.pipeup3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup3.TabIndex = 9;
            this.pipeup3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(857, 504);
            this.Controls.Add(this.pipeup3);
            this.Controls.Add(this.pipeup2);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.rabbit);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.pipedown2);
            this.Controls.Add(this.pipedown3);
            this.ForeColor = System.Drawing.Color.LightPink;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Rabbit Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox rabbit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox pipeup2;
        private System.Windows.Forms.PictureBox pipedown2;
        private System.Windows.Forms.PictureBox pipedown3;
        private System.Windows.Forms.PictureBox pipeup3;
    }
}

