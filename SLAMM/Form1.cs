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
        SLAMMdbDataContext db = new SLAMMdbDataContext();

        public Form1()
        {

            InitializeComponent();
            
            
            //this.tblFilesRecon_FunctionBindingSource.DataSource = db.tblFilesRecon_Functions;

            tblFilesReconFunctionBindingSource.DataSource = db.tblFilesRecon_Functions;
            tblFilesReconMarketBindingSource.DataSource = db.tblFilesRecon_Markets;

            FillTheList();

            RefreshData();

            SetStateNavigate(false);
    
        }

        private void RefreshData()
        {
            //db = new SLAMMdbDataContext();

            var x = (from p in db.tblFilesRecon_Functions select p);

            this.tblFilesRecon_LocationBindingSource.DataSource = db.tblFilesRecon_Locations;
        }

        private void FillTheList()
        {

            var items = (from i in db.tblFilesRecon_Locations select i.TimeZone).Distinct();
            
            foreach (var data in items)
            {
                timeZoneComboBox.Items.Add(data.ToString());
            }    

            //var items2 = (from i in db.tblFilesRecon_Locations select i.DatePattern).Distinct();

            //foreach (var data in items2)
            //{
            //    datePatternComboBox.Items.Add(data.ToString());
                        
            //}    

            
        }

        private void tblFilesRecon_LocationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            db.SubmitChanges();
            RefreshData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SetStateNavigate(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try 
	            {
                    tblFilesRecon_LocationBindingNavigatorSaveItem_Click(sender, e);
                    SetStateNavigate(false);
	            }
	            catch (Exception ex)
	            {

                    MessageBox.Show(ex.ToString());
	            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                SetStateNavigate(false);
                RefreshData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void SetStateNavigate(bool NavigateState)
        {
            splitContainer1.Panel1.Enabled = NavigateState;
            tblFilesRecon_LocationDataGridView.Enabled = !NavigateState;
            //tblFilesRecon_LocationBindingNavigator.Enabled = !NavigateState;
        }

    }
}
