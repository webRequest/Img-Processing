using System.Collections.Generic;
using System.Windows.Forms;

namespace ImageProcessingApp.Forms
{
    partial class XorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XorForm));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnXor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Gray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 46);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(271, 184);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(300, 12);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(110, 35);
            this.btnXor.TabIndex = 1;
            this.btnXor.Text = "Wykonaj";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz 2 pozycje z listy";
            // 
            // XorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(422, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXor);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(438, 281);
            this.MinimumSize = new System.Drawing.Size(438, 281);
            this.Name = "XorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacja XOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button btnXor;
        private Label label1;
    }
}