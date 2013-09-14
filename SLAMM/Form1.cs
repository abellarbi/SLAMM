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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
            SLAMMdbDataContext db = new SLAMMdbDataContext();
            //this.tblFilesRecon_FunctionBindingSource.DataSource = db.tblFilesRecon_Functions;

            var x = (from p in db.tblFilesRecon_Functions select p);

            this.tblFilesRecon_LocationBindingSource.DataSource = db.tblFilesRecon_Locations;
    
        }

        private void tblFilesRecon_LocationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
