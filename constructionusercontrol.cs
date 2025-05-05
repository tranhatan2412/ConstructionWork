using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConstructionWork
{
    public partial class ConstructionUserControl : UserControl
    {
        private Label lblName;
        private TextBox txtName;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblLocation;
        private TextBox txtLocation;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private Panel panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterName;
        private TextBox txtFilterYear;
        private TextBox txtFilterLocation;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewColumnSTT;
        private DataGridViewTextBoxColumn dataGridViewColumnName;
        private DataGridViewTextBoxColumn dataGridViewColumnYear;
        private DataGridViewTextBoxColumn dataGridViewColumnPlace;
        private System.ComponentModel.IContainer components = null;

        public ConstructionUserControl()
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblMessage = new Label();
            btnExport = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtLocation = new TextBox();
            lblLocation = new Label();
            txtYear = new TextBox();
            lblYear = new Label();
            txtName = new TextBox();
            lblName = new Label();
            dgvConstruction = new DataGridView();
            btnRefresh = new Button();
            panelFilter = new Panel();
            txtFilterName = new TextBox();
            txtFilterYear = new TextBox();
            txtFilterLocation = new TextBox();
            pictureBoxRemoveFilter = new PictureBox();
            toolTip = new ToolTip(components);
            dataGridViewColumnSTT = new DataGridViewTextBoxColumn();
            dataGridViewColumnName = new DataGridViewTextBoxColumn();
            dataGridViewColumnYear = new DataGridViewTextBoxColumn();
            dataGridViewColumnPlace = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(669, 180);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(309, 26);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Đã thêm công trình thành công!";
            lblMessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new Point(1043, 744);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(151, 36);
            btnExport.TabIndex = 1;
            btnExport.Text = "Xuất Excel";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 175);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(192, 175);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 36);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(195, 70);
            txtLocation.Margin = new Padding(4, 5, 4, 5);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(448, 33);
            txtLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(31, 75);
            lblLocation.Margin = new Padding(4, 0, 4, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(103, 26);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Địa điểm:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(195, 120);
            txtYear.Margin = new Padding(4, 5, 4, 5);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(223, 33);
            txtYear.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(31, 125);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(154, 26);
            lblYear.TabIndex = 8;
            lblYear.Text = "Năm thực hiện:";
            // 
            // txtName
            // 
            txtName.Location = new Point(195, 20);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(448, 33);
            txtName.TabIndex = 9;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(31, 25);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(155, 26);
            lblName.TabIndex = 10;
            lblName.Text = "Tên công trình:";
            // 
            // dgvConstruction
            // 
            dgvConstruction.AllowUserToAddRows = false;
            dgvConstruction.AllowUserToDeleteRows = false;
            dgvConstruction.AllowUserToOrderColumns = true;
            dgvConstruction.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConstruction.Columns.AddRange(new DataGridViewColumn[] { dataGridViewColumnSTT, dataGridViewColumnName, dataGridViewColumnYear, dataGridViewColumnPlace });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvConstruction.DefaultCellStyle = dataGridViewCellStyle6;
            dgvConstruction.Location = new Point(31, 275);
            dgvConstruction.Margin = new Padding(4, 5, 4, 5);
            dgvConstruction.Name = "dgvConstruction";
            dgvConstruction.ReadOnly = true;
            dgvConstruction.RowHeadersWidth = 51;
            dgvConstruction.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvConstruction.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvConstruction.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvConstruction.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvConstruction.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConstruction.Size = new Size(1163, 449);
            dgvConstruction.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(512, 175);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 36);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Làm mới";
            toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(txtFilterName);
            panelFilter.Controls.Add(txtFilterYear);
            panelFilter.Controls.Add(txtFilterLocation);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new Point(31, 230);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1163, 45);
            panelFilter.TabIndex = 15;
            // 
            // txtFilterName
            // 
            txtFilterName.Font = new Font("Times New Roman", 13.2000008F);
            txtFilterName.Location = new Point(0, 5);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.PlaceholderText = "Tìm theo tên công trình...";
            txtFilterName.Size = new Size(457, 33);
            txtFilterName.TabIndex = 0;
            // 
            // txtFilterYear
            // 
            txtFilterYear.Font = new Font("Times New Roman", 13.2000008F);
            txtFilterYear.Location = new Point(457, 5);
            txtFilterYear.Name = "txtFilterYear";
            txtFilterYear.PlaceholderText = "Tìm theo năm...";
            txtFilterYear.Size = new Size(350, 33);
            txtFilterYear.TabIndex = 1;
            // 
            // txtFilterLocation
            // 
            txtFilterLocation.Font = new Font("Times New Roman", 13.2000008F);
            txtFilterLocation.Location = new Point(807, 5);
            txtFilterLocation.Name = "txtFilterLocation";
            txtFilterLocation.PlaceholderText = "Tìm theo địa điểm...";
            txtFilterLocation.Size = new Size(310, 33);
            txtFilterLocation.TabIndex = 2;
            // 
            // pictureBoxRemoveFilter
            // 
            pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
            pictureBoxRemoveFilter.Image = Properties.Resources.images;
            pictureBoxRemoveFilter.Location = new Point(1123, 7);
            pictureBoxRemoveFilter.Name = "pictureBoxRemoveFilter";
            pictureBoxRemoveFilter.Size = new Size(33, 31);
            pictureBoxRemoveFilter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRemoveFilter.TabIndex = 3;
            pictureBoxRemoveFilter.TabStop = false;
            toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");
            pictureBoxRemoveFilter.Click += pictureBoxRemoveFilter_Click;
            // 
            // dataGridViewColumnSTT
            // 
            dataGridViewColumnSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewColumnSTT.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewColumnSTT.HeaderText = "STT";
            dataGridViewColumnSTT.MinimumWidth = 6;
            dataGridViewColumnSTT.Name = "dataGridViewColumnSTT";
            dataGridViewColumnSTT.ReadOnly = true;
            dataGridViewColumnSTT.Width = 82;
            // 
            // dataGridViewColumnName
            // 
            dataGridViewColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewColumnName.HeaderText = "Tên công trình";
            dataGridViewColumnName.MinimumWidth = 6;
            dataGridViewColumnName.Name = "dataGridViewColumnName";
            dataGridViewColumnName.ReadOnly = true;
            dataGridViewColumnName.Width = 178;
            // 
            // dataGridViewColumnYear
            // 
            dataGridViewColumnYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewColumnYear.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewColumnYear.HeaderText = "Năm thực hiện";
            dataGridViewColumnYear.MinimumWidth = 6;
            dataGridViewColumnYear.Name = "dataGridViewColumnYear";
            dataGridViewColumnYear.ReadOnly = true;
            dataGridViewColumnYear.Width = 177;
            // 
            // dataGridViewColumnPlace
            // 
            dataGridViewColumnPlace.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewColumnPlace.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewColumnPlace.HeaderText = "Địa điểm";
            dataGridViewColumnPlace.MinimumWidth = 6;
            dataGridViewColumnPlace.Name = "dataGridViewColumnPlace";
            dataGridViewColumnPlace.ReadOnly = true;
            dataGridViewColumnPlace.Width = 126;
            // 
            // ConstructionUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dgvConstruction);
            Controls.Add(btnRefresh);
            Controls.Add(panelFilter);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConstructionUserControl";
            Size = new Size(1228, 780);
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Event Handlers

        private void pictureBoxRemoveFilter_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các ô tìm kiếm
            txtFilterName.Clear();
            txtFilterYear.Clear();
            txtFilterLocation.Clear();

            // Chuyển focus ra khỏi các ô tìm kiếm
            this.ActiveControl = null;

            // Có thể thêm code để làm mới datagridview nếu cần
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các ô nhập liệu
            txtName.Clear();
            txtYear.Clear();
            txtLocation.Clear();

            // Chuyển focus ra khỏi các ô nhập liệu
            this.ActiveControl = null;

            // Hiển thị thông báo làm mới thành công (tùy chọn)
            lblMessage.Text = "Đã làm mới các trường dữ liệu!";
            lblMessage.ForeColor = Color.Green;

            // Tự động ẩn thông báo sau 3 giây (tùy chọn)
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 3000; // 3 giây
            timer.Tick += (s, args) => {
                lblMessage.Text = "";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        #endregion
    }
}