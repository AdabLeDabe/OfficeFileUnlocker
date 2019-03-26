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

        private void bt_unlock_Click(object sender, EventArgs e)
        {
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(filename);
            Worksheet sheet = (Worksheet)wb.ActiveSheet;
            char[] pwd = new char[13];
            
            //algo du futur
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
                                                                pwd[0] = i;
                                                                pwd[1] = j;
                                                                pwd[2] = k;
                                                                pwd[3] = l;
                                                                pwd[4] = m;
                                                                pwd[5] = n;
                                                                pwd[6] = o;
                                                                pwd[7] = p;
                                                                pwd[8] = q;
                                                                pwd[9] = r;
                                                                pwd[10] = s;
                                                                pwd[11] = t;
                                                                pwd[12] = Convert.ToChar(0);
                                                                sheet.Unprotect(pwd);
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
