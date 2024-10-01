namespace KeyboardControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.lblright = new System.Windows.Forms.Label();
            this.lblleft = new System.Windows.Forms.Label();
            this.lblup = new System.Windows.Forms.Label();
            this.lbldown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(429, 242);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(110, 77);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // lblright
            // 
            this.lblright.BackColor = System.Drawing.SystemColors.Control;
            this.lblright.Location = new System.Drawing.Point(821, 127);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(23, 314);
            this.lblright.TabIndex = 1;
            // 
            // lblleft
            // 
            this.lblleft.BackColor = System.Drawing.SystemColors.Control;
            this.lblleft.Location = new System.Drawing.Point(76, 127);
            this.lblleft.Name = "lblleft";
            this.lblleft.Size = new System.Drawing.Size(23, 314);
            this.lblleft.TabIndex = 2;
            // 
            // lblup
            // 
            this.lblup.BackColor = System.Drawing.SystemColors.Control;
            this.lblup.Location = new System.Drawing.Point(376, 66);
            this.lblup.Name = "lblup";
            this.lblup.Size = new System.Drawing.Size(233, 22);
            this.lblup.TabIndex = 3;
            // 
            // lbldown
            // 
            this.lbldown.BackColor = System.Drawing.SystemColors.Control;
            this.lbldown.Location = new System.Drawing.Point(376, 481);
            this.lbldown.Name = "lbldown";
            this.lbldown.Size = new System.Drawing.Size(233, 22);
            this.lbldown.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1006, 615);
            this.Controls.Add(this.lbldown);
            this.Controls.Add(this.lblup);
            this.Controls.Add(this.lblleft);
            this.Controls.Add(this.lblright);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label lblright;
        private System.Windows.Forms.Label lblleft;
        private System.Windows.Forms.Label lblup;
        private System.Windows.Forms.Label lbldown;
    }
}

