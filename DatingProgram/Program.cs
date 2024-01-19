using System;
using System.Windows.Forms;
using DatingProgram.Forms;

namespace DatingProgram
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // создаём запускаем программу, стартуя с главного меню, которое тут же и создаём
            Application.Run(new Forms.MainMenu()); 
        }
    }
}
