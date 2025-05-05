using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConstructionWork
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabConstruction;
        private TabPage tabEmployee;
        private ConstructionUserControl constructionControl;
        private EmployeeUserControl employeeControl;
        private ToolTip toolTip;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabConstruction = new TabPage();
            constructionControl = new ConstructionUserControl();
            tabEmployee = new TabPage();
            employeeControl = new EmployeeUserControl();
            toolTip = new ToolTip(components);
            tabControl.SuspendLayout();
            tabConstruction.SuspendLayout();
            tabEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConstruction);
            tabControl.Controls.Add(tabEmployee);
            tabControl.Location = new Point(17, 15);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1236, 818);
            tabControl.TabIndex = 0;
            // 
            // tabConstruction
            // 
            tabConstruction.Controls.Add(constructionControl);
            tabConstruction.Location = new Point(4, 34);
            tabConstruction.Margin = new Padding(4, 5, 4, 5);
            tabConstruction.Name = "tabConstruction";
            tabConstruction.Padding = new Padding(4, 5, 4, 5);
            tabConstruction.Size = new Size(1228, 780);
            tabConstruction.TabIndex = 0;
            tabConstruction.Text = "Công trình";
            tabConstruction.UseVisualStyleBackColor = true;
            // 
            // constructionControl
            // 
            constructionControl.Dock = DockStyle.Fill;
            constructionControl.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            constructionControl.Location = new Point(4, 5);
            constructionControl.Margin = new Padding(4, 5, 4, 5);
            constructionControl.Name = "constructionControl";
            constructionControl.Size = new Size(1220, 770);
            constructionControl.TabIndex = 0;
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(employeeControl);
            tabEmployee.Location = new Point(4, 34);
            tabEmployee.Margin = new Padding(4, 5, 4, 5);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(4, 5, 4, 5);
            tabEmployee.Size = new Size(1228, 780);
            tabEmployee.TabIndex = 1;
            tabEmployee.Text = "Nhân viên";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // employeeControl
            // 
            employeeControl.Dock = DockStyle.Fill;
            employeeControl.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeControl.Location = new Point(4, 5);
            employeeControl.Margin = new Padding(4, 5, 4, 5);
            employeeControl.Name = "employeeControl";
            employeeControl.Size = new Size(1220, 770);
            employeeControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 848);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý công trình";
            tabControl.ResumeLayout(false);
            tabConstruction.ResumeLayout(false);
            tabEmployee.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}