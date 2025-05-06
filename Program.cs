using System;
using System.Windows.Forms;
using ConstructionWork.Helpers;

namespace ConstructionWork
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Khởi tạo database trước khi chạy form chính
            if (DatabaseHelper.InitializeDatabase())
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("Không thể khởi tạo database. Ứng dụng sẽ đóng.", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}