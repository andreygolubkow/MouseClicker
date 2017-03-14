using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class ClickerMainForm : Form
    {
        private Project pointProject;
        public ClickerMainForm()
        {
            InitializeComponent();
            try
            {
                pointProject = new Project();
                mousePointBindingSource.DataSource = pointProject.PointsList;
                statusLabel.Text = "";
            }
            catch (Exception exception)
            {
                statusLabel.Text = exception.Message;
            }
        }

        private void ClickerMainFormLoad(object sender, EventArgs e)
        {
            
        }

        private void AddPointMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                Point curPoint = Cursor.Position;
                mousePointBindingSource.Add(new MousePoint(curPoint, 1));
                mousePointBindingSource.MoveLast();
            }
            catch (Exception exception)
            {
                statusLabel.Text = exception.Message;
            }
        }

        private void RemovePointMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                mousePointBindingSource.RemoveCurrent();
                statusLabel.Text = "";
            }
            catch ( Exception exception )
            {
                statusLabel.Text = exception.Message;
            }
        }

        private void RepeatMenuItemClick(object sender, EventArgs e)
        {
            pointProject.Repeat = repeatMenuItem.Checked;
            if ( pointProject.Repeat )
            {
                intervalTextBox.TextBox.Text = "1000";
                statusLabel.Text = "Не забудьте указать интервал(в мс.) в следующем поле, после кнопки.";
            }
        }

        private void IntervalTextBoxKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void intervalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.IntEnterValidator(e);
            pointProject.RepeatInterval = Convert.ToInt32(intervalTextBox.Text);
        }

        private void intervalTextBox_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileMenuItemClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void SaveFileMenuItemClick(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void OpenFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pointProject = new Project();
            try
            {
                DataSerializer.DeserializeBin(openFileDialog.FileName, ref pointProject);
                mousePointBindingSource.DataSource = pointProject.PointsList;
                statusLabel.Text = "";
            }
            catch ( Exception exception )
            {
                statusLabel.Text = exception.Message;
            }
        }

        private void SaveFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                DataSerializer.SerializeBin(saveFileDialog.FileName, ref pointProject);
                statusLabel.Text = "";
            }
            catch (Exception exception)
            {
                statusLabel.Text = exception.Message;
            }
        }
    }
}
