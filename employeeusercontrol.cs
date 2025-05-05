using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConstructionWork
{
    public partial class EmployeeUserControl : UserControl
    {
        private Label lblEmployeeName;
        private TextBox txtEmployeeName;
        private Label lblPosition;
        private TextBox txtPosition;
        private Label lblDepartment;
        private TextBox txtDepartment;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
        private Button btnRefreshEmployee;
        private DataGridView dgvEmployees;
        private Label lblEmployeeMessage;
        private System.ComponentModel.IContainer components = null;

        public EmployeeUserControl()
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblEmployeeName = new Label();
            txtEmployeeName = new TextBox();
            lblPosition = new Label();
            txtPosition = new TextBox();
            lblDepartment = new Label();
            txtDepartment = new TextBox();
            btnAddEmployee = new Button();
            btnEditEmployee = new Button();
            btnDeleteEmployee = new Button();
            btnRefreshEmployee = new Button();
            dgvEmployees = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            lblEmployeeMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(31, 25);
            lblEmployeeName.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(156, 26);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Tên nhân viên:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(195, 20);
            txtEmployeeName.Margin = new Padding(4, 5, 4, 5);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(448, 33);
            txtEmployeeName.TabIndex = 1;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(31, 75);
            lblPosition.Margin = new Padding(4, 0, 4, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(94, 26);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Chức vụ:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(195, 70);
            txtPosition.Margin = new Padding(4, 5, 4, 5);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(448, 33);
            txtPosition.TabIndex = 3;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(31, 125);
            lblDepartment.Margin = new Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(114, 26);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Phòng ban:";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(195, 120);
            txtDepartment.Margin = new Padding(4, 5, 4, 5);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(448, 33);
            txtDepartment.TabIndex = 5;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(32, 175);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(120, 36);
            btnAddEmployee.TabIndex = 6;
            btnAddEmployee.Text = "Thêm";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(192, 175);
            btnEditEmployee.Margin = new Padding(4, 5, 4, 5);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(120, 36);
            btnEditEmployee.TabIndex = 7;
            btnEditEmployee.Text = "Sửa";
            btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(352, 175);
            btnDeleteEmployee.Margin = new Padding(4, 5, 4, 5);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(120, 36);
            btnDeleteEmployee.TabIndex = 8;
            btnDeleteEmployee.Text = "Xóa";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRefreshEmployee
            // 
            btnRefreshEmployee.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshEmployee.Location = new Point(512, 175);
            btnRefreshEmployee.Margin = new Padding(4, 5, 4, 5);
            btnRefreshEmployee.Name = "btnRefreshEmployee";
            btnRefreshEmployee.Size = new Size(120, 36);
            btnRefreshEmployee.TabIndex = 9;
            btnRefreshEmployee.Text = "Làm mới";
            btnRefreshEmployee.UseVisualStyleBackColor = true;
            btnRefreshEmployee.Click += btnRefreshEmployee_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToOrderColumns = true;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPosition, colDepartment });
            dgvEmployees.Location = new Point(31, 230);
            dgvEmployees.Margin = new Padding(4, 5, 4, 5);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1163, 494);
            dgvEmployees.TabIndex = 10;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colId.HeaderText = "STT";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 82;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colName.HeaderText = "Tên nhân viên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 179;
            // 
            // colPosition
            // 
            colPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPosition.HeaderText = "Chức vụ";
            colPosition.MinimumWidth = 6;
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            colPosition.Width = 117;
            // 
            // colDepartment
            // 
            colDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDepartment.HeaderText = "Phòng ban";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            colDepartment.Width = 137;
            // 
            // lblEmployeeMessage
            // 
            lblEmployeeMessage.AutoSize = true;
            lblEmployeeMessage.ForeColor = Color.Green;
            lblEmployeeMessage.Location = new Point(669, 180);
            lblEmployeeMessage.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeMessage.Name = "lblEmployeeMessage";
            lblEmployeeMessage.Size = new Size(0, 26);
            lblEmployeeMessage.TabIndex = 11;
            lblEmployeeMessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmployeeUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEmployeeMessage);
            Controls.Add(dgvEmployees);
            Controls.Add(btnRefreshEmployee);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblEmployeeName);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeeUserControl";
            Size = new Size(1228, 780);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colDepartment;

        #region Event Handlers

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Xử lý thêm nhân viên
            // Hiển thị thông báo thành công
            lblEmployeeMessage.Text = "Đã thêm nhân viên thành công!";
            lblEmployeeMessage.ForeColor = Color.Green;

            // Tự động ẩn thông báo sau 3 giây
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 3000; // 3 giây
            timer.Tick += (s, args) => {
                lblEmployeeMessage.Text = "";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void btnRefreshEmployee_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các ô nhập liệu
            txtEmployeeName.Clear();
            txtPosition.Clear();
            txtDepartment.Clear();

            // Chuyển focus ra khỏi các ô nhập liệu
            this.ActiveControl = null;

            // Hiển thị thông báo làm mới thành công
            lblEmployeeMessage.Text = "Đã làm mới các trường dữ liệu!";
            lblEmployeeMessage.ForeColor = Color.Green;

            // Tự động ẩn thông báo sau 3 giây
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 3000; // 3 giây
            timer.Tick += (s, args) => {
                lblEmployeeMessage.Text = "";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        #endregion
    }
}