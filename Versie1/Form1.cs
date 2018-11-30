using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Business bus = new Business();

        private void Form1_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            lstAankopen.Items.Clear();

            foreach (string lijn in bus.getAankopen())
            {
                lstAankopen.Items.Add(lijn);
            }
        }

        private void btnKnop_Click(object sender, EventArgs e)
        {
            bus.voegToe(Convert.ToDouble(txtPrijs.Text), Convert.ToInt32(txtAantal.Text), txtVoorwerp.Text);
            vulForm();
        }
    }
}
