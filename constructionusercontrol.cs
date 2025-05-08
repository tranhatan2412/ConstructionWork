using System.Data;
using Microsoft.Data.SqlClient;
using ConstructionWork.Helpers;
using ClosedXML.Excel;

namespace ConstructionWork
{
   public partial class ConstructionUserControl : UserControl
   {
      private Label? lblName;
      private TextBox txtName;
      private Label? lblYear;
      private TextBox txtYear;
      private Label? lblLocation;
      private TextBox txtLocation;
      private Button btnAdd;
      private Button btnEdit;
      private Button btnDelete;
      private Button btnRefresh;
      private Button btnExport;
      private Panel? panelFilter;
      private DataGridView dgvConstruction;
      private Label lblMessage;
      private TextBox txtFilterName;
      private TextBox txtFilterYear;
      private TextBox txtFilterLocation;
      private PictureBox pictureBoxRemoveFilter;
      private ToolTip? toolTip;
      private DataGridViewTextBoxColumn? dataGridViewColumnSTT;
      private DataGridViewTextBoxColumn? dataGridViewColumnName;
      private DataGridViewTextBoxColumn? dataGridViewColumnYear;
      private DataGridViewTextBoxColumn? dataGridViewColumnLocation;
      private DataGridViewTextBoxColumn? dataGridViewColumnID;
      private DataGridViewCheckBoxColumn dataGridViewColumnCheckBox;
      private System.ComponentModel.Container? components;

      public ConstructionUserControl()
      {
         InitializeComponent();
         Event(); // Gọi hàm khởi tạo sự kiện   
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
         components = new();
         lblMessage = new();
         btnExport = new();
         btnDelete = new();
         btnEdit = new();
         btnAdd = new();
         txtLocation = new();
         lblLocation = new();
         txtYear = new();
         lblYear = new();
         txtName = new();
         lblName = new();
         dgvConstruction = new();
         btnRefresh = new();
         panelFilter = new();
         txtFilterName = new();
         txtFilterYear = new();
         txtFilterLocation = new();
         pictureBoxRemoveFilter = new();
         toolTip = new(components);
         dataGridViewColumnSTT = new();
         dataGridViewColumnName = new();
         dataGridViewColumnYear = new();
         dataGridViewColumnLocation = new();
         dataGridViewColumnID = new();
         dataGridViewColumnCheckBox = new();
         ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
         panelFilter.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
         SuspendLayout();
         // 
         // lblMessage
         // 
         lblMessage.AutoSize = true;
         lblMessage.ForeColor = Color.Green;
         lblMessage.Location = new(669, 20);
         lblMessage.Margin = new(4, 0, 4, 0);
         lblMessage.Name = "lblMessage";
         lblMessage.Size = new(0, 26);
         lblMessage.TextAlign = ContentAlignment.MiddleLeft;
         lblMessage.MaximumSize = new(500, 0);
         // 
         // btnExport
         // 
         btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
         btnExport.Location = new(1043, 744);
         btnExport.Margin = new(4, 5, 4, 5);
         btnExport.Name = "btnExport";
         btnExport.Size = new(151, 36);
         btnExport.TabIndex = 11;
         btnExport.Text = "Xuất Excel";
         // 
         // btnDelete
         // 
         btnDelete.Location = new(352, 175);
         btnDelete.Margin = new(4, 5, 4, 5);
         btnDelete.Name = "btnDelete";
         btnDelete.Size = new(160, 36);
         btnDelete.TabIndex = 5;
         btnDelete.Text = "Xóa";
         // 
         // btnEdit
         // 
         btnEdit.Location = new(192, 175);
         btnEdit.Margin = new(4, 5, 4, 5);
         btnEdit.Name = "btnEdit";
         btnEdit.Size = new(160, 36);
         btnEdit.TabIndex = 4;
         btnEdit.Text = "Sửa";
         // 
         // btnAdd
         // 
         btnAdd.Location = new(32, 175);
         btnAdd.Name = "btnAdd";
         btnAdd.Size = new(160, 36);
         btnAdd.TabIndex = 3;
         btnAdd.Text = "Thêm";
         // 
         // btnRefresh
         // 
         btnRefresh.Location = new(513, 175);
         btnRefresh.Margin = new(4, 5, 4, 5);
         btnRefresh.Name = "btnRefresh";
         btnRefresh.Size = new(130, 36);
         btnRefresh.TabIndex = 6;
         btnRefresh.Text = "Làm mới";
         toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");
         // 
         // txtLocation
         // 
         txtLocation.Location = new(195, 70);
         txtLocation.Margin = new(4, 5, 4, 5);
         txtLocation.Name = "txtLocation";
         txtLocation.Size = new(448, 33);
         txtLocation.TabIndex = 1;
         // 
         // lblLocation
         // 
         lblLocation.AutoSize = true;
         lblLocation.Location = new(31, 75);
         lblLocation.Margin = new(4, 0, 4, 0);
         lblLocation.Name = "lblLocation";
         lblLocation.Size = new(103, 26);
         lblLocation.Text = "Địa điểm:";
         // 
         // txtYear
         // 
         txtYear.Location = new(195, 120);
         txtYear.Margin = new(4, 5, 4, 5);
         txtYear.Name = "txtYear";
         txtYear.Size = new(223, 33);
         txtYear.TabIndex = 2;
         // 
         // lblYear
         // 
         lblYear.AutoSize = true;
         lblYear.Location = new(31, 125);
         lblYear.Margin = new(4, 0, 4, 0);
         lblYear.Name = "lblYear";
         lblYear.Size = new(154, 26);
         lblYear.Text = "Năm thực hiện:";
         // 
         // txtName
         // 
         txtName.Location = new(195, 20);
         txtName.Margin = new(4, 5, 4, 5);
         txtName.Name = "txtName";
         txtName.Size = new(448, 33);
         txtName.TabIndex = 0;
         // 
         // lblName
         // 
         lblName.AutoSize = true;
         lblName.Location = new(31, 25);
         lblName.Margin = new(4, 0, 4, 0);
         lblName.Name = "lblName";
         lblName.Size = new(155, 26);
         lblName.Text = "Tên công trình:";
         // 
         // dgvConstruction
         // 
         dgvConstruction.AllowUserToAddRows = false;
         dgvConstruction.AllowUserToDeleteRows = false;
         dgvConstruction.AllowUserToOrderColumns = true;
         dgvConstruction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
         dgvConstruction.BackgroundColor = Color.White;
         dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvConstruction.Columns.AddRange([dataGridViewColumnSTT, dataGridViewColumnName, dataGridViewColumnLocation, dataGridViewColumnYear, dataGridViewColumnID, dataGridViewColumnCheckBox]);
         dgvConstruction.Location = new(31, 275);
         dgvConstruction.Margin = new(4, 5, 4, 5);
         dgvConstruction.Name = "dgvConstruction";
         dgvConstruction.ReadOnly = true;
         dgvConstruction.Size = new(1163, 449);
         // 
         // dataGridViewColumnSTT
         // 
         dataGridViewColumnSTT.HeaderText = "STT";
         dataGridViewColumnSTT.Name = "dataGridViewColumnSTT";
         dataGridViewColumnSTT.ReadOnly = true;
         dataGridViewColumnSTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         dataGridViewColumnSTT.Width = 80;
         // 
         // dataGridViewColumnName
         // 
         dataGridViewColumnName.HeaderText = "Tên công trình";
         dataGridViewColumnName.Name = "dataGridViewColumnName";
         dataGridViewColumnName.ReadOnly = true;
         dataGridViewColumnName.MinimumWidth = 405;
         // 
         // dataGridViewColumnYear
         // 
         dataGridViewColumnYear.HeaderText = "Năm thực hiện";
         dataGridViewColumnYear.Name = "dataGridViewColumnYear";
         dataGridViewColumnYear.ReadOnly = true;
         dataGridViewColumnYear.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         dataGridViewColumnYear.MinimumWidth = 175;
         // 
         // dataGridViewColumnLocation
         // 
         dataGridViewColumnLocation.HeaderText = "Địa điểm";
         dataGridViewColumnLocation.Name = "dataGridViewColumnLocation";
         dataGridViewColumnLocation.ReadOnly = true;
         dataGridViewColumnLocation.MinimumWidth = 405;
         //
         // dataGridViewColumnID
         //
         dataGridViewColumnID.Name = "dataGridViewColumnID";
         dataGridViewColumnID.ReadOnly = true;
         dataGridViewColumnID.Visible = false;
         //
         // dataGridViewColumnCheckBox
         //
         dataGridViewColumnCheckBox.HeaderText = "✅";
         dataGridViewColumnCheckBox.Name = "dataGridViewColumnCheckBox";
         dataGridViewColumnCheckBox.ReadOnly = false;
         dataGridViewColumnCheckBox.Visible = false;
         dataGridViewColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";


         //

         // Giữ lại các cột đã định nghĩa
         dgvConstruction.AutoGenerateColumns = false;
         dgvConstruction.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
         dgvConstruction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         dgvConstruction.DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
         dgvConstruction.DefaultCellStyle.SelectionForeColor = Color.Black;

         // Ánh xạ các cột đã định nghĩa với dữ liệu
         dataGridViewColumnSTT.DataPropertyName = "STT";
         dataGridViewColumnName.DataPropertyName = "Name";
         dataGridViewColumnYear.DataPropertyName = "Year";
         dataGridViewColumnLocation.DataPropertyName = "Location";
         dataGridViewColumnID.DataPropertyName = "ID";
         dataGridViewColumnCheckBox.DataPropertyName = "";

         // Căn giữa tiêu đề các cột
         dgvConstruction.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

         // 
         // panelFilter
         // 
         panelFilter.BackColor = Color.WhiteSmoke;
         panelFilter.BorderStyle = BorderStyle.FixedSingle;
         panelFilter.Controls.Add(txtFilterName);
         panelFilter.Controls.Add(txtFilterYear);
         panelFilter.Controls.Add(txtFilterLocation);
         panelFilter.Controls.Add(pictureBoxRemoveFilter);
         panelFilter.Location = new(31, 230);
         panelFilter.Name = "panelFilter";
         panelFilter.Size = new(1163, 45);
         // 
         // txtFilterName
         // 
         txtFilterName.Font = new("Times New Roman", 13.2000008F);
         txtFilterName.Location = new(130, 5);
         txtFilterName.Name = "txtFilterName";
         txtFilterName.PlaceholderText = "Tìm theo tên công trình...";
         txtFilterName.Size = new(405, 33);
         txtFilterName.TabIndex = 7;
         // 
         // txtFilterYear
         // 
         txtFilterYear.Font = new("Times New Roman", 13.2000008F);
         txtFilterYear.Location = new(943, 5);
         txtFilterYear.Name = "txtFilterYear";
         txtFilterYear.PlaceholderText = "Tìm theo năm...";
         txtFilterYear.Size = new(175, 33);
         txtFilterYear.TabIndex = 9;
         // 
         // txtFilterLocation
         // 
         txtFilterLocation.Font = new("Times New Roman", 13.2000008F);
         txtFilterLocation.Location = new(536, 5);
         txtFilterLocation.Name = "txtFilterLocation";
         txtFilterLocation.PlaceholderText = "Tìm theo địa điểm...";
         txtFilterLocation.Size = new(405, 33);
         txtFilterLocation.TabIndex = 8;
         // 
         // pictureBoxRemoveFilter
         // 
         pictureBoxRemoveFilter.BackColor = Color.Transparent;
         pictureBoxRemoveFilter.Cursor = Cursors.Hand;
         pictureBoxRemoveFilter.Image = Properties.Resources.images;
         pictureBoxRemoveFilter.Location = new(0, 5);
         pictureBoxRemoveFilter.Name = "pictureBoxRemoveFilter";
         pictureBoxRemoveFilter.Size = new(33, 33);
         pictureBoxRemoveFilter.SizeMode = PictureBoxSizeMode.StretchImage;
         pictureBoxRemoveFilter.TabIndex = 10;
         pictureBoxRemoveFilter.TabStop = false;
         toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");


         // 
         // ConstructionUserControl
         // 
         AutoScaleDimensions = new(12F, 25F);
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
         Font = new("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
         Margin = new(4, 5, 4, 5);
         Name = "ConstructionUserControl";
         Size = new(1228, 780);
         ((System.ComponentModel.ISupportInitialize)dgvConstruction).EndInit();
         panelFilter.ResumeLayout(false);
         panelFilter.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      #region Event Handlers

      private bool CheckNameLocationNotEmpty()
      {
         // Kiểm tra tên công trình không được bỏ trống
         if (string.IsNullOrWhiteSpace(txtName.Text))
         {
            lblMessage.Text = "Vui lòng nhập tên công trình!";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
            txtName.Focus();
            return true;
         }

         // Kiểm tra địa điểm không được bỏ trống
         if (string.IsNullOrWhiteSpace(txtLocation.Text))
         {
            lblMessage.Text = "Vui lòng nhập địa điểm!";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
            txtLocation.Focus();
            return true;
         }
         return false;
      }
      private void btnAdd_Click(object? sender, EventArgs e)
      {
         if (CheckNameLocationNotEmpty()) return;
         try
         {
            // Lấy kết nối từ DatabaseHelper
            using SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();
            string query = "insert into CongTrinh (Name, Location, Year) values (@Name, @Location, @Year)";

            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Location", txtLocation.Text);
            command.Parameters.AddWithValue("@Year", string.IsNullOrEmpty(txtYear.Text) ? DBNull.Value : Convert.ToInt32(txtYear.Text));

            command.ExecuteNonQuery();


            // Hiển thị thông báo thành công
            lblMessage.Text = "Đã thêm công trình thành công!";
            lblMessage.ForeColor = Color.Green;
            TimeIntervalMessage();

            // Làm mới các trường nhập liệu
            txtName.Clear();
            txtYear.Clear();
            txtLocation.Clear();
            this.ActiveControl = null;

            // Làm mới datagridview
            LoadConstructionData();
         }
         catch (Exception ex)
         {
            lblMessage.Text = $"Lỗi: {ex.Message}";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
         }
      }
      private DataTable? constructionData;
      private void LoadConstructionData()
      {
         try
         {
            using SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();
            string query = "select Name, Location, trim(str(Year)) as Year, ID from CongTrinh order by Name";

            using SqlCommand command = new(query, connection);

            // Sử dụng SqlDataAdapter để lấy dữ liệu
            SqlDataAdapter adapter = new(command);

            // Tạo DataTable để lưu trữ dữ liệu
            constructionData = new();

            // Đổ dữ liệu vào DataTable
            adapter.Fill(constructionData);

            // Thêm cột STT
            if (!constructionData.Columns.Contains("STT"))
            {
               DataColumn sttColumn = new("STT", typeof(int));
               constructionData.Columns.Add(sttColumn);
            }

            // Đánh số STT
            int rowNumber = constructionData.Rows.Count;
            for (int i = 0; i < rowNumber; i++)
               constructionData.Rows[i]["STT"] = i + 1;

            // Sắp xếp lại thứ tự cột
            if (constructionData.Columns.Contains("STT"))
               constructionData.Columns?["STT"]?.SetOrdinal(0);
            // Gán DataSource
            dgvConstruction.DataSource = constructionData;
         }
         catch (Exception ex)
         {
            lblMessage.Text = $"Lỗi khi tải dữ liệu: {ex.Message}";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
         }

      }

      private void ApplyFilter()
      {
         try
         {
            if (constructionData == null) return;

            string nameFilter = txtFilterName.Text.Trim();
            string locationFilter = txtFilterLocation.Text.Trim();
            string yearFilter = txtFilterYear.Text.Trim();

            // Xây dựng biểu thức lọc
            string filterExpression = "";

            if (!string.IsNullOrEmpty(nameFilter))
               filterExpression += $"Name like '%{nameFilter}%'";

            if (!string.IsNullOrEmpty(locationFilter))
            {
               if (!string.IsNullOrEmpty(filterExpression))
                  filterExpression += " and ";
               filterExpression += $"Location like '%{locationFilter}%'";
            }

            if (!string.IsNullOrEmpty(yearFilter))
            {
               if (!string.IsNullOrEmpty(filterExpression))
                  filterExpression += " and ";
               filterExpression += $"Year like '%{yearFilter}%'";
            }

            // Áp dụng bộ lọc
            var dv = new DataView(constructionData)
            {
               RowFilter = filterExpression
            };
            dgvConstruction.DataSource = dv;
         }
         catch (Exception)
         {
            dgvConstruction.DataSource = null; // Nếu có lỗi, xóa DataSource
         }
      }

      private void TxtFilter_TextChanged(object? sender, EventArgs e) => ApplyFilter();

      // Xóa nội dung của tất cả các ô tìm kiếm
      private void pictureBoxRemoveFilter_Click(object? sender, EventArgs e)
      {
         txtFilterName.Clear();
         txtFilterYear.Clear();
         txtFilterLocation.Clear();
         txtFilterName.Focus(); // Đặt focus vào ô tìm kiếm tên công trình

         // Áp dụng lại bộ lọc (sẽ hiển thị tất cả dữ liệu vì các ô tìm kiếm đã được xóa)
         ApplyFilter();
      }

      private void Event()
      {
         // Thêm sự kiện KeyPress cho ô nhập năm để chỉ cho phép nhập số
         txtYear.KeyPress += TxtYear_KeyPress;
         //
         pictureBoxRemoveFilter.Click += pictureBoxRemoveFilter_Click;
         btnRefresh.Click += btnRefresh_Click;
         btnAdd.Click += btnAdd_Click;
         btnEdit.Click += btnEdit_Click;
         Load += ConstructionUserControl_Load;

         // Thêm sự kiện TextChanged cho các ô tìm kiếm
         txtFilterName.TextChanged += TxtFilter_TextChanged;
         txtFilterYear.TextChanged += TxtFilter_TextChanged;
         txtFilterLocation.TextChanged += TxtFilter_TextChanged;
         // Đăng ký sự kiện KeyDown cho các TextBox
         /* txtName.KeyDown += TextBox_KeyDown;
         txtLocation.KeyDown += TextBox_KeyDown;
         txtYear.KeyDown += TextBox_KeyDown; */
         dgvConstruction.CellClick += DgvConstruction_CellClick;
         dgvConstruction.DataBindingComplete += DgvConstruction_DataBindingComplete;
         dgvConstruction.Sorted += DgvConstruction_Sorted;
         btnDelete.Click += btnDelete_Click;
         dgvConstruction.CellContentClick += DgvConstruction_CellContentClick;
         dgvConstruction.SelectionChanged += DgvConstruction_SelectionChanged;
         btnExport.Click += btnExport_Click;
      }
      /* private void TextBox_KeyDown(object? sender, KeyEventArgs e)
      {
         // Kiểm tra nếu phím Enter được nhấn
         if (e.KeyCode == Keys.Enter)
         {
            // Ngăn không cho phím Enter tạo ra tiếng "beep"
            e.SuppressKeyPress = true;

            // Kích hoạt sự kiện Click của nút Thêm
            btnAdd.PerformClick();
         }
      } */
      public void TimeIntervalMessage()
      {
         System.Windows.Forms.Timer timer = new()
         {
            Interval = 7000,
         };
         timer.Tick += (s, args) =>
            {
               lblMessage.Text = "";
               timer.Stop();
               timer.Dispose();
            };
         timer.Start();
      }

      #endregion

      private void TxtYear_KeyPress(object? sender, KeyPressEventArgs e)
      {
         // Chỉ cho phép nhập số và phím điều khiển (như backspace)
         if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
         {
            e.Handled = true; // Ngăn ký tự được nhập vào

            // Hiển thị thông báo
            lblMessage.Text = "Chỉ nhập số vào ô này!";
            lblMessage.ForeColor = Color.Red;

            TimeIntervalMessage();
         }
      }

      private void btnRefresh_Click(object? sender, EventArgs e)
      {
         // Xóa nội dung của tất cả các ô nhập liệu
         txtName.Clear();
         txtYear.Clear();
         txtLocation.Clear();

         txtName.Focus(); // Đặt focus vào ô nhập tên công trình
      }

      private void ConstructionUserControl_Load(object? sender, EventArgs e) => LoadConstructionData();

      private int constructionID = -1;
      private void DgvConstruction_CellClick(object? sender, DataGridViewCellEventArgs e)
      {
         // Kiểm tra xem người dùng có nhấp vào tiêu đề cột không
         if (e.RowIndex < 0)
            return;

         try
         {
            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow row = dgvConstruction.Rows[e.RowIndex];

            // Hiển thị dữ liệu vào các ô nhập tương ứng
            txtName.Text = row.Cells["dataGridViewColumnName"].Value.ToString();
            txtLocation.Text = row.Cells["dataGridViewColumnLocation"].Value.ToString();
            txtYear.Text = row.Cells["dataGridViewColumnYear"].Value?.ToString() ?? string.Empty;
            constructionID = Convert.ToInt32(row.Cells["dataGridViewColumnID"].Value); // Lưu ID công trình để sử dụng cho việc sửa hoặc xóa
            txtName.Focus();

         }
         catch (Exception ex)
         {
            lblMessage.Text = $"Lỗi khi lấy dữ liệu: {ex.Message}";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
         }
      }
      private void SelectRowById()
      {
         foreach (DataGridViewRow row in dgvConstruction.Rows)
         {
            if (Convert.ToInt32(row.Cells["dataGridViewColumnID"].Value) == constructionID)
            {
               // Chọn dòng
               dgvConstruction.ClearSelection();
               row.Selected = true;
               dgvConstruction.CurrentCell = row.Cells[0];

               // Cuộn đến dòng được chọn để đảm bảo nó hiển thị
               dgvConstruction.FirstDisplayedScrollingRowIndex = row.Index;
               break;
            }
         }
      }

      private void btnEdit_Click(object? sender, EventArgs e)
      {
         if (dgvConstruction.RowCount == 0)
         {
            lblMessage.Text = "Không có công trình nào để sửa!";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
            return;
         }
         // Kiểm tra xem đã chọn công trình nào chưa
         if (constructionID == -1)
         {
            lblMessage.Text = "Chọn một công trình để sửa!";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
            return;
         }

         if (CheckNameLocationNotEmpty()) return;
         try
         {

            // Cập nhật dữ liệu vào database
            using SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();

            string query = "update CongTrinh set Name = @Name, Location = @Location, Year = @Year where ID = @ID";

            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Location", txtLocation.Text);
            command.Parameters.AddWithValue("@Year", string.IsNullOrEmpty(txtYear.Text) ? DBNull.Value : Convert.ToInt32(txtYear.Text));
            command.Parameters.AddWithValue("@ID", constructionID);

            // Thực thi câu lệnh
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
               lblMessage.Text = "Cập nhật công trình thành công!";
               lblMessage.ForeColor = Color.Green;
               TimeIntervalMessage();

               txtName.Clear();
               txtYear.Clear();
               txtLocation.Clear();
               ActiveControl = null;

               LoadConstructionData();
               SelectRowById();
            }
            else
            {
               lblMessage.Text = "Không thể cập nhật công trình. Vui lòng thử lại!";
               lblMessage.ForeColor = Color.Red;
               TimeIntervalMessage();
            }
         }
         catch (Exception ex)
         {
            lblMessage.Text = $"Lỗi: {ex.Message}";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
         }

      }
      private void DgvConstruction_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
      {
         // Đảm bảo không có dòng nào được chọn sau khi binding dữ liệu
         dgvConstruction.ClearSelection();
         if (dgvConstruction.Rows.Count > 0)
            dgvConstruction.CurrentCell = null;
      }
      private void DgvConstruction_Sorted(object? sender, EventArgs e)
      {
         // Xóa lựa chọn sau khi sắp xếp
         dgvConstruction.ClearSelection();

         // Đặt CurrentCell thành null để không có ô nào được chọn
         if (dgvConstruction.Rows.Count > 0)
         {
            dgvConstruction.CurrentCell = null;
         }
      }

      private bool isDelete = false;
      private void btnDelete_Click(object? sender, EventArgs e)
      {
         if (!isDelete)
         {
            // Chuyển sang chế độ xóa
            isDelete = true;

            // Hiển thị cột checkbox
            dataGridViewColumnCheckBox.Visible = true;

            // Đổi tên nút thành "Hủy xóa"
            btnDelete.Text = "Hủy xóa";
            dgvConstruction.ClearSelection();
            txtName.Clear();
            txtYear.Clear();
            txtLocation.Clear();

            btnAdd.Click -= btnAdd_Click;
            btnEdit.Click -= btnEdit_Click;
            dgvConstruction.CellClick -= DgvConstruction_CellClick;

         }
         else
         {
            // Kiểm tra xem có dòng nào được chọn không
            bool hasCheckedRows = false;
            foreach (DataGridViewRow row in dgvConstruction.Rows)
            {
               if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                   Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
               {
                  hasCheckedRows = true;
                  break;
               }
            }

            if (hasCheckedRows)
            {
               // Nếu có dòng được chọn và nút đang hiển thị "Hủy xóa"
               if (btnDelete.Text == "Hủy xóa")
                  // Đổi tên nút thành "Xác nhận xóa"
                  btnDelete.Text = "Xác nhận xóa";
               else if (btnDelete.Text == "Xác nhận xóa")
               {
                  // Thực hiện xóa các dòng đã chọn
                  DeleteSelectedRows();

                  // Trở về trạng thái ban đầu
                  ResetDeleteMode();
               }
            }
            else
               // Không có dòng nào được chọn, trở về trạng thái ban đầu
               ResetDeleteMode();
         }
      }
      private void DeleteSelectedRows()
      {
         try
         {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa các công trình đã chọn?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               using SqlConnection connection = DatabaseHelper.GetConnection();
               connection.Open();

               // Tạo danh sách các ID cần xóa
               List<int> idsToDelete = [];
               foreach (DataGridViewRow row in dgvConstruction.Rows)
               {
                  if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                      Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
                  {
                     int id = Convert.ToInt32(row.Cells["dataGridViewColumnID"].Value);
                     idsToDelete.Add(id);
                  }
               }

               // Xóa từng công trình
               int deletedCount = 0;
               foreach (int id in idsToDelete)
               {
                  string query = "delete from CongTrinh where ID = @ID";
                  using SqlCommand command = new(query, connection);
                  command.Parameters.AddWithValue("@ID", id);
                  deletedCount += command.ExecuteNonQuery();
               }

               // Hiển thị thông báo thành công
               lblMessage.Text = $"Đã xóa {deletedCount} công trình thành công!";
               lblMessage.ForeColor = Color.Green;
               TimeIntervalMessage();


            }
         }
         catch (Exception ex)
         {
            lblMessage.Text = $"Lỗi: {ex.Message}";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
         }
      }
      private void ResetDeleteMode()
      {
         // Ẩn cột checkbox
         dataGridViewColumnCheckBox.Visible = false;

         // Đổi tên nút trở lại thành Xóa
         btnDelete.Text = "Xóa";

         // Đặt lại trạng thái
         isDelete = false;
         btnAdd.Click += btnAdd_Click;
         btnEdit.Click += btnEdit_Click;
         dgvConstruction.CellClick += DgvConstruction_CellClick;
         txtName.Focus(); // Đặt focus vào ô nhập tên công trình

         // Làm mới datagridview để xóa các lựa chọn
         LoadConstructionData();
      }
      private void DgvConstruction_CellContentClick(object? sender, DataGridViewCellEventArgs e)
      {
         // Kiểm tra xem người dùng có nhấp vào cột checkbox không
         if (e.ColumnIndex == dataGridViewColumnCheckBox.Index && e.RowIndex >= 0)
         {
            // Đảo ngược giá trị của ô checkbox
            bool currentValue = false;
            if (dgvConstruction.Rows[e.RowIndex].Cells["dataGridViewColumnCheckBox"].Value != null)
               currentValue = Convert.ToBoolean(dgvConstruction.Rows[e.RowIndex].Cells["dataGridViewColumnCheckBox"].Value);
            dgvConstruction.Rows[e.RowIndex].Cells["dataGridViewColumnCheckBox"].Value = !currentValue;

            // Kiểm tra xem có dòng nào được chọn không
            bool hasCheckedRows = false;
            foreach (DataGridViewRow row in dgvConstruction.Rows)
            {
               if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                   Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
               {
                  hasCheckedRows = true;
                  break;
               }
            }

            // Nếu có dòng được chọn và nút đang hiển thị "Hủy xóa"
            if (hasCheckedRows && btnDelete.Text == "Hủy xóa")
            // Đổi tên nút thành "Xác nhận xóa"
            {
               btnDelete.Text = "Xác nhận xóa";
               dataGridViewColumnCheckBox.HeaderText = "❎";
               dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Bỏ chọn tất cả";
            }
            else if (!hasCheckedRows && btnDelete.Text == "Xác nhận xóa")
            // Không còn dòng nào được chọn, đổi tên nút trở lại thành "Hủy xóa"
            {
               btnDelete.Text = "Hủy xóa";
               dataGridViewColumnCheckBox.HeaderText = "✅";
               dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";
            }
         }

         // Kiểm tra xem người dùng có nhấp vào header của cột checkbox không
         if (e.RowIndex == -1 && e.ColumnIndex == dataGridViewColumnCheckBox.Index)
         {
            // Kiểm tra xem có dòng nào đã được chọn chưa
            bool anyChecked = false;
            foreach (DataGridViewRow row in dgvConstruction.Rows)
            {
               if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                   Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
               {
                  anyChecked = true;
                  break;
               }
            }

            // Chọn hoặc bỏ chọn tất cả các dòng
            bool checkValue = !anyChecked;
            foreach (DataGridViewRow row in dgvConstruction.Rows)
               row.Cells["dataGridViewColumnCheckBox"].Value = checkValue;

            // Cập nhật tên nút
            if (checkValue)
            {
               dataGridViewColumnCheckBox.HeaderText = "❎";
               dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Bỏ chọn tất cả";
               btnDelete.Text = "Xác nhận xóa";
            }
            else
            {
               dataGridViewColumnCheckBox.HeaderText = "✅";
               dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";
               btnDelete.Text = "Hủy xóa";
            }
         }
      }
      private void DgvConstruction_SelectionChanged(object? sender, EventArgs e)
      {
         // Nếu cột checkbox đang hiển thị (đang ở chế độ xóa), không cho phép chọn dòng
         if (dataGridViewColumnCheckBox.Visible)
            dgvConstruction.ClearSelection();
         // dgvConstruction.CurrentCell = null;
      }
      private void btnExport_Click(object? sender, EventArgs e)
      {
         try
         {
            // Kiểm tra xem có dữ liệu để xuất không
            if (dgvConstruction.Rows.Count == 0)
            {
               lblMessage.Text = "Không có dữ liệu để xuất!";
               lblMessage.ForeColor = Color.Red;
               TimeIntervalMessage();
               return;
            }

            // Tạo SaveFileDialog để chọn vị trí lưu file
            SaveFileDialog saveFileDialog = new()
            {
               Filter = "Excel Files|*.xlsx",
               Title = "Lưu file Excel",
               FileName = $"DanhSachCongTrinh_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               // Tạo workbook mới
               using var workbook = new XLWorkbook();

               // Thêm worksheet
               var worksheet = workbook.Worksheets.Add("Danh sách công trình");

               // Đặt tiêu đề cho file Excel
               worksheet.Cell(1, 1).Value = "DANH SÁCH CÔNG TRÌNH";
               worksheet.Range(1, 1, 1, 4).Merge();
               worksheet.Cell(1, 1).Style.Font.Bold = true;
               worksheet.Cell(1, 1).Style.Font.FontSize = 16;
               worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

               // Thêm tiêu đề các cột
               worksheet.Cell(3, 1).Value = "STT";
               worksheet.Cell(3, 2).Value = "Tên công trình";
               worksheet.Cell(3, 3).Value = "Địa điểm";
               worksheet.Cell(3, 4).Value = "Năm thực hiện";

               // Định dạng tiêu đề cột
               var headerRange = worksheet.Range(3, 1, 3, 4);
               headerRange.Style.Font.Bold = true;
               headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
               headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
               headerRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
               headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

               // Đổ dữ liệu từ DataGridView vào Excel
               int rowCount = dgvConstruction.Rows.Count;
               for (int i = 0; i < rowCount; i++)
               {
                  worksheet.Cell(i + 4, 1).Value = i + 1; // STT
                  worksheet.Cell(i + 4, 2).Value = dgvConstruction.Rows[i].Cells["dataGridViewColumnName"].Value.ToString();
                  worksheet.Cell(i + 4, 3).Value = dgvConstruction.Rows[i].Cells["dataGridViewColumnLocation"].Value.ToString();
                  worksheet.Cell(i + 4, 4).Value = Convert.ToInt32(dgvConstruction.Rows[i].Cells["dataGridViewColumnYear"].Value);
               }

               // Định dạng dữ liệu
               var dataRange = worksheet.Range(4, 1, dgvConstruction.Rows.Count + 3, 4);
               dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
               dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

               // Căn giữa cột STT và Năm thực hiện
               worksheet.Column(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               worksheet.Column(4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

               // Tự động điều chỉnh độ rộng các cột
               worksheet.Columns().AdjustToContents();

               // Lưu file Excel
               workbook.SaveAs(saveFileDialog.FileName);

               lblMessage.Text = "Xuất Excel thành công!";
               lblMessage.ForeColor = Color.Green;
               TimeIntervalMessage();
            }
         }
         catch (Exception ex)
         {
            lblMessage.Text = $"Lỗi khi xuất Excel: {ex.Message}";
            lblMessage.ForeColor = Color.Red;
            TimeIntervalMessage();
         }
      }
   }
}