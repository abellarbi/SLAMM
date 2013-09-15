﻿using System;
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
    public partial class FrmSLAMM : Form
    {
        SLAMMdbDataContext dbSLAMM;

        private bool _hasSuperAccess = false;
        private string _currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Replace(@"DFA_PRIMARY\", "");

        public FrmSLAMM()
        {
            InitializeComponent();
        }

        private void FrmSLAMM_Load(object sender, EventArgs e)
        {
            SLAMMdbDataContext db = new SLAMMdbDataContext();
            RefreshData(db);

            _hasSuperAccess = IsSupervisor(_currentUser);

            //todo: testing only
            //_hasSuperAccess = false;

            if (_hasSuperAccess)
                bindingNavigatorDeleteItem.Enabled = true;
            else
            {
                panel1.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
            }


        }

        private bool IsSupervisor(string UserName)
        {
            if (UserName.ToLower().Contains("hnguyen") || UserName.ToLower().Contains("elgin"))
                return true;
            else
                return false;

//            String qry = string.Format(@"SELECT [HasSuperAccess]
//FROM [tblAccessControl_User] 
//WHERE [UserName] = '{0}'", UserName);

//            System.Data.DataTable dataTable1 = ExecuteDataTable(qry, OpsConnection());

//            if (dataTable1.Rows.Count == 0)
//                return false;
//            else
//            {
//                if (dataTable1.Rows[FIRST_ROW][0].ToString().Equals("True"))
//                    return true;
//                else
//                    return false;
//            }
        }

        private void RefreshData(SLAMMdbDataContext db)
        {
            dbSLAMM = db;
 
            tblFilesReconFunctionBindingSource.DataSource = db.tblFilesRecon_Functions;
            tblFilesReconMarketBindingSource.DataSource = db.tblFilesRecon_Markets;

            BuildTimeZoneComboBox(db);

            this.tblFilesRecon_LocationBindingSource.DataSource = db.tblFilesRecon_Locations;
            this.tblFilesRecon_LocationBindingSource.MoveLast();

        }

        private void BuildTimeZoneComboBox(SLAMMdbDataContext db)
        {
           
            var items = (from i in db.tblFilesRecon_Locations select i.TimeZone).Distinct();

            List<TimeZone> allTimeZones = new List<TimeZone>();

            foreach (var data in items)
            {
                allTimeZones.Add(new TimeZone(data.ToString(), data.ToString()));
                
            }
            timeZoneListBox.DataSource = allTimeZones;
            timeZoneListBox.DisplayMember = "timeZoneDecr";
            timeZoneListBox.ValueMember = "timeZoneDecr";
        }

        private void tblFilesRecon_LocationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbSLAMM.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLAMMdbDataContext db = new SLAMMdbDataContext();
            RefreshData(db);
            ClearValidation();

            panel1.Enabled = false;
            tblFilesRecon_LocationBindingNavigator.Enabled = true;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateRequired(arrivalTimeTextBox)) return;
            if (!ValidateRequired(this.datePatternTextBox)) return;
            if (!ValidateRequired(this.dateVariationTextBox)) return;
            if (!ValidateRequired(this.descriptionTextBox)) return;
            if (!ValidateRequired(this.emailNotificationTextBox)) return;
            if (!ValidateRequired(this.filePatternTextBox)) return;
            if (!ValidateRequired(this.pathTextBox)) return;
            
            //if (!ValidateRequired(this.pathTextBox)) return;
            //if (!ValidateRequired(this.pathTextBox)) return;

            // click Save on binding Navigator will not save data unless user move to another cell
            tblFilesRecon_LocationBindingNavigatorSaveItem_Click(sender, e);

            MessageBox.Show("Database Updated","Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);

            button1_Click(sender, e);

            ClearValidation();

        }

        private void ClearValidation()
        {
             ValidateRequired(arrivalTimeTextBox) ;
             ValidateRequired(this.datePatternTextBox) ;
             ValidateRequired(this.dateVariationTextBox) ;
             ValidateRequired(this.descriptionTextBox) ;
             ValidateRequired(this.emailNotificationTextBox) ;
             ValidateRequired(this.filePatternTextBox) ;
             ValidateRequired(this.pathTextBox);
        }


        //private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        //{
        //    RefreshBindingCombox();
        //}

        //private void RefreshBindingCombox()
        //{
        //    try
        //    {
        //        //var x = functionIdComboBox.SelectedValue;

        //        //tblFilesReconFunctionBindingSource.DataSource = dbSLAMM.tblFilesRecon_Functions;
        //        //tblFilesReconMarketBindingSource.DataSource = dbSLAMM.tblFilesRecon_Markets;

        //        //functionIdComboBox.Refresh();
        //        //marketIdComboBox.Refresh();

        //        ////////functionIdComboBox.Text = ((tblFilesRecon_Function)functionIdComboBox.SelectedItem).FunctionName;
        //        ////////marketIdComboBox.Text = ((tblFilesRecon_Market)marketIdComboBox.SelectedItem).Market;

        //        //functionIdComboBox.SelectedValue = ((tblFilesRecon_Function)functionIdComboBox.SelectedItem).FunctionId;
        //        //marketIdComboBox.SelectedValue = ((tblFilesRecon_Market)marketIdComboBox.SelectedItem).MarketId;

        //        //functionIdComboBox.SelectedText = functionIdComboBox.Text;
        //        //marketIdComboBox.SelectedText = marketIdComboBox.Text;

        //        //functionIdComboBox.Refresh();
        //        //marketIdComboBox.Refresh();

        //        //functionIdComboBox.SelectedValue = 0;
        //        //functionIdComboBox.Refresh();
        //        //functionIdComboBox.SelectedValue = x;
        //        //functionIdComboBox.Refresh();

        //        //x = marketIdComboBox.SelectedValue;

        //        //marketIdComboBox.SelectedValue = 0;
        //        //marketIdComboBox.Refresh();
        //        //marketIdComboBox.SelectedValue = x;
        //        //marketIdComboBox.Refresh();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


     
        //}

        //private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        //{
        //    RefreshBindingCombox();
        //}

        //private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        //{
        //    RefreshBindingCombox();
        //}

        //private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        //{
        //    RefreshBindingCombox();
        //}

        //private void functionIdComboBox_Leave(object sender, EventArgs e)
        //{
        //    //RefreshBindingCombox();
        //}

        //private void marketIdComboBox_Leave(object sender, EventArgs e)
        //{
        //    //RefreshBindingCombox();
        //}

        private void arrivalTimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequired((TextBox)(sender));
        }
        private bool ValidateRequired(TextBox tb1)
        {
            bool bStatus = true;
            if (tb1.Text == "")
            {
                errorProvider1.SetError(tb1, "Require");
                bStatus = false;
            }
            else
                errorProvider1.SetError(tb1, "");
            return bStatus;
        }

        private bool ValidateRequired(ComboBox tb1)
        {
            bool bStatus = true;
            if (tb1.Text == "")
            {
                errorProvider1.SetError(tb1, "Require");
                bStatus = false;
            }
            else
                errorProvider1.SetError(tb1, "");

            return bStatus;
        }

        private void datePatternTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequired((TextBox)(sender));
        }

        private void dateVariationTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequired((TextBox)(sender));
        }

        private void emailNotificationTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequired((TextBox)(sender));
        }

        private void filePatternTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequired((TextBox)(sender));
        }

        private void functionIdComboBox_Validating(object sender, CancelEventArgs e)
        {
            //ValidateRequired((ComboBox)(sender));
        }

        //private void marketIdComboBox_Validating(object sender, CancelEventArgs e)
        //{
        //    //ValidateRequired((ComboBox)(sender));
        //}

        private void pathTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequired((TextBox)(sender));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            functionIdListBox.SelectedIndex = 0;
            marketIdListBox.SelectedIndex = 0;
            timeZoneListBox.SelectedIndex = 0;

            this.tblFilesRecon_LocationBindingSource.MovePrevious();
            this.tblFilesRecon_LocationBindingSource.MoveNext();

            panel1.Enabled = true;
            tblFilesRecon_LocationBindingNavigator.Enabled = false;
            arrivalTimeTextBox.Focus();

        }

  

        //private void timeZoneComboBox_Validating(object sender, CancelEventArgs e)
        //{
        //    //ValidateRequired((ComboBox)(sender));

        //}

    }

    public class TimeZone
    {
        // Properties. 
        public string Name { get; private set; }
        public string TimeZoneDecr { get; private set; }


        // Constructor. 
        internal TimeZone(string name,
                        string timeZoneDecr)
        {
            Name = name;
            TimeZoneDecr = timeZoneDecr;

        }

 

    }

    //public class Place
    //{
    //    // Properties. 
    //    public string Name { get; private set; }
    //    public string State { get; private set; }
       

    //    // Constructor. 
    //    internal Place(string name,
    //                    string state)
                        
    //    {
    //        Name = name;
    //        State = state;
           
    //    }

    //    //List<Place> allPlaces = new List<Place>();

    //    //    // For each location, call the Web service method to get data. 
    //    //    foreach (string location in locations)
    //    //    {
    //    //        Place[] places = CallGetPlaceListMethod(location);
    //    //        allPlaces.AddRange(places);
    //    //    }

    //    //    return allPlaces.ToArray();

    //}
}
