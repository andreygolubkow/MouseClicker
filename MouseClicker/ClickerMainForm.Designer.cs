namespace MouseClicker
{
    partial class ClickerMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickerMainForm));
            this.pointsGroupBox = new System.Windows.Forms.GroupBox();
            this.pointsGridView = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPointMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePointMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointsGroupBox
            // 
            this.pointsGroupBox.Controls.Add(this.pointsGridView);
            this.pointsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsGroupBox.Location = new System.Drawing.Point(0, 24);
            this.pointsGroupBox.Name = "pointsGroupBox";
            this.pointsGroupBox.Size = new System.Drawing.Size(601, 283);
            this.pointsGroupBox.TabIndex = 0;
            this.pointsGroupBox.TabStop = false;
            this.pointsGroupBox.Text = "Список точек";
            // 
            // pointsGridView
            // 
            this.pointsGridView.AllowUserToAddRows = false;
            this.pointsGridView.AllowUserToDeleteRows = false;
            this.pointsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsGridView.Location = new System.Drawing.Point(3, 16);
            this.pointsGridView.Name = "pointsGridView";
            this.pointsGridView.ReadOnly = true;
            this.pointsGridView.Size = new System.Drawing.Size(595, 264);
            this.pointsGridView.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSubMenu,
            this.editSubMenu,
            this.settingsSubMenu,
            this.startMenuItem,
            this.stopMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(601, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileSubMenu
            // 
            this.fileSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.saveFileMenuItem});
            this.fileSubMenu.Image = global::MouseClicker.Properties.Resources.file_5692;
            this.fileSubMenu.Name = "fileSubMenu";
            this.fileSubMenu.Size = new System.Drawing.Size(64, 20);
            this.fileSubMenu.Text = "Файл";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Image = global::MouseClicker.Properties.Resources.folder_yellow_open_3717;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileMenuItem.Text = "Открыть";
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Image = global::MouseClicker.Properties.Resources.document_save_9644;
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileMenuItem.Text = "Сохранить";
            // 
            // editSubMenu
            // 
            this.editSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPointMenuItem,
            this.removePointMenuItem});
            this.editSubMenu.Image = global::MouseClicker.Properties.Resources.pointer_3306;
            this.editSubMenu.Name = "editSubMenu";
            this.editSubMenu.Size = new System.Drawing.Size(75, 20);
            this.editSubMenu.Text = "Правка";
            // 
            // addPointMenuItem
            // 
            this.addPointMenuItem.Image = global::MouseClicker.Properties.Resources.add2__3143;
            this.addPointMenuItem.Name = "addPointMenuItem";
            this.addPointMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPointMenuItem.Text = "Добавить";
            // 
            // removePointMenuItem
            // 
            this.removePointMenuItem.Image = global::MouseClicker.Properties.Resources.error_6891;
            this.removePointMenuItem.Name = "removePointMenuItem";
            this.removePointMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removePointMenuItem.Text = "Удалить";
            // 
            // settingsSubMenu
            // 
            this.settingsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatMenuItem,
            this.intervalTextBox});
            this.settingsSubMenu.Image = global::MouseClicker.Properties.Resources.cog_icon_2_48x48_7873;
            this.settingsSubMenu.Name = "settingsSubMenu";
            this.settingsSubMenu.Size = new System.Drawing.Size(95, 20);
            this.settingsSubMenu.Text = "Настройки";
            // 
            // repeatMenuItem
            // 
            this.repeatMenuItem.Checked = true;
            this.repeatMenuItem.CheckOnClick = true;
            this.repeatMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repeatMenuItem.Name = "repeatMenuItem";
            this.repeatMenuItem.Size = new System.Drawing.Size(162, 22);
            this.repeatMenuItem.Text = "Повторять цикл";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.AccessibleDescription = "";
            this.intervalTextBox.AutoToolTip = true;
            this.intervalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.intervalTextBox.ToolTipText = "Пауза между повторениями";
            // 
            // startMenuItem
            // 
            this.startMenuItem.Image = global::MouseClicker.Properties.Resources.launch_6935;
            this.startMenuItem.Name = "startMenuItem";
            this.startMenuItem.Size = new System.Drawing.Size(73, 20);
            this.startMenuItem.Text = "Запуск";
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Image = global::MouseClicker.Properties.Resources.underconstruction_7418;
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(99, 20);
            this.stopMenuItem.Text = "Остановить";
            this.stopMenuItem.Visible = false;
            // 
            // ClickerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 307);
            this.Controls.Add(this.pointsGroupBox);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ClickerMainForm";
            this.Text = "MouseClicker";
            this.pointsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pointsGroupBox;
        private System.Windows.Forms.DataGridView pointsGridView;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileSubMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSubMenu;
        private System.Windows.Forms.ToolStripMenuItem addPointMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePointMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsSubMenu;
        private System.Windows.Forms.ToolStripMenuItem repeatMenuItem;
        private System.Windows.Forms.ToolStripTextBox intervalTextBox;
        private System.Windows.Forms.ToolStripMenuItem startMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
    }
}

