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
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radPortugese = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.lblGreetings = new System.Windows.Forms.Label();
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
            this.grbLanguages.Controls.Add(this.radGerman);
            this.grbLanguages.Controls.Add(this.radPortugese);
            this.grbLanguages.Controls.Add(this.radSpanish);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Location = new System.Drawing.Point(31, 107);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(200, 100);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Languages";
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(109, 65);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(62, 17);
            this.radGerman.TabIndex = 5;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            // 
            // radPortugese
            // 
            this.radPortugese.AutoSize = true;
            this.radPortugese.Location = new System.Drawing.Point(6, 65);
            this.radPortugese.Name = "radPortugese";
            this.radPortugese.Size = new System.Drawing.Size(73, 17);
            this.radPortugese.TabIndex = 4;
            this.radPortugese.TabStop = true;
            this.radPortugese.Text = "Portugese";
            this.radPortugese.UseVisualStyleBackColor = true;
            this.radPortugese.CheckedChanged += new System.EventHandler(this.radPortugese_CheckedChanged_1);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(109, 28);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 3;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.radSpanish_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(6, 28);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 2;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged_1);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(111, 40);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(68, 13);
            this.lblGreetings.TabIndex = 6;
            this.lblGreetings.Text = "Hello, World!";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 261);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.label1);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International by Jack W";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radPortugese;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.Label lblGreetings;
    }
}

