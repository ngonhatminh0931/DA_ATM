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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.label_Tittle = new System.Windows.Forms.Label();
            this.button_Flayfair = new System.Windows.Forms.Button();
            this.button_RSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.label_Tittle.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label_Tittle.Location = new System.Drawing.Point(138, 70);
            this.label_Tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(850, 62);
            this.label_Tittle.TabIndex = 0;
            this.label_Tittle.Text = "Computer network security project";
            // 
            // button_Flayfair
            // 
            this.button_Flayfair.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Flayfair.Location = new System.Drawing.Point(148, 201);
            this.button_Flayfair.Margin = new System.Windows.Forms.Padding(4);
            this.button_Flayfair.Name = "button_Flayfair";
            this.button_Flayfair.Size = new System.Drawing.Size(839, 108);
            this.button_Flayfair.TabIndex = 1;
            this.button_Flayfair.Text = "Playfair";
            this.button_Flayfair.UseVisualStyleBackColor = true;
            this.button_Flayfair.Click += new System.EventHandler(this.button_Flayfair_Click);
            // 
            // button_RSA
            // 
            this.button_RSA.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RSA.Location = new System.Drawing.Point(148, 368);
            this.button_RSA.Margin = new System.Windows.Forms.Padding(4);
            this.button_RSA.Name = "button_RSA";
            this.button_RSA.Size = new System.Drawing.Size(839, 108);
            this.button_RSA.TabIndex = 2;
            this.button_RSA.Text = "RSA";
            this.button_RSA.UseVisualStyleBackColor = true;
            this.button_RSA.Click += new System.EventHandler(this.button_RSA_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnATM.Properties.Resources.Blue_Black_Tech_Modern_Cyber_Security_Presentation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 687);
            this.Controls.Add(this.button_RSA);
            this.Controls.Add(this.button_Flayfair);
            this.Controls.Add(this.label_Tittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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