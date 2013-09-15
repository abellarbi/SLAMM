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
            this.tblFilesReconBindingSource.DataSource = db.tblFilesRecons;
        }
    }
}
