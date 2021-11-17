using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace quan_li_diem_sinh_vien
{
    public partial class Xrpt_BAOCAO_DSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BAOCAO_DSLTC()
        {
            
        }
        public Xrpt_BAOCAO_DSLTC(string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = int.Parse(nienkhoa.Substring(0, 4));
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();

        }
    }
}
