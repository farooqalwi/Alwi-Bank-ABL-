using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alwi_Bank__ABL_.Classes
{
    class MainClass
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void ShowWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
        }
    }
}
