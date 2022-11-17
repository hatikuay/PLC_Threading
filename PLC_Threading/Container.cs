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
        
        public Container()
        {
            InitializeComponent();
            listMain = new List<MainWindow>();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listMain.Count !=5)
            {
                new Thread(openMenuItem).Start();
            }
            
        }

        private void openMenuItem()
        {
            listMain.Add(new MainWindow());
          //listMain[listMain.Count - 1].MdiParent = this;
            listMain[listMain.Count - 1].Text = "Form " + listMain.Count.ToString();
            listMain[listMain.Count - 1].ShowDialog();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            
        }
    }
}
