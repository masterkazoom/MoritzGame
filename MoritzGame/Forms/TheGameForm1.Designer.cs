namespace MoritzGame
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainButton1 = new System.Windows.Forms.Button();
            this.MainButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainButton1
            // 
            this.MainButton1.Location = new System.Drawing.Point(12, 12);
            this.MainButton1.Name = "MainButton1";
            this.MainButton1.Size = new System.Drawing.Size(75, 23);
            this.MainButton1.TabIndex = 0;
            this.MainButton1.Text = "Hero...";
            this.MainButton1.UseVisualStyleBackColor = true;
            this.MainButton1.Click += new System.EventHandler(this.MainButton1_Click);
            // 
            // MainButton2
            // 
            this.MainButton2.Location = new System.Drawing.Point(12, 41);
            this.MainButton2.Name = "MainButton2";
            this.MainButton2.Size = new System.Drawing.Size(75, 23);
            this.MainButton2.TabIndex = 1;
            this.MainButton2.Text = "Adventure";
            this.MainButton2.UseVisualStyleBackColor = true;
            this.MainButton2.Click += new System.EventHandler(this.MainButton2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 97);
            this.Controls.Add(this.MainButton2);
            this.Controls.Add(this.MainButton1);
            this.Name = "MainWindow";
            this.Text = "The Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainButton1;
        private System.Windows.Forms.Button MainButton2;
    }
}

