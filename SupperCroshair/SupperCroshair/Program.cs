using System;
using System.Windows.Forms;

namespace CrosshairApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Создаем и запускаем форму
                var form = new Form1();
                Application.Run(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запуска приложения:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}