
namespace Hangman
{
    partial class MenuForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.allatokButton = new System.Windows.Forms.Button();
            this.orszagokButton = new System.Windows.Forms.Button();
            this.sportButton = new System.Windows.Forms.Button();
            this.ruhazatButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "AKASZTÓFA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategóriák";
            // 
            // allatokButton
            // 
            this.allatokButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allatokButton.Location = new System.Drawing.Point(227, 90);
            this.allatokButton.Name = "allatokButton";
            this.allatokButton.Size = new System.Drawing.Size(109, 96);
            this.allatokButton.TabIndex = 5;
            this.allatokButton.Text = "Állatok";
            this.allatokButton.UseVisualStyleBackColor = true;
            this.allatokButton.Click += new System.EventHandler(this.allatokButton_Click);
            // 
            // orszagokButton
            // 
            this.orszagokButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orszagokButton.Location = new System.Drawing.Point(342, 90);
            this.orszagokButton.Name = "orszagokButton";
            this.orszagokButton.Size = new System.Drawing.Size(109, 96);
            this.orszagokButton.TabIndex = 6;
            this.orszagokButton.Text = "Országok";
            this.orszagokButton.UseVisualStyleBackColor = true;
            this.orszagokButton.Click += new System.EventHandler(this.orszagokButton_Click);
            // 
            // sportButton
            // 
            this.sportButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportButton.Location = new System.Drawing.Point(227, 192);
            this.sportButton.Name = "sportButton";
            this.sportButton.Size = new System.Drawing.Size(109, 96);
            this.sportButton.TabIndex = 7;
            this.sportButton.Text = "Sport";
            this.sportButton.UseVisualStyleBackColor = true;
            this.sportButton.Click += new System.EventHandler(this.sportButton_Click);
            // 
            // ruhazatButton
            // 
            this.ruhazatButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruhazatButton.Location = new System.Drawing.Point(342, 192);
            this.ruhazatButton.Name = "ruhazatButton";
            this.ruhazatButton.Size = new System.Drawing.Size(109, 96);
            this.ruhazatButton.TabIndex = 8;
            this.ruhazatButton.Text = "Ruházat";
            this.ruhazatButton.UseVisualStyleBackColor = true;
            this.ruhazatButton.Click += new System.EventHandler(this.ruhazatButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "A szavak angolul vannak!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "FIGYELEM!";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ruhazatButton);
            this.Controls.Add(this.sportButton);
            this.Controls.Add(this.orszagokButton);
            this.Controls.Add(this.allatokButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akasztófa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allatokButton;
        private System.Windows.Forms.Button orszagokButton;
        private System.Windows.Forms.Button sportButton;
        private System.Windows.Forms.Button ruhazatButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}