using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPA01
{
    public static class GlobalVar
    {
        public const string GlobalString = "Important Text";   // グローバル定数

        static int _globalValue;
        public static int GlobalValue
        {                    // グローバル変数（プロパティ）
            get { return _globalValue; }
            set { _globalValue = value; }
        }

        public static bool GlobalBoolean;                  // グローバル変数
    }
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
