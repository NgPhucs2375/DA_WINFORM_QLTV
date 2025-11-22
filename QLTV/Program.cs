using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public static class Program
    {
        public static int CurrentUserId;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());
            //Application.Run(new LapPhieuMuon());
            //Application.Run(new LapPhieuTra());
            //Application.Run(new QuanLySach());
            //Application.Run(new QuanLyDG());
            Application.Run(new Form1());
            //Application.Run(new QuanLyNV());
            //Application.Run(new BaoCao_ThongKe());



        }
    }
}
