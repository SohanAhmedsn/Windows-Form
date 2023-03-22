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

namespace WindowsFormsApp1.CourseModules
{
    public partial class CourseModulesView : Form
    {
        public CourseModulesView()
        {
            InitializeComponent();
        }

        private void CourseModulesView_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CourseModules", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);



                    this.dataGridView1.DataSource = dt;

                }
            }
        }
    }
}
