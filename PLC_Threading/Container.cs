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
            List<String> list = getNotExistFormText();
            if (list.Count != 0)
            {
                switch (list[0])
                {
                    case "MainWindow":
                        MainWindow mw = new MainWindow();
                        mw.MdiParent = this;
                        mw.Show();
                        break;
                    case "MainWindow1":
                        MainWindow1 mw1 = new MainWindow1();
                        mw1.MdiParent = this;
                        mw1.Show();
                        break;
                    case "MainWindow2":
                        MainWindow2 mw2 = new MainWindow2();
                        mw2.MdiParent = this;
                        mw2.Show();
                        break;
                    case "MainWindow3":
                        MainWindow3 mw3 = new MainWindow3();
                        mw3.MdiParent = this;
                        mw3.Show();
                        break;
                    case "MainWindow4":
                        MainWindow4 mw4 = new MainWindow4();
                        mw4.MdiParent = this;
                        mw4.Show();
                        break;
                }
            }
            /*
             Thread th = new Thread(openMenuItem);
                        th.Start();
             */

        }

        private List<String> getNotExistFormText() 
        {
            List<String> formList = new List<String> { "Container", "MainWindow", "MainWindow1", "MainWindow2", "MainWindow3", "MainWindow4" };

            foreach (Form form in Application.OpenForms)
            {
                foreach (string s in formList.ToList())
                {
                    if (form.Text == s)
                    {
                        formList.Remove(s);
                    }
                }
            }
            return formList;
        }
        

        private void openMenuItem()
        {
            MainWindow mw = new MainWindow();
            Application.Run(mw);

            /*listMain.Add(new MainWindow());
            sayi++;
            //listMain[listMain.Count - 1].MdiParent = this;
            listMain[listMain.Count - 1].Text = "Form " + sayi.ToString();
            listMain[listMain.Count - 1].ShowDialog();*/
        }

        private void Container_Load(object sender, EventArgs e)
        {
            
        }
    }
}
