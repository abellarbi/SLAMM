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
    public partial class FrmMarket : Form
    {
        SLAMMdbDataContext db = new SLAMMdbDataContext();

        public FrmMarket()
        {
            InitializeComponent();
        }

        private void FrmMarket_Load(object sender, EventArgs e)
        {
            this.tblFilesRecon_MarketBindingSource.DataSource = db.tblFilesRecon_Markets;
        }

        private void tblFilesRecon_MarketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
