using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CourseModules;
using WindowsFormsApp1.Courses;
using WindowsFormsApp1.Modules;
using WindowsFormsApp1.Reports;
using WindowsFormsApp1.Trainees;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraineeView { MdiParent = this }.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new TraineeAdd { MdiParent = this }.Show();
        }

        private void editdeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraineeEdit { MdiParent = this }.Show();
        }

        private void corrseViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModulesView { MdiParent=this}.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModulesAdd { MdiParent = this }.Show();
        }

        private void editDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModuleEdit { MdiParent = this }.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CoursesView { MdiParent = this }.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new CoursesAdd { MdiParent = this }.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new CourseModulesAdd { MdiParent=this }.Show();
        }

        private void editDeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new CourseEdit { MdiParent=this }.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new CourseModulesView { MdiParent = this }.Show();
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GropuReport { MdiParent=this }.Show();
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImageReport { MdiParent = this }.Show();
        }
    }
}
