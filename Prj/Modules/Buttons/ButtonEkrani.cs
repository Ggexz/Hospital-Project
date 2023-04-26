using Prj.Modules.HastaKabul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj.Modules.Buttons
{
    public partial class ButtonEkrani : Form
    {
        public ButtonEkrani()
        {
            InitializeComponent();
        }

        private void BttnEkrnHastaBilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileri frm = new HastaBilgileri();
            frm.Show();
        }
    }
}
