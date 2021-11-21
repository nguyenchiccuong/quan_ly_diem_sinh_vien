using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace quan_li_diem_sinh_vien
{
    public partial class Xrpt_BAOCAO_DSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BAOCAO_DSSV()
        {
            
        }
        public Xrpt_BAOCAO_DSSV(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
        }
    }
}
