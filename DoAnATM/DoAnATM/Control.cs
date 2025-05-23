using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnATM
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button_Flayfair_Click(object sender, EventArgs e)
        {
            Form form = new Playfair();
            form.Show();
        }

        private void button_RSA_Click(object sender, EventArgs e)
        {
            Form form = new RSA();
            form.Show();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null; 
        }


    }
}
