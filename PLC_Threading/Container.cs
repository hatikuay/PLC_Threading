using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC_Threading
{
    public partial class Container : Form
    {

        private List<MainWindow> listMain;
        public Container()
        {
            InitializeComponent();
            listMain = new List<MainWindow>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listMain.Add(new MainWindow());
            listMain[listMain.Count - 1].MdiParent = this;
            listMain[listMain.Count - 1].Text = "Form " + listMain.Count.ToString();
            listMain[listMain.Count-1].Show();


        }

        private void Container_Load(object sender, EventArgs e)
        {

        }
    }
}
