using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConstructionWork
{
    partial class MainForm
    {
        private System.ComponentModel.Container components = null;
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
            components = new();
            tabControl = new();
            tabConstruction = new();
            constructionControl = new();
            tabEmployee = new();
            employeeControl = new();
            toolTip = new(components);
            tabControl.SuspendLayout();
            tabConstruction.SuspendLayout();
            tabEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConstruction);
            tabControl.Controls.Add(tabEmployee);
            tabControl.Location = new(17, 15);
            tabControl.Margin = new(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new(1236, 818);
            tabControl.TabIndex = 0;
            // 
            // tabConstruction
            // 
            tabConstruction.Controls.Add(constructionControl);
            tabConstruction.Location = new(4, 34);
            tabConstruction.Margin = new(4, 5, 4, 5);
            tabConstruction.Name = "tabConstruction";
            tabConstruction.Padding = new(4, 5, 4, 5);
            tabConstruction.Size = new(1228, 780);
            tabConstruction.TabIndex = 0;
            tabConstruction.Text = "Công trình";
            tabConstruction.UseVisualStyleBackColor = true;
            // 
            // constructionControl
            // 
            constructionControl.Dock = DockStyle.Fill;
            constructionControl.Font = new("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            constructionControl.Location = new(4, 5);
            constructionControl.Margin = new(4, 5, 4, 5);
            constructionControl.Name = "constructionControl";
            constructionControl.Size = new(1220, 770);
            constructionControl.TabIndex = 0;
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(employeeControl);
            tabEmployee.Location = new(4, 34);
            tabEmployee.Margin = new(4, 5, 4, 5);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new(4, 5, 4, 5);
            tabEmployee.Size = new(1228, 780);
            tabEmployee.TabIndex = 1;
            tabEmployee.Text = "Nhân công";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // employeeControl
            // 
            employeeControl.Dock = DockStyle.Fill;
            employeeControl.Font = new("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeControl.Location = new(4, 5);
            employeeControl.Margin = new(4, 5, 4, 5);
            employeeControl.Name = "employeeControl";
            employeeControl.Size = new(1220, 770);
            employeeControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new(1277, 848);
            Controls.Add(tabControl);
            Font = new("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new(4, 5, 4, 5);
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