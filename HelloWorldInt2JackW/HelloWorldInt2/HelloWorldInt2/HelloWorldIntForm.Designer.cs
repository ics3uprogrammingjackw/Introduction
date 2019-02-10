namespace HelloWorldInt2
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
            this.lblGreetings = new System.Windows.Forms.Label();
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radPortugese = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblGreetings.Location = new System.Drawing.Point(300, 101);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(152, 29);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "Hello, World!";
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radGerman);
            this.grbLanguages.Controls.Add(this.radPortugese);
            this.grbLanguages.Controls.Add(this.radSpanish);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Location = new System.Drawing.Point(236, 196);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(308, 138);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Languages";
            this.grbLanguages.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(40, 37);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(188, 37);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 1;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.radSpanish_CheckedChanged);
            // 
            // radPortugese
            // 
            this.radPortugese.AutoSize = true;
            this.radPortugese.Location = new System.Drawing.Point(40, 91);
            this.radPortugese.Name = "radPortugese";
            this.radPortugese.Size = new System.Drawing.Size(73, 17);
            this.radPortugese.TabIndex = 2;
            this.radPortugese.TabStop = true;
            this.radPortugese.Text = "Portugese";
            this.radPortugese.UseVisualStyleBackColor = true;
            this.radPortugese.CheckedChanged += new System.EventHandler(this.radPortugese_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(188, 91);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(62, 17);
            this.radGerman.TabIndex = 3;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.radGerman_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.lblGreetings);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International by Jack W";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radPortugese;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

