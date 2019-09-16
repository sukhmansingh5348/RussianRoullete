namespace RussianRoullete
{
    partial class RussianRoullette
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.spinBtn = new System.Windows.Forms.Button();
            this.shootBtn = new System.Windows.Forms.Button();
            this.shootAwayBtn = new System.Windows.Forms.Button();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.warGround = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warGround)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(213, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Russian Roullette";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.warGround);
            this.panel1.Location = new System.Drawing.Point(213, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 222);
            this.panel1.TabIndex = 1;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Maroon;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadBtn.Location = new System.Drawing.Point(49, 119);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(104, 76);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // spinBtn
            // 
            this.spinBtn.BackColor = System.Drawing.Color.Maroon;
            this.spinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spinBtn.Location = new System.Drawing.Point(49, 221);
            this.spinBtn.Name = "spinBtn";
            this.spinBtn.Size = new System.Drawing.Size(104, 75);
            this.spinBtn.TabIndex = 3;
            this.spinBtn.Text = "Spin";
            this.spinBtn.UseVisualStyleBackColor = false;
            this.spinBtn.Click += new System.EventHandler(this.spinBtn_Click);
            // 
            // shootBtn
            // 
            this.shootBtn.BackColor = System.Drawing.Color.Maroon;
            this.shootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shootBtn.Location = new System.Drawing.Point(672, 62);
            this.shootBtn.Name = "shootBtn";
            this.shootBtn.Size = new System.Drawing.Size(116, 76);
            this.shootBtn.TabIndex = 4;
            this.shootBtn.Text = "Shoot";
            this.shootBtn.UseVisualStyleBackColor = false;
            this.shootBtn.Click += new System.EventHandler(this.shootBtn_Click);
            // 
            // shootAwayBtn
            // 
            this.shootAwayBtn.BackColor = System.Drawing.Color.Maroon;
            this.shootAwayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootAwayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shootAwayBtn.Location = new System.Drawing.Point(672, 169);
            this.shootAwayBtn.Name = "shootAwayBtn";
            this.shootAwayBtn.Size = new System.Drawing.Size(116, 79);
            this.shootAwayBtn.TabIndex = 5;
            this.shootAwayBtn.Text = "Shoot Away";
            this.shootAwayBtn.UseVisualStyleBackColor = false;
            this.shootAwayBtn.Click += new System.EventHandler(this.shootAwayBtn_Click);
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.BackColor = System.Drawing.Color.Maroon;
            this.playAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playAgainBtn.Location = new System.Drawing.Point(672, 274);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(116, 85);
            this.playAgainBtn.TabIndex = 6;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = false;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // warGround
            // 
            this.warGround.Image = global::RussianRoullete.Properties.Resources.war;
            this.warGround.Location = new System.Drawing.Point(-2, -2);
            this.warGround.Name = "warGround";
            this.warGround.Size = new System.Drawing.Size(416, 222);
            this.warGround.TabIndex = 7;
            this.warGround.TabStop = false;
            // 
            // RussianRoullette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.shootAwayBtn);
            this.Controls.Add(this.shootBtn);
            this.Controls.Add(this.spinBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RussianRoullette";
            this.Text = "Play Game";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button spinBtn;
        private System.Windows.Forms.Button shootBtn;
        private System.Windows.Forms.Button shootAwayBtn;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.PictureBox warGround;
    }
}