namespace ImageProcessingApp.Forms
{
    partial class LeavingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeavingForm));
            this.Nie = new System.Windows.Forms.Button();
            this.Tak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nie
            // 
            this.Nie.Location = new System.Drawing.Point(294, 63);
            this.Nie.Name = "Nie";
            this.Nie.Size = new System.Drawing.Size(108, 41);
            this.Nie.TabIndex = 0;
            this.Nie.Text = "Nie";
            this.Nie.UseVisualStyleBackColor = true;
            this.Nie.Click += new System.EventHandler(this.Nie_Click);
            // 
            // Tak
            // 
            this.Tak.Location = new System.Drawing.Point(94, 63);
            this.Tak.Name = "Tak";
            this.Tak.Size = new System.Drawing.Size(108, 41);
            this.Tak.TabIndex = 1;
            this.Tak.Text = "Tak";
            this.Tak.UseVisualStyleBackColor = true;
            this.Tak.Click += new System.EventHandler(this.Tak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nie wszystkie obrazy zostały zamknięte. Czy na pewno chesz opuścić program?";
            // 
            // LeavingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(487, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tak);
            this.Controls.Add(this.Nie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(503, 188);
            this.MinimumSize = new System.Drawing.Size(503, 188);
            this.Name = "LeavingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyjście z programu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nie;
        private System.Windows.Forms.Button Tak;
        private System.Windows.Forms.Label label1;
    }
}