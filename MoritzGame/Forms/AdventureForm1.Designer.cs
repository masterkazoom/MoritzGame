namespace MoritzGame.Forms
{
    partial class AdventureForm1
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
            this.AdventureButton1 = new System.Windows.Forms.Button();
            this.AdventureButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdventureButton1
            // 
            this.AdventureButton1.Location = new System.Drawing.Point(197, 226);
            this.AdventureButton1.Name = "AdventureButton1";
            this.AdventureButton1.Size = new System.Drawing.Size(75, 23);
            this.AdventureButton1.TabIndex = 0;
            this.AdventureButton1.Text = "back";
            this.AdventureButton1.UseVisualStyleBackColor = true;
            this.AdventureButton1.Click += new System.EventHandler(this.AdventureButton1_Click);
            // 
            // AdventureButton2
            // 
            this.AdventureButton2.Location = new System.Drawing.Point(75, 58);
            this.AdventureButton2.Name = "AdventureButton2";
            this.AdventureButton2.Size = new System.Drawing.Size(75, 23);
            this.AdventureButton2.TabIndex = 1;
            this.AdventureButton2.Text = "button1";
            this.AdventureButton2.UseVisualStyleBackColor = true;
            this.AdventureButton2.Click += new System.EventHandler(this.AdventureButton2_Click);
            // 
            // AdventureForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AdventureButton2);
            this.Controls.Add(this.AdventureButton1);
            this.Name = "AdventureForm1";
            this.Text = "AdventureForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdventureButton1;
        private System.Windows.Forms.Button AdventureButton2;
    }
}