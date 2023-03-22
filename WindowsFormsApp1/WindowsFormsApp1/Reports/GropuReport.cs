using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reports
{
    public partial class GropuReport : Form
    {
        public GropuReport()
        {
            InitializeComponent();
        }

        private void GropuReport_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Courses", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Courses");
                    da.SelectCommand.CommandText = "SELECT * FROM CourseModules";
                    da.Fill(ds, "CourseModules");
                    da.SelectCommand.CommandText = "SELECT * FROM Modules";
                    da.Fill(ds, "Modules");
                    CrystalReport1 rpt =new CrystalReport1();
                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource= rpt;
                    crystalReportViewer1.Refresh();

                }
            }
        }
    }
}
