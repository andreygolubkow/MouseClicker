using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
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
            if ( !pointProject.Repeat )
            {
                return;
            }
            intervalTextBox.TextBox.Text = Convert.ToString(pointProject.RepeatInterval);
            statusLabel.Text = "Не забудьте указать интервал(в мс.) в следующем поле, после кнопки.";
        }

        private void IntervalTextBoxKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void IntervalTextBoxKeyPress(object sender, KeyPressEventArgs e)
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
                intervalTextBox.TextBox.Text = Convert.ToString(pointProject.RepeatInterval);
                repeatMenuItem.Checked = pointProject.Repeat;
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

        private void StartMenuItemClick(object sender, EventArgs e)
        {
            fileSubMenu.Visible = false;
            editSubMenu.Visible = false;
            startMenuItem.Visible = false;
            settingsSubMenu.Visible = false;
            stopMenuItem.Visible = true;
            pointsGridView.Enabled = false;
            addPointMenuItem.Enabled = false;
            removePointMenuItem.Enabled = false;
            mousePointBindingSource.SuspendBinding();
            backgroundWorker.RunWorkerAsync();
            statusLabel.Text = "Поток запущен";
        }

        private void StopMenuItemClick(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            statusLabel.Text = "Ожидание завершения потока";
        }

        private void BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var clickList = new List<MousePoint>(pointProject.PointsList);
            do
            {
                foreach (MousePoint point in clickList)
                {
                    if ( backgroundWorker.CancellationPending )
                    {
                        continue;
                    }
                    Thread.Sleep(point.Interval);
                    //Клик
                    MouseControl.Move(point.Point.X, point.Point.Y);
                    MouseControl.Click();

                }
                Thread.Sleep(pointProject.RepeatInterval);
            }
            while ( pointProject.Repeat && !backgroundWorker.CancellationPending);
        }

        private void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fileSubMenu.Visible = true;
            editSubMenu.Visible = true;
            startMenuItem.Visible = true;
            settingsSubMenu.Visible = true;
            stopMenuItem.Visible = false;
            mousePointBindingSource.ResumeBinding();
            pointsGridView.Enabled = true;
            addPointMenuItem.Enabled = true;
            removePointMenuItem.Enabled = true;
            statusLabel.Text = "Поток завершен";
        }
    }
}
