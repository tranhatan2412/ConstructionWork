using System;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ConstructionWork.Helpers
{
    public static class DatabaseHelper
    {
        // Chuỗi kết nối đến SQL Server (thay đổi thông tin server nếu cần)
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True; Trust Server Certificate=True";

        // Chuỗi kết nối đến database sau khi đã tạo
        public static string AppConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCongTrinh;Integrated Security=True; Trust Server Certificate=True";

        public static bool InitializeDatabase()
        {
            try
            {
                // Đường dẫn đến file SQL
                string scriptPath = Path.Combine(Application.StartupPath, "Database", "CreateDatabase.sql");

                // Kiểm tra file SQL có tồn tại không
                if (!File.Exists(scriptPath))
                {
                    MessageBox.Show("Không tìm thấy file script SQL để tạo database!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Đọc nội dung file SQL
                string script = File.ReadAllText(scriptPath);

                using SqlConnection connection = new(connectionString);
                connection.Open();

                // Chia file SQL thành các đoạn phân tách bởi "go"
                string[] batches = script.ToLower().Split("go", StringSplitOptions.RemoveEmptyEntries);

                foreach (string batch in batches)
                {
                    if (!string.IsNullOrWhiteSpace(batch))
                    {
                        using SqlCommand command = new(batch, connection);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo database: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new(AppConnectionString);
        }
    }
}