namespace PerAreaVolJackW
{
    partial class frmPerAreaVol
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
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblEquals1 = new System.Windows.Forms.Label();
            this.lblEquals2 = new System.Windows.Forms.Label();
            this.lblEquals3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(25, 12);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(85, 85);
            this.btnQuestion1.TabIndex = 0;
            this.btnQuestion1.Text = "The perimeter of a rectangle with a length of 5 and a width of 2 is";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Location = new System.Drawing.Point(25, 114);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(85, 61);
            this.btnQuestion2.TabIndex = 1;
            this.btnQuestion2.Text = "The area of a circle with a radius of 5 is";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Click += new System.EventHandler(this.btnQuestion2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(25, 198);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(85, 51);
            this.btnQuestion3.TabIndex = 2;
            this.btnQuestion3.Text = "The volume of a spehere with a radius of 4 is";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.btnQuestion3_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(195, 48);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer1.TabIndex = 3;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(195, 138);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer2.TabIndex = 4;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(195, 217);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer3.TabIndex = 5;
            // 
            // lblEquals1
            // 
            this.lblEquals1.AutoSize = true;
            this.lblEquals1.Location = new System.Drawing.Point(133, 48);
            this.lblEquals1.Name = "lblEquals1";
            this.lblEquals1.Size = new System.Drawing.Size(13, 13);
            this.lblEquals1.TabIndex = 6;
            this.lblEquals1.Text = "=";
            // 
            // lblEquals2
            // 
            this.lblEquals2.AutoSize = true;
            this.lblEquals2.Location = new System.Drawing.Point(133, 138);
            this.lblEquals2.Name = "lblEquals2";
            this.lblEquals2.Size = new System.Drawing.Size(13, 13);
            this.lblEquals2.TabIndex = 7;
            this.lblEquals2.Text = "=";
            // 
            // lblEquals3
            // 
            this.lblEquals3.AutoSize = true;
            this.lblEquals3.Location = new System.Drawing.Point(133, 217);
            this.lblEquals3.Name = "lblEquals3";
            this.lblEquals3.Size = new System.Drawing.Size(13, 13);
            this.lblEquals3.TabIndex = 8;
            this.lblEquals3.Text = "=";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEquals3);
            this.Controls.Add(this.lblEquals2);
            this.Controls.Add(this.lblEquals1);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnQuestion1);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter Area Volume by Jack W";
            this.Load += new System.EventHandler(this.frmPerAreaVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblEquals1;
        private System.Windows.Forms.Label lblEquals2;
        private System.Windows.Forms.Label lblEquals3;
    }
}

