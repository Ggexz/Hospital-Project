using Prj.Data;
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

namespace Prj.Modules.HastaKabul
{
    public partial class HastaBilgileri : Form
    {
        HospitalEntities hs = new HospitalEntities();
        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void HastaListeleBttn_Click(object sender, EventArgs e)
        {
            HstGrid1.DataSource = hs.Hasta.ToList();
        }

        private void HastaProtokolBttn_Click(object sender, EventArgs e)
        {
            HastaProtokol frm = new HastaProtokol();
            frm.Show();
        }

        private void HstGrid1_Click(object sender, EventArgs e)
        {
            
        }
        private void HstGrid1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            HastaProtokol hs = new HastaProtokol();
        }
    }
}
