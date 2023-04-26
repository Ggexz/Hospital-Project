using Prj.Modules.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj.Modules.Login
{
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
            InitializeComponent();
        }

        private void LgnGirisButton_Click(object sender, EventArgs e)
        {
            ButtonEkrani frm = new ButtonEkrani();
            frm.Show();
            this.Hide();
        }
    }
}
