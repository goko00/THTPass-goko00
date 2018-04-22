using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödevler
{
    public partial class frmBildiri : Form
    {
        public frmBildiri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("goko00//Sosyal Medya Tim-THT");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 sifre = new Form3();
            sifre.Show();
            

        }
    }
}
