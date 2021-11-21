using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace quan_li_diem_sinh_vien
{
    public partial class Xrpt_BAOCAO_PHIEUDIEM : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BAOCAO_PHIEUDIEM()
        {
            
        }
        public Xrpt_BAOCAO_PHIEUDIEM(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }
    }
}
