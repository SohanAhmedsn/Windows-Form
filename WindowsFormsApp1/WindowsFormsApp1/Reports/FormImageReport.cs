using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reports
{
    public partial class FormImageReport : Form
    {
        public FormImageReport()
        {
            InitializeComponent();
        }

        private void FormImageReport_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Trainees", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Trainees1");
                    ds.Tables["Trainees1"].Columns.Add(new DataColumn("image", typeof(System.Byte[])));
                    var dt = ds.Tables["Trainees1"];
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["image"] = File.ReadAllBytes(Path.Combine(Path.GetFullPath(@"..\..\Pictures"), dt.Rows[i]["Picture"].ToString()));
                    }
                    CrystalReport2 rpt = new CrystalReport2();
                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                    crystalReportViewer1.Refresh();
                }
            }
        }
    }
}
