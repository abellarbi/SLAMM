using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLAMM
{
    public partial class FrmReconStatus : Form
    {
        private int pathID = 0;

        public int PathID
        {
            get { return pathID; }
            set { pathID = value; }
        }

        SLAMMdbDataContext db = new SLAMMdbDataContext();

        public FrmReconStatus()
        {
            InitializeComponent();
        }

        private void FrmReconStatus_Load(object sender, EventArgs e)
        {
            this.tblFilesReconBindingSource.DataSource = db.tblFilesRecons.Where(p => p.PathId == PathID).OrderByDescending(p => p.InsertedOn).Take(30);
            tblFilesReconMarketBindingSource.DataSource = db.tblFilesRecon_Markets;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblFilesReconBindingSource.DataSource = db.tblFilesRecons.OrderByDescending(p => p.InsertedOn).Take(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
