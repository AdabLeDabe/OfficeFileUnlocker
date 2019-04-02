using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace OfficeFileUnlocker
{
    public partial class MainForm : Form
    {
        string filepath = @"C:\";
        string filename = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = filepath;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog.FileName;
                    lbl_filename.Text = "File name: " + filename;
                }
            }
        }

        private void bruteforce()
        {
            Application excel = new Application();
            var wbs = excel.Workbooks;
            Workbook wb = wbs.Open(filename);
            Worksheet sheet = (Worksheet)wb.ActiveSheet;

            //vba scripts:
            //http://jsbi.blogspot.com/2008/09/how-to-easily-unprotectremove-password.html
            //https://exceloffthegrid.com/removing-cracking-excel-passwords-with-vba/
            //details sur la methode de hash d'excel
            //https://stackoverflow.com/questions/19953979/cracking-sheet-password-with-vba/19958159
        }

        private void bt_unlock_Click(object sender, EventArgs e)
        {
            bruteforce();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void old_algo()
        {
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(filename);
            Worksheet sheet = (Worksheet)wb.ActiveSheet;
            string pwd = "";

            //algo du futur
            //solution alternative: https://stackoverflow.com/questions/15196534/is-there-a-way-to-add-vba-macro-code-to-excel
            //unlocker le VBA: https://stackoverflow.com/questions/1026483/is-there-a-way-to-crack-the-password-on-an-excel-vba-project?rq=1

            for (char i = 'A'; i < 67; ++i)
                for (char j = 'A'; j < 67; ++j)
                    for (char k = 'A'; k < 67; ++k)
                        for (char l = 'A'; l < 67; ++l)
                            for (char m = 'A'; m < 67; ++m)
                                for (char n = 'A'; n < 67; ++n)
                                    for (char o = 'A'; o < 67; ++o)
                                        for (char p = 'A'; p < 67; ++p)
                                            for (char q = 'A'; q < 67; ++q)
                                                for (char r = 'A'; r < 67; ++r)
                                                    for (char s = 'A'; s < 67; ++s)
                                                        for (char t = ' '; t < 127; ++t)
                                                        {
                                                            try
                                                            {
                                                                pwd = "";
                                                                pwd += i;
                                                                pwd += j;
                                                                pwd += k;
                                                                pwd += l;
                                                                pwd += m;
                                                                pwd += n;
                                                                pwd += o;
                                                                pwd += p;
                                                                pwd += q;
                                                                pwd += r;
                                                                pwd += s;
                                                                pwd += t;
                                                                lbl_password.Text = "Password: " + pwd;
                                                                sheet.Unprotect(pwd.ToCharArray());
                                                                if (sheet.ProtectContents == false)
                                                                {
                                                                    lbl_password.Text = "Password: " + pwd;
                                                                    return;
                                                                }
                                                            }
                                                            catch
                                                            {

                                                            }
                                                        }
        }
    }
}
