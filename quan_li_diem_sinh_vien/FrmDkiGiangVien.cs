using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_diem_sinh_vien
{
    public partial class FrmDkiGiangVien : Form
    {
        public FrmDkiGiangVien()
        {
            InitializeComponent();
        }

        private void gIANG_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giangVienBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSGVDKC);

        }

        private void FrmDkiGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGVDKC.GIANG_VIEN' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.DSGVDKC.GIANG_VIEN);

        }
    }
}
