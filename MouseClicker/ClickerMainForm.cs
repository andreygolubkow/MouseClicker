using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class ClickerMainForm : Form
    {
        private Project pointProject;
        public ClickerMainForm()
        {
            InitializeComponent();
            pointProject = new Project();
            mousePointBindingSource.DataSource = pointProject.PointsList;
        }

        private void ClickerMainFormLoad(object sender, EventArgs e)
        {
            
        }

        private void AddPointMenuItemClick(object sender, EventArgs e)
        {
            Point curPoint = Cursor.Position;
            mousePointBindingSource.Add(new MousePoint(curPoint, 1));
            mousePointBindingSource.MoveLast();
        }

        private void removePointMenuItem_Click(object sender, EventArgs e)
        {

            mousePointBindingSource.RemoveCurrent();
        }
    }
}
