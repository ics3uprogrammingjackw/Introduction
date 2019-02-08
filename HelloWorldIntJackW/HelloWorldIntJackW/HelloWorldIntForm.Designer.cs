namespace HelloWorldIntJackW
{
    partial class frmHelloWorldInt
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
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radButton4 = new System.Windows.Forms.RadioButton();
            this.radButton3 = new System.Windows.Forms.RadioButton();
            this.radButton2 = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radButton4);
            this.grbLanguages.Controls.Add(this.radButton3);
            this.grbLanguages.Controls.Add(this.radButton2);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Location = new System.Drawing.Point(22, 12);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(200, 100);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "groupBox1";
            // 
            // radButton4
            // 
            this.radButton4.AutoSize = true;
            this.radButton4.Location = new System.Drawing.Point(109, 65);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(85, 17);
            this.radButton4.TabIndex = 5;
            this.radButton4.TabStop = true;
            this.radButton4.Text = "radioButton4";
            this.radButton4.UseVisualStyleBackColor = true;
            // 
            // radButton3
            // 
            this.radButton3.AutoSize = true;
            this.radButton3.Location = new System.Drawing.Point(6, 65);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(85, 17);
            this.radButton3.TabIndex = 4;
            this.radButton3.TabStop = true;
            this.radButton3.Text = "radioButton3";
            this.radButton3.UseVisualStyleBackColor = true;
            // 
            // radButton2
            // 
            this.radButton2.AutoSize = true;
            this.radButton2.Location = new System.Drawing.Point(109, 28);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(85, 17);
            this.radButton2.TabIndex = 3;
            this.radButton2.TabStop = true;
            this.radButton2.Text = "radioButton2";
            this.radButton2.UseVisualStyleBackColor = true;
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(6, 28);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(85, 17);
            this.radEnglish.TabIndex = 2;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "radioButton1";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged_1);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 261);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.label1);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International by Jack W";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radButton4;
        private System.Windows.Forms.RadioButton radButton3;
        private System.Windows.Forms.RadioButton radButton2;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

