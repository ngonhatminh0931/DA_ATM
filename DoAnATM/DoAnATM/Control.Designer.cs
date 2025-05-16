namespace DoAnATM
{
    partial class Control
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
            this.label_Tittle = new System.Windows.Forms.Label();
            this.button_Flayfair = new System.Windows.Forms.Button();
            this.button_RSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.Location = new System.Drawing.Point(100, 47);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(618, 45);
            this.label_Tittle.TabIndex = 0;
            this.label_Tittle.Text = "Computer network security project";
            // 
            // button_Flayfair
            // 
            this.button_Flayfair.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Flayfair.Location = new System.Drawing.Point(108, 134);
            this.button_Flayfair.Name = "button_Flayfair";
            this.button_Flayfair.Size = new System.Drawing.Size(610, 72);
            this.button_Flayfair.TabIndex = 1;
            this.button_Flayfair.Text = "Flayfair";
            this.button_Flayfair.UseVisualStyleBackColor = true;
            this.button_Flayfair.Click += new System.EventHandler(this.button_Flayfair_Click);
            // 
            // button_RSA
            // 
            this.button_RSA.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RSA.Location = new System.Drawing.Point(108, 245);
            this.button_RSA.Name = "button_RSA";
            this.button_RSA.Size = new System.Drawing.Size(610, 72);
            this.button_RSA.TabIndex = 2;
            this.button_RSA.Text = "RSA";
            this.button_RSA.UseVisualStyleBackColor = true;
            this.button_RSA.Click += new System.EventHandler(this.button_RSA_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 379);
            this.Controls.Add(this.button_RSA);
            this.Controls.Add(this.button_Flayfair);
            this.Controls.Add(this.label_Tittle);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.Button button_Flayfair;
        private System.Windows.Forms.Button button_RSA;
    }
}