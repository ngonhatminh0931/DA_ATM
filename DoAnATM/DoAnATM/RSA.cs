using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DoAnATM
{
    public partial class RSA : Form
    {
        private delegate void btnEncryptDecrypt();

        private RSACryptoServiceProvider RSA_ = new RSACryptoServiceProvider();
        private string pathKeysXML = "";
        private bool isEncryptFile = true;


        public RSA()
        {
            InitializeComponent();
            btn_cal.Visible = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int p = (int)numericUpDown1.Value;
            int q = (int)numericUpDown2.Value;

            if (IsPrime(p) && IsPrime(q) && p != q)
            {
                btn_cal.Visible = true;
                MessageBox.Show("p và q hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn_cal.Visible = false;

                string errorMsg = "";
                if (!IsPrime(p)) errorMsg += "p không phải số nguyên tố. ";
                if (!IsPrime(q)) errorMsg += "q không phải số nguyên tố. ";
                if (p == q) errorMsg += "p và q phải khác nhau.";

                if (!string.IsNullOrEmpty(errorMsg))
                {
                    MessageBox.Show(errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            try
            {
                int p = (int)numericUpDown1.Value;
                int q = (int)numericUpDown2.Value;

                long n = (long)p * q;

                long phi_n = (long)(p - 1) * (q - 1);

                long mu_e = FindE(phi_n);

                long d = FindD(mu_e, phi_n);

                txt_n.Text = n.ToString();
                txt_phi_n.Text = phi_n.ToString();
                txt_e.Text = mu_e.ToString();
                txt_d.Text = d.ToString();
                txt_pubkey.Text = $"({mu_e}, {n})";
                txt_prikey.Text = $"({d}, {n})";

                MessageBox.Show("Tính toán hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tính toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long FindE(long phi_n)
        {
            long[] commonE = { 65537, 3, 17, 257 };

            foreach (long candidate in commonE)
            {
                if (candidate < phi_n && GCD(candidate, phi_n) == 1)
                {
                    return candidate;
                }
            }


            for (long e = 3; e < phi_n; e += 2)
            {
                if (GCD(e, phi_n) == 1)
                {
                    return e;
                }
            }

            throw new Exception("Không tìm được giá trị e phù hợp");
        }


        private long FindD(long e, long phi_n)
        {
            long[] result = ExtendedGCD(e, phi_n);
            long d = result[1];


            if (d < 0)
                d += phi_n;

            return d;
        }

        private long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private long[] ExtendedGCD(long a, long b)
        {
            if (b == 0)
                return new long[] { a, 1, 0 };

            long[] result = ExtendedGCD(b, a % b);
            long gcd = result[0];
            long x1 = result[1];
            long y1 = result[2];

            long x = y1;
            long y = x1 - (a / b) * y1;

            return new long[] { gcd, x, y };
        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_input_en.Text))
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu cần mã hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txt_e.Text) || string.IsNullOrEmpty(txt_n.Text))
                {
                    MessageBox.Show("Vui lòng tính toán khóa trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long mmh_e = long.Parse(txt_e.Text);
                long n = long.Parse(txt_n.Text);

                string plaintext = txt_input_en.Text;

                List<char> encryptedChars = new List<char>();
                List<string> encryptedNumbers = new List<string>(); 

                foreach (char c in plaintext)
                {
                    long m = (long)c;

                    if (m >= n)
                    {
                        MessageBox.Show($"Ký tự '{c}' (ASCII: {m}) lớn hơn n ({n}). Vui lòng chọn p, q lớn hơn!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    long ciphertext = ModPow(m, mmh_e, n);

                    encryptedChars.Add((char)ciphertext);
                    encryptedNumbers.Add(ciphertext.ToString()); 
                }

                txt_output_en.Text = new string(encryptedChars.ToArray());
                txt_output_en_chuoi.Text = string.Join(" ", encryptedNumbers); 

                MessageBox.Show("Mã hóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Thông tin khóa không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mã hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private long ModPow(long baseValue, long exponent, long modulus)
        {
            if (modulus == 1) return 0;

            long result = 1;
            baseValue = baseValue % modulus;

            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    result = (result * baseValue) % modulus;

                exponent = exponent >> 1;
                baseValue = (baseValue * baseValue) % modulus;
            }

            return result;
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_input_de.Text))
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu cần giải mã!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txt_d.Text) || string.IsNullOrEmpty(txt_n.Text))
                {
                    MessageBox.Show("Vui lòng tính toán khóa trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long d = long.Parse(txt_d.Text);
                long n = long.Parse(txt_n.Text);
                string input = txt_input_de.Text.Trim();

                List<char> decryptedChars = new List<char>();

                if (input.All(c => char.IsDigit(c) || char.IsWhiteSpace(c)))
                {
                    string[] parts = input.Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string part in parts)
                    {
                        if (long.TryParse(part, out long cipherNum))
                        {
                            long decryptedValue = ModPow(cipherNum, d, n);
                            if (decryptedValue >= 0 && decryptedValue <= 127)
                            {
                                decryptedChars.Add((char)decryptedValue);
                            }
                            else
                            {
                                MessageBox.Show($"Giá trị giải mã không hợp lệ: {decryptedValue}", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Không thể phân tích '{part}' thành số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    foreach (char encryptedChar in input)
                    {
                        long c = (long)encryptedChar;
                        long decryptedValue = ModPow(c, d, n);

                        if (decryptedValue >= 0 && decryptedValue <= 127)
                        {
                            decryptedChars.Add((char)decryptedValue);
                        }
                        else
                        {
                            MessageBox.Show($"Giá trị giải mã không hợp lệ: {decryptedValue}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                txt_output_de.Text = new string(decryptedChars.ToArray());
                MessageBox.Show("Giải mã thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu mã hóa hoặc thông tin khóa không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi giải mã: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxLengKey.Items.Add("512 bits");
            this.comboBoxLengKey.Items.Add("1024 bits");
            this.comboBoxLengKey.Items.Add("2048 bits");
            this.comboBoxLengKey.Items.Add("4096 bits");
            this.tbN.Enabled = false;
            this.tbD.Enabled = false;
            this.tbE.Enabled = false;
            lbl_md5.Enabled = false;
            lbl_sha1.Enabled = false;
            lbl_sha256.Enabled = false;
            this.comboBoxLengKey.Text = "1024 bits";
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void enabledOrDisableButtons(bool isEnable)
        {
            this.tbOutput.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDecrypt.Enabled = isEnable;
            this.btnGenerateKey.Enabled = isEnable;
            this.btnOpenFileIn.Enabled = isEnable;
            this.btnOpenFileKeys.Enabled = isEnable;
            this.selectOutput.Enabled = isEnable;


        }
        
        private void btnOutOpen_Click(object sender, EventArgs e) 
        {
            if (tbOutput.Text.Length > 0)
            {
                try
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = tbOutput.Text;
                    prc.Start();
                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Failed: " + ioex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đường dẫn !");
            }
        }
        private void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read); 
                FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write); 
                fsCiperText.SetLength(0);
                byte[] bin, encryptedData;
                long rdlen = 0;
                long totlen = fsInput.Length;
                int len;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKeyInfo); 

                int maxBytesCanEncrypted;
              
                if (isEncrypt)
                    maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37;

                else
                    maxBytesCanEncrypted = (RSA.KeySize / 8);

                while (rdlen < totlen)
                {
                    if (totlen - rdlen < maxBytesCanEncrypted) maxBytesCanEncrypted = (int)(totlen - rdlen);
                    bin = new byte[maxBytesCanEncrypted];
                    len = fsInput.Read(bin, 0, maxBytesCanEncrypted);

                    if (isEncrypt) encryptedData = RSA.Encrypt(bin, false); 
                    else encryptedData = RSA.Decrypt(bin, false); 

                    fsCiperText.Write(encryptedData, 0, encryptedData.Length);
                    rdlen = rdlen + len;

                    this.progressBar1.Value = (int)((rdlen * 100) / totlen);
                }

                fsCiperText.Close(); 
                fsInput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }
        private void btnEncryptClick()
        {
            enabledOrDisableButtons(false);
            if (this.tbPathKeys.Text.Length == 0 || this.tbN.Text.Length == 0 || this.tbD.Text.Length == 0 || this.tbE.Text.Length == 0)
            {
                MessageBox.Show("Key không hợp lệ!");
                enabledOrDisableButtons(true);
                return;
            }

            try
            {
                if (tbInput.Text.Length != 0 &&
                tbPathKeys.Text.Length != 0 &&
                tbN.Text.Length != 0)
                {

                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    string inputFileName = tbInput.Text, outputFileName = "";

                    if (isEncryptFile)
                    {
                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(tbInput.Text) + ".lhde";
                    }

                    RSA_ = new RSACryptoServiceProvider();
                    RSA_.FromXmlString(File.ReadAllText(this.pathKeysXML));
                    if (isEncryptFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA_.ExportParameters(true), true);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*");

                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i]);
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                                RSA_Algorithm(filePaths[i], outputFileName + ".lhde", RSA_.ExportParameters(true), true);
                        }
                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Thời gian thực thi " + elapsedMs.ToString() + "s");
                }
                else
                {
                    enabledOrDisableButtons(true);
                    MessageBox.Show("Dữ liệu không đủ để mã hóa!");
                }
            }
            catch (Exception ex)
            {
                enabledOrDisableButtons(true);
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }

        private void btnDecryptClick()
        {
            enabledOrDisableButtons(false);

            try
            {
                if (tbInput.Text.Length != 0 &&
                   tbPathKeys.Text.Length != 0 &&
                   tbN.Text.Length != 0)
                {
                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = tbInput.Text, outputFileName = "";

                    if (isEncryptFile && Path.GetExtension(inputFileName) != ".lhde")
                    {
                        MessageBox.Show("Tệp tin này không được hỗ trợ đển giải mã!");
                        enabledOrDisableButtons(true);
                        return;
                    }

                    if (isEncryptFile)
                    {

                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(inputFileName.Substring(0, inputFileName.Length - 5));


                    }

                    RSA_ = new RSACryptoServiceProvider();
                    RSA_.FromXmlString(File.ReadAllText(this.pathKeysXML));

                    if (isEncryptFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA_.ExportParameters(true), false);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.lhde", SearchOption.AllDirectories);
                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            {
                                outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i].Substring(0, filePaths[i].Length - 5));
                                RSA_Algorithm(filePaths[i], outputFileName, RSA_.ExportParameters(true), false);

                            }

                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Tổng thời gian thực thi: " + elapsedMs.ToString() + "s");
                }
                else
                {
                    MessageBox.Show("Không đủ điều kiện để giải mã !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }


        public static string MD5(string path)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        public static string SHA1(string path)
        {
            using (var cryptoProvider = new SHA1CryptoServiceProvider())
            {
                var stream = File.OpenRead(path);
                string hash = BitConverter
                    .ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "");
                return hash.ToLower();
            }
        }

        public static string SHA256(string path)
        {
            using (FileStream stream = File.OpenRead(path))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Xml File|*.xml|All File|*.*";
            saveFileDialog1.Title = "Save an Xml File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGenerateKey_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxLengKey.Text))
            {
                MessageBox.Show("Vui lòng thêm độ dài khóa.", "Nhập độ dài khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.Filter = "Xml File|*.xml|All File|*.*";
                saveFileDialog1.Title = "Chọn tên file";
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                int lengthKey = 0;
                if (this.comboBoxLengKey.Text == "1024 bits") lengthKey = 1024;
                else if (this.comboBoxLengKey.Text == "512 bits") lengthKey = 512;
                else if (this.comboBoxLengKey.Text == "2048 bits") lengthKey = 2048;
                else if (this.comboBoxLengKey.Text == "4096 bits") lengthKey = 4096;
                saveFileDialog1.RestoreDirectory = true;
                String pathPrivateKey = saveFileDialog1.FileName;

                RSA_ = new RSACryptoServiceProvider(lengthKey); 


                File.WriteAllText(pathPrivateKey, RSA_.ToXmlString(true));  
                pathKeysXML = pathPrivateKey;
                tbPathKeys.Text = pathPrivateKey; 

                if (File.Exists(pathKeysXML))
                {
                    if (Path.GetExtension(pathKeysXML) == ".xml") 
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.LoadXml(File.ReadAllText(pathKeysXML)); 
                        try
                        {
                            XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                            tbN.Text = xnList.InnerText;
                            xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                            tbE.Text = xnList.InnerText;
                            xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                            tbD.Text = xnList.InnerText;
                            tbN.Enabled = true;
                            tbE.Enabled = true;
                            tbD.Enabled = true;
                        }
                        catch (Exception ix)
                        {
                            MessageBox.Show(ix.Message);
                        }
                    }
                }
                MessageBox.Show("Tạo key có độ dài " + lengthKey.ToString() + " bits thành công.");
            }
        }

        private void btnOpenFileKeys_Click_1(object sender, EventArgs e)
        {
            this.tbD.Clear(); this.tbE.Clear(); this.tbN.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pathKeysXML = op.FileName;
                tbPathKeys.Text = op.FileName;
            }

            if (File.Exists(pathKeysXML))
            {

                if (Path.GetExtension(pathKeysXML) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXML));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        tbN.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        tbE.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbN.Enabled = true;
                        tbE.Enabled = true;
                        tbD.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnOpenFileIn_Click_1(object sender, EventArgs e)
        {
            isEncryptFile = true;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                tbInput.Text = op.FileName;
        }

        private void selectOutput_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                this.tbOutput.Text = f1.SelectedPath;
            }
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            if (tbPathKeys.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến Key!");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnEncryptClick);
            s.BeginInvoke(null, null);
        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnDecryptClick);
            s.BeginInvoke(null, null);
        }

        private void btn_chonfile_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txt_input.Text = dialog.FileName;
                }
            }
        }

        private void btn_checksum_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_input.Text))
            {
                MessageBox.Show("Vui lòng thêm đường dẫn đến file cần kiểm tra.", "Thiếu đường dẫn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lbl_md5.Text = MD5(txt_input.Text);
            lbl_sha1.Text = SHA1(txt_input.Text);
            lbl_sha256.Text = SHA256(txt_input.Text);
            lbl_md5.Enabled = true;
            lbl_sha1.Enabled = true;
            lbl_sha256.Enabled = true;
        }
    }
}

