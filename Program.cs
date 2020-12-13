using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

	static class AppState
	{
		const int questionsCount = 14;
		bool[] isAnswerCorrect;
		public AppState()
		{
			isAnswerCorrect = new bool[questionsCount]
		}
	}

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
	    appState = new AppState;
            Application.Run(new Form1(appState));
        }
    }
}
