namespace DoAnATM
{
    partial class RSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_Decryption = new System.Windows.Forms.GroupBox();
            this.btn_de = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_output_de = new System.Windows.Forms.TextBox();
            this.label_input_de = new System.Windows.Forms.Label();
            this.txt_input_de = new System.Windows.Forms.TextBox();
            this.groupBox_Encryption = new System.Windows.Forms.GroupBox();
            this.txt_output_en_chuoi = new System.Windows.Forms.TextBox();
            this.btn_en = new System.Windows.Forms.Button();
            this.label_output_en = new System.Windows.Forms.Label();
            this.label_input_en = new System.Windows.Forms.Label();
            this.txt_input_en = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_prikey = new System.Windows.Forms.TextBox();
            this.label_private_key = new System.Windows.Forms.Label();
            this.txt_pubkey = new System.Windows.Forms.TextBox();
            this.label_public_key = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.label_d = new System.Windows.Forms.Label();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.label_e = new System.Windows.Forms.Label();
            this.txt_phi_n = new System.Windows.Forms.TextBox();
            this.label_phi_n = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_p = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_sha256 = new System.Windows.Forms.TextBox();
            this.lable12 = new System.Windows.Forms.Label();
            this.lbl_sha1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_md5 = new System.Windows.Forms.TextBox();
            this.btn_chonfile = new System.Windows.Forms.Button();
            this.btn_checksum = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbD = new System.Windows.Forms.TextBox();
            this.Module = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenFileKeys = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPathKeys = new System.Windows.Forms.TextBox();
            this.comboBoxLengKey = new System.Windows.Forms.ComboBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Decryption.SuspendLayout();
            this.groupBox_Encryption.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1580, 946);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::DoAnATM.Properties.Resources.Blue_Black_Tech_Modern_Cyber_Security_Presentation;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox_Decryption);
            this.tabPage1.Controls.Add(this.groupBox_Encryption);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1572, 909);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Decryption
            // 
            this.groupBox_Decryption.Controls.Add(this.btn_de);
            this.groupBox_Decryption.Controls.Add(this.label2);
            this.groupBox_Decryption.Controls.Add(this.txt_output_de);
            this.groupBox_Decryption.Controls.Add(this.label_input_de);
            this.groupBox_Decryption.Controls.Add(this.txt_input_de);
            this.groupBox_Decryption.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Decryption.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox_Decryption.Location = new System.Drawing.Point(808, 502);
            this.groupBox_Decryption.Name = "groupBox_Decryption";
            this.groupBox_Decryption.Size = new System.Drawing.Size(740, 389);
            this.groupBox_Decryption.TabIndex = 5;
            this.groupBox_Decryption.TabStop = false;
            this.groupBox_Decryption.Text = "Decryption";
            // 
            // btn_de
            // 
            this.btn_de.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_de.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_de.Location = new System.Drawing.Point(116, 114);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(592, 75);
            this.btn_de.TabIndex = 13;
            this.btn_de.Text = "Decryption";
            this.btn_de.UseVisualStyleBackColor = true;
            this.btn_de.Click += new System.EventHandler(this.btn_de_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(-2, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output";
            // 
            // txt_output_de
            // 
            this.txt_output_de.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output_de.Location = new System.Drawing.Point(116, 283);
            this.txt_output_de.Name = "txt_output_de";
            this.txt_output_de.Size = new System.Drawing.Size(592, 38);
            this.txt_output_de.TabIndex = 11;
            // 
            // label_input_de
            // 
            this.label_input_de.AutoSize = true;
            this.label_input_de.BackColor = System.Drawing.Color.Transparent;
            this.label_input_de.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_input_de.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label_input_de.Location = new System.Drawing.Point(-2, 57);
            this.label_input_de.Name = "label_input_de";
            this.label_input_de.Size = new System.Drawing.Size(80, 31);
            this.label_input_de.TabIndex = 10;
            this.label_input_de.Text = "Input";
            // 
            // txt_input_de
            // 
            this.txt_input_de.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_de.Location = new System.Drawing.Point(116, 57);
            this.txt_input_de.Name = "txt_input_de";
            this.txt_input_de.Size = new System.Drawing.Size(592, 38);
            this.txt_input_de.TabIndex = 9;
            // 
            // groupBox_Encryption
            // 
            this.groupBox_Encryption.Controls.Add(this.txt_output_en_chuoi);
            this.groupBox_Encryption.Controls.Add(this.btn_en);
            this.groupBox_Encryption.Controls.Add(this.label_output_en);
            this.groupBox_Encryption.Controls.Add(this.label_input_en);
            this.groupBox_Encryption.Controls.Add(this.txt_input_en);
            this.groupBox_Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox_Encryption.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox_Encryption.Location = new System.Drawing.Point(12, 502);
            this.groupBox_Encryption.Name = "groupBox_Encryption";
            this.groupBox_Encryption.Size = new System.Drawing.Size(757, 389);
            this.groupBox_Encryption.TabIndex = 4;
            this.groupBox_Encryption.TabStop = false;
            this.groupBox_Encryption.Text = "Encryption";
            // 
            // txt_output_en_chuoi
            // 
            this.txt_output_en_chuoi.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output_en_chuoi.Location = new System.Drawing.Point(122, 286);
            this.txt_output_en_chuoi.Name = "txt_output_en_chuoi";
            this.txt_output_en_chuoi.Size = new System.Drawing.Size(601, 38);
            this.txt_output_en_chuoi.TabIndex = 9;
            // 
            // btn_en
            // 
            this.btn_en.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_en.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_en.Location = new System.Drawing.Point(122, 125);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(601, 75);
            this.btn_en.TabIndex = 8;
            this.btn_en.Text = "Encryption";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // label_output_en
            // 
            this.label_output_en.AutoSize = true;
            this.label_output_en.BackColor = System.Drawing.Color.Transparent;
            this.label_output_en.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_en.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label_output_en.Location = new System.Drawing.Point(6, 285);
            this.label_output_en.Name = "label_output_en";
            this.label_output_en.Size = new System.Drawing.Size(102, 31);
            this.label_output_en.TabIndex = 6;
            this.label_output_en.Text = "Output";
            // 
            // label_input_en
            // 
            this.label_input_en.AutoSize = true;
            this.label_input_en.BackColor = System.Drawing.Color.Transparent;
            this.label_input_en.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_input_en.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label_input_en.Location = new System.Drawing.Point(6, 68);
            this.label_input_en.Name = "label_input_en";
            this.label_input_en.Size = new System.Drawing.Size(80, 31);
            this.label_input_en.TabIndex = 4;
            this.label_input_en.Text = "Input";
            // 
            // txt_input_en
            // 
            this.txt_input_en.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_en.Location = new System.Drawing.Point(122, 68);
            this.txt_input_en.Name = "txt_input_en";
            this.txt_input_en.Size = new System.Drawing.Size(601, 38);
            this.txt_input_en.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_prikey);
            this.groupBox5.Controls.Add(this.label_private_key);
            this.groupBox5.Controls.Add(this.txt_pubkey);
            this.groupBox5.Controls.Add(this.label_public_key);
            this.groupBox5.Controls.Add(this.txt_d);
            this.groupBox5.Controls.Add(this.label_d);
            this.groupBox5.Controls.Add(this.txt_e);
            this.groupBox5.Controls.Add(this.label_e);
            this.groupBox5.Controls.Add(this.txt_phi_n);
            this.groupBox5.Controls.Add(this.label_phi_n);
            this.groupBox5.Controls.Add(this.txt_n);
            this.groupBox5.Controls.Add(this.label_n);
            this.groupBox5.Controls.Add(this.btn_cal);
            this.groupBox5.Controls.Add(this.btn_check);
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label_p);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox5.Location = new System.Drawing.Point(12, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1536, 459);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Key Generation";
            // 
            // txt_prikey
            // 
            this.txt_prikey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_prikey.ForeColor = System.Drawing.Color.Black;
            this.txt_prikey.Location = new System.Drawing.Point(1122, 387);
            this.txt_prikey.Name = "txt_prikey";
            this.txt_prikey.ReadOnly = true;
            this.txt_prikey.Size = new System.Drawing.Size(300, 34);
            this.txt_prikey.TabIndex = 20;
            // 
            // label_private_key
            // 
            this.label_private_key.AutoSize = true;
            this.label_private_key.BackColor = System.Drawing.Color.Transparent;
            this.label_private_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_private_key.ForeColor = System.Drawing.Color.Aqua;
            this.label_private_key.Location = new System.Drawing.Point(877, 389);
            this.label_private_key.Name = "label_private_key";
            this.label_private_key.Size = new System.Drawing.Size(202, 29);
            this.label_private_key.TabIndex = 19;
            this.label_private_key.Text = "Private key (d,n)";
            // 
            // txt_pubkey
            // 
            this.txt_pubkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_pubkey.ForeColor = System.Drawing.Color.Black;
            this.txt_pubkey.Location = new System.Drawing.Point(1122, 318);
            this.txt_pubkey.Name = "txt_pubkey";
            this.txt_pubkey.ReadOnly = true;
            this.txt_pubkey.Size = new System.Drawing.Size(300, 34);
            this.txt_pubkey.TabIndex = 18;
            // 
            // label_public_key
            // 
            this.label_public_key.AutoSize = true;
            this.label_public_key.BackColor = System.Drawing.Color.Transparent;
            this.label_public_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_public_key.ForeColor = System.Drawing.Color.Aqua;
            this.label_public_key.Location = new System.Drawing.Point(881, 319);
            this.label_public_key.Name = "label_public_key";
            this.label_public_key.Size = new System.Drawing.Size(194, 29);
            this.label_public_key.TabIndex = 17;
            this.label_public_key.Text = "Public key (e,n)";
            // 
            // txt_d
            // 
            this.txt_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_d.ForeColor = System.Drawing.Color.Black;
            this.txt_d.Location = new System.Drawing.Point(1122, 249);
            this.txt_d.Name = "txt_d";
            this.txt_d.ReadOnly = true;
            this.txt_d.Size = new System.Drawing.Size(300, 34);
            this.txt_d.TabIndex = 16;
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.BackColor = System.Drawing.Color.Transparent;
            this.label_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_d.ForeColor = System.Drawing.Color.Aqua;
            this.label_d.Location = new System.Drawing.Point(1027, 249);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(28, 29);
            this.label_d.TabIndex = 15;
            this.label_d.Text = "d";
            // 
            // txt_e
            // 
            this.txt_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_e.ForeColor = System.Drawing.Color.Black;
            this.txt_e.Location = new System.Drawing.Point(1122, 180);
            this.txt_e.Name = "txt_e";
            this.txt_e.ReadOnly = true;
            this.txt_e.Size = new System.Drawing.Size(300, 34);
            this.txt_e.TabIndex = 14;
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.BackColor = System.Drawing.Color.Transparent;
            this.label_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_e.ForeColor = System.Drawing.Color.Aqua;
            this.label_e.Location = new System.Drawing.Point(1027, 179);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(28, 29);
            this.label_e.TabIndex = 13;
            this.label_e.Text = "e";
            // 
            // txt_phi_n
            // 
            this.txt_phi_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_phi_n.ForeColor = System.Drawing.Color.Black;
            this.txt_phi_n.Location = new System.Drawing.Point(1122, 111);
            this.txt_phi_n.Name = "txt_phi_n";
            this.txt_phi_n.ReadOnly = true;
            this.txt_phi_n.Size = new System.Drawing.Size(300, 34);
            this.txt_phi_n.TabIndex = 12;
            // 
            // label_phi_n
            // 
            this.label_phi_n.AutoSize = true;
            this.label_phi_n.BackColor = System.Drawing.Color.Transparent;
            this.label_phi_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_phi_n.ForeColor = System.Drawing.Color.Aqua;
            this.label_phi_n.Location = new System.Drawing.Point(1027, 109);
            this.label_phi_n.Name = "label_phi_n";
            this.label_phi_n.Size = new System.Drawing.Size(62, 29);
            this.label_phi_n.TabIndex = 11;
            this.label_phi_n.Text = "φ(n)";
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_n.ForeColor = System.Drawing.Color.Black;
            this.txt_n.Location = new System.Drawing.Point(1122, 42);
            this.txt_n.Name = "txt_n";
            this.txt_n.ReadOnly = true;
            this.txt_n.Size = new System.Drawing.Size(300, 34);
            this.txt_n.TabIndex = 10;
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.BackColor = System.Drawing.Color.Transparent;
            this.label_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_n.ForeColor = System.Drawing.Color.Aqua;
            this.label_n.Location = new System.Drawing.Point(1027, 39);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(27, 29);
            this.label_n.TabIndex = 9;
            this.label_n.Text = "n";
            // 
            // btn_cal
            // 
            this.btn_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cal.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_cal.Location = new System.Drawing.Point(14, 321);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(272, 75);
            this.btn_cal.TabIndex = 8;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_check.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_check.Location = new System.Drawing.Point(14, 218);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(272, 75);
            this.btn_check.TabIndex = 7;
            this.btn_check.Text = "Check p and q";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Location = new System.Drawing.Point(191, 134);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(203, 34);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(191, 73);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(203, 34);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose q";
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.BackColor = System.Drawing.Color.Transparent;
            this.label_p.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_p.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label_p.Location = new System.Drawing.Point(6, 66);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(127, 31);
            this.label_p.TabIndex = 3;
            this.label_p.Text = "Choose p";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::DoAnATM.Properties.Resources.Blue_Black_Tech_Modern_Cyber_Security_Presentation;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1572, 909);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_sha256);
            this.groupBox6.Controls.Add(this.lable12);
            this.groupBox6.Controls.Add(this.lbl_sha1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_input);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.lbl_md5);
            this.groupBox6.Controls.Add(this.btn_chonfile);
            this.groupBox6.Controls.Add(this.btn_checksum);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox6.Location = new System.Drawing.Point(777, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(776, 465);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Checksum";
            // 
            // lbl_sha256
            // 
            this.lbl_sha256.Location = new System.Drawing.Point(214, 378);
            this.lbl_sha256.Margin = new System.Windows.Forms.Padding(6);
            this.lbl_sha256.Name = "lbl_sha256";
            this.lbl_sha256.Size = new System.Drawing.Size(553, 39);
            this.lbl_sha256.TabIndex = 10;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Location = new System.Drawing.Point(49, 383);
            this.lable12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(135, 32);
            this.lable12.TabIndex = 7;
            this.lable12.Text = "SHA256:";
            // 
            // lbl_sha1
            // 
            this.lbl_sha1.Location = new System.Drawing.Point(214, 310);
            this.lbl_sha1.Margin = new System.Windows.Forms.Padding(6);
            this.lbl_sha1.Name = "lbl_sha1";
            this.lbl_sha1.Size = new System.Drawing.Size(553, 39);
            this.lbl_sha1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "File: ";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(114, 55);
            this.txt_input.Margin = new System.Windows.Forms.Padding(6);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(503, 39);
            this.txt_input.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 315);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 32);
            this.label11.TabIndex = 6;
            this.label11.Text = "SHA1:";
            // 
            // lbl_md5
            // 
            this.lbl_md5.Location = new System.Drawing.Point(214, 241);
            this.lbl_md5.Margin = new System.Windows.Forms.Padding(6);
            this.lbl_md5.Name = "lbl_md5";
            this.lbl_md5.Size = new System.Drawing.Size(553, 39);
            this.lbl_md5.TabIndex = 9;
            // 
            // btn_chonfile
            // 
            this.btn_chonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_chonfile.ForeColor = System.Drawing.Color.Black;
            this.btn_chonfile.Location = new System.Drawing.Point(629, 53);
            this.btn_chonfile.Margin = new System.Windows.Forms.Padding(6);
            this.btn_chonfile.Name = "btn_chonfile";
            this.btn_chonfile.Size = new System.Drawing.Size(138, 52);
            this.btn_chonfile.TabIndex = 2;
            this.btn_chonfile.Text = "Open File";
            this.btn_chonfile.UseVisualStyleBackColor = true;
            this.btn_chonfile.Click += new System.EventHandler(this.btn_chonfile_Click_1);
            // 
            // btn_checksum
            // 
            this.btn_checksum.ForeColor = System.Drawing.Color.Black;
            this.btn_checksum.Location = new System.Drawing.Point(327, 143);
            this.btn_checksum.Margin = new System.Windows.Forms.Padding(6);
            this.btn_checksum.Name = "btn_checksum";
            this.btn_checksum.Size = new System.Drawing.Size(211, 52);
            this.btn_checksum.TabIndex = 4;
            this.btn_checksum.Text = "Check";
            this.btn_checksum.UseVisualStyleBackColor = true;
            this.btn_checksum.Click += new System.EventHandler(this.btn_checksum_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 246);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "MD5:";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(734, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(8, 8);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbD);
            this.groupBox3.Controls.Add(this.Module);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbE);
            this.groupBox3.Controls.Add(this.tbN);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox3.Location = new System.Drawing.Point(777, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 255);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = " (D):";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(214, 184);
            this.tbD.Margin = new System.Windows.Forms.Padding(6);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(553, 39);
            this.tbD.TabIndex = 5;
            // 
            // Module
            // 
            this.Module.AutoSize = true;
            this.Module.Location = new System.Drawing.Point(31, 53);
            this.Module.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(172, 32);
            this.Module.TabIndex = 6;
            this.Module.Text = "Module (N):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 118);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 32);
            this.label15.TabIndex = 7;
            this.label15.Text = " (E):";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(214, 117);
            this.tbE.Margin = new System.Windows.Forms.Padding(6);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(553, 39);
            this.tbE.TabIndex = 4;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(214, 50);
            this.tbN.Margin = new System.Windows.Forms.Padding(6);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(553, 39);
            this.tbN.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectOutput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbOutput);
            this.groupBox2.Controls.Add(this.btnEncrypt);
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Controls.Add(this.btnOpenFileIn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox2.Location = new System.Drawing.Point(6, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 465);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption and Decryption";
            // 
            // selectOutput
            // 
            this.selectOutput.ForeColor = System.Drawing.Color.Black;
            this.selectOutput.Location = new System.Drawing.Point(566, 310);
            this.selectOutput.Margin = new System.Windows.Forms.Padding(6);
            this.selectOutput.Name = "selectOutput";
            this.selectOutput.Size = new System.Drawing.Size(170, 55);
            this.selectOutput.TabIndex = 15;
            this.selectOutput.Text = "Select Folder";
            this.selectOutput.UseVisualStyleBackColor = true;
            this.selectOutput.Click += new System.EventHandler(this.selectOutput_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 240);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(722, 42);
            this.progressBar1.TabIndex = 9;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(144, 53);
            this.tbInput.Margin = new System.Windows.Forms.Padding(6);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(592, 39);
            this.tbInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output: ";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(144, 380);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(6);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(592, 39);
            this.tbOutput.TabIndex = 7;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.Location = new System.Drawing.Point(67, 168);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(6);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(211, 52);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Location = new System.Drawing.Point(290, 167);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(6);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(203, 52);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click_1);
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileIn.Location = new System.Drawing.Point(584, 110);
            this.btnOpenFileIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(152, 53);
            this.btnOpenFileIn.TabIndex = 0;
            this.btnOpenFileIn.Text = "Select File";
            this.btnOpenFileIn.UseVisualStyleBackColor = true;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOpenFileKeys);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPathKeys);
            this.groupBox1.Controls.Add(this.comboBoxLengKey);
            this.groupBox1.Controls.Add(this.btnGenerateKey);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 289);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Genration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Length";
            // 
            // btnOpenFileKeys
            // 
            this.btnOpenFileKeys.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileKeys.Location = new System.Drawing.Point(542, 195);
            this.btnOpenFileKeys.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenFileKeys.Name = "btnOpenFileKeys";
            this.btnOpenFileKeys.Size = new System.Drawing.Size(194, 55);
            this.btnOpenFileKeys.TabIndex = 2;
            this.btnOpenFileKeys.Text = "Open";
            this.btnOpenFileKeys.UseVisualStyleBackColor = true;
            this.btnOpenFileKeys.Click += new System.EventHandler(this.btnOpenFileKeys_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Key (Xml):";
            // 
            // tbPathKeys
            // 
            this.tbPathKeys.Location = new System.Drawing.Point(235, 144);
            this.tbPathKeys.Margin = new System.Windows.Forms.Padding(6);
            this.tbPathKeys.Name = "tbPathKeys";
            this.tbPathKeys.Size = new System.Drawing.Size(501, 39);
            this.tbPathKeys.TabIndex = 1;
            // 
            // comboBoxLengKey
            // 
            this.comboBoxLengKey.FormattingEnabled = true;
            this.comboBoxLengKey.Items.AddRange(new object[] {
            "512 bits",
            "1024 bits",
            "2048 bits",
            "4096 bits"});
            this.comboBoxLengKey.Location = new System.Drawing.Point(202, 50);
            this.comboBoxLengKey.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxLengKey.Name = "comboBoxLengKey";
            this.comboBoxLengKey.Size = new System.Drawing.Size(173, 40);
            this.comboBoxLengKey.TabIndex = 5;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateKey.Location = new System.Drawing.Point(387, 46);
            this.btnGenerateKey.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(349, 63);
            this.btnGenerateKey.TabIndex = 3;
            this.btnGenerateKey.Text = "Genration";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click_1);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnATM.Properties.Resources.Blue_Black_Tech_Modern_Cyber_Security_Presentation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1616, 979);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSA";
            this.Text = "RSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Decryption.ResumeLayout(false);
            this.groupBox_Decryption.PerformLayout();
            this.groupBox_Encryption.ResumeLayout(false);
            this.groupBox_Encryption.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox_Decryption;
        private System.Windows.Forms.GroupBox groupBox_Encryption;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_prikey;
        private System.Windows.Forms.Label label_private_key;
        private System.Windows.Forms.TextBox txt_pubkey;
        private System.Windows.Forms.Label label_public_key;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.TextBox txt_phi_n;
        private System.Windows.Forms.Label label_phi_n;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Label label_output_en;
        private System.Windows.Forms.Label label_input_en;
        private System.Windows.Forms.TextBox txt_input_en;
        private System.Windows.Forms.Button btn_de;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_output_de;
        private System.Windows.Forms.Label label_input_de;
        private System.Windows.Forms.TextBox txt_input_de;
        private System.Windows.Forms.TextBox txt_output_en_chuoi;
        private System.Windows.Forms.TextBox lbl_sha1;
        private System.Windows.Forms.TextBox lbl_sha256;
        private System.Windows.Forms.TextBox lbl_md5;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_checksum;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_chonfile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button selectOutput;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFileIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLengKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnOpenFileKeys;
        private System.Windows.Forms.TextBox tbPathKeys;
        private System.Windows.Forms.Label Module;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}