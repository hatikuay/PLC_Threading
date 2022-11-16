using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PLC_Threading
{
    public partial class Container : Form
    {

        public List<MainWindow> listMain;
        public int sayi = 0;
        public Container()
        {
            InitializeComponent();
            listMain = new List<MainWindow>();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listMain.Count != 5) {
                if (listMain.Count == 0) {
                    Thread th1 = new Thread(openMenuItem);
                    th1.Start();
                }
                foreach (var item in listMain) {
                    if (item.Text == "Form 1") {
                        Thread th2 = new Thread(openMenuItem);
                        th2.Start();
                        break;
                    } else if (item.Text == "Form 2") {
                        Thread th3 = new Thread(openMenuItem);
                        th3.Start();
                        break;
                    } else if (item.Text == "Form 3") {
                        Thread th4 = new Thread(openMenuItem);
                        th4.Start();
                        break;
                    }
                    else if (item.Text == "Form 4") {
                        Thread th3 = new Thread(openMenuItem);
                        th3.Start();
                        break;
                    }
                }
            }
            Debug.WriteLine(sayi);
        }

        private void openMenuItem()
        {
            listMain.Add(new MainWindow());
            sayi++;
            //listMain[listMain.Count - 1].MdiParent = this;
            listMain[listMain.Count - 1].Text = "Form " + sayi.ToString();
            listMain[listMain.Count - 1].ShowDialog();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            
        }
    }
}
