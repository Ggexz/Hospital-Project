using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Prj.Data;
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
    
    public partial class HastaProtokol : Form
    {
        HospitalEntities hs = new HospitalEntities();
        
        public HastaProtokol()
        {
            InitializeComponent();
            lookUpEditDoktor.CascadingOwner = lookUpEditBolum;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void HastaProtokol_Load(object sender, EventArgs e)
        {
            InitLookup();
            InitLookups();
        }
        private void InitLookup()
        {
            InitLookupEdit(lookUpEditBolum, "Id", "Adi", "Bos satir ");
            lookUpEditBolum.Properties.DataSource = hs.OrtakBolum.ToList();
        }



        public static void InitLookupEdit(LookUpEdit lookUpEdit, string valueMember, string displayMember, string nullText)
        {
            lookUpEdit.Properties.ValueMember = valueMember;
            lookUpEdit.Properties.DisplayMember = displayMember;



            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.Columns.AddRange(new LookUpColumnInfo[] {
            new LookUpColumnInfo(lookUpEdit.Properties.ValueMember, "", 5,
            DevExpress.Utils.FormatType.None, "", false,
            DevExpress.Utils.HorzAlignment.Default,
            DevExpress.Data.ColumnSortOrder.None),
            new LookUpColumnInfo(lookUpEdit.Properties.DisplayMember)});



            lookUpEdit.Properties.ShowHeader = false;
            lookUpEdit.Properties.ShowFooter = false;
            lookUpEdit.Properties.NullText = nullText;



            //lookUpEdit.ButtonClick += new ButtonPressedEventHandler(lookUpEdit_ButtonClick);
        }
        private void InitLookups()
        {
            InitLookupEdits(lookUpEditDoktor, "Id", "Adi", "Bos satir ");
            lookUpEditDoktor.Properties.DataSource = hs.IKPersonel.ToList();
        }



        public static void InitLookupEdits(LookUpEdit lookUpEdit, string valueMember, string displayMember, string nullText)
        {
            lookUpEdit.Properties.ValueMember = valueMember;
            lookUpEdit.Properties.DisplayMember = displayMember;



            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.Columns.AddRange(new LookUpColumnInfo[] {
            new LookUpColumnInfo(lookUpEdit.Properties.ValueMember, "", 5,
            DevExpress.Utils.FormatType.None, "", false,
            DevExpress.Utils.HorzAlignment.Default,
            DevExpress.Data.ColumnSortOrder.None),
            new LookUpColumnInfo(lookUpEdit.Properties.DisplayMember)});



            lookUpEdit.Properties.ShowHeader = false;
            lookUpEdit.Properties.ShowFooter = false;
            lookUpEdit.Properties.NullText = nullText;



            //lookUpEdit.ButtonClick += new ButtonPressedEventHandler(lookUpEdit_ButtonClick);
        }

        private void lookUpEditDoktor_EditValueChanged(object sender, EventArgs e)
        {
 
         
        }

        private void lookUpEditBolum_EditValueChanged(object sender, EventArgs e)
        {
            lookUpEditDoktor.EditValue = null;
            

        }
    }
}
