using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CallLogAnalyser
{
    public partial class FrmCallLogAnalysis : Form
    {
        public FrmCallLogAnalysis()
        {
            InitializeComponent();
            
        }   

        private void btnResetTime_Click(object sender, EventArgs e)
        {
            dtpFromTime.Value = new DateTime(dtpFromDate.MinDate.Year, dtpFromDate.MinDate.Month, dtpFromDate.MinDate.Day, 0, 0, 0);
            dtpToTime.Value = new DateTime(dtpFromDate.MinDate.Year, dtpFromDate.MinDate.Month, dtpFromDate.MinDate.Day, 23, 59, 59);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string errorMsg = ValidateCriteriaInput();
            if (errorMsg != null)
            {
                MessageBox.Show("Invalid Input:\n\n" + errorMsg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CallLogCriteria criteria = new CallLogCriteria();
            InitializeCriteriaBO(criteria);

            DataGridViewRow[] logTable = new DataGridViewRow[dgInputCallLog.Rows.Count];
            dgInputCallLog.Rows.CopyTo(logTable, 0);
            FilterWorker worker = new FilterWorker();

            IEnumerable<DataGridViewRow> filteredRows = worker.Work(logTable, criteria);

            PopulateFilteredDataGrid(filteredRows);

            LoadCriteriaInputDropDowns(dgFilteredCallLog);
        }

        private void PopulateFilteredDataGrid(IEnumerable<DataGridViewRow> filteredRows)
        {
            dgFilteredCallLog.Rows.Clear();
            DataGridViewRow newRow = new DataGridViewRow();

            foreach (DataGridViewRow row in filteredRows)
            {
                newRow = (DataGridViewRow)row.Clone();
                int intColIndex = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    newRow.Cells[intColIndex].Value = cell.Value;
                    intColIndex++;
                }

                dgFilteredCallLog.Rows.Add(newRow);
            }
        }

        private void DisableInputControls()
        {
            cmbCallerMobileNumber.Enabled = false;
            cmbCalleeMobileNumber.Enabled = false;
            dtpFromDate.Enabled = false;
            dtpToDate.Enabled = false;
            dtpFromTime.Enabled = false;
            dtpToTime.Enabled = false;
            cmbTowerId.Enabled = false;
            cmbImeiNumber.Enabled = false;
        }

        private void InitializeCriteriaBO(CallLogCriteria criteria)
        {
            if (chkCallerNumber.Checked)
            {
                criteria.FromMobileNumber = cmbCallerMobileNumber.Text;
            }

            if (chkCalleeMobileNumber.Checked)
            {
                criteria.ToMobileNumber = cmbCalleeMobileNumber.Text;
            }

            if (chkFromDate.Checked)
            {
                criteria.FromDate = dtpFromDate.Value;
            }

            if (chkToDate.Checked)
            {
                criteria.ToDate = dtpToDate.Value;
            }

            if (chkFromTime.Checked)
            {
                criteria.FromTime = dtpFromTime.Value;
            }

            if (chkToTime.Checked)
            {
                criteria.ToTime = dtpToTime.Value;
            }

            if (chkStartTower.Checked)
            {
                criteria.TowerId = cmbTowerId.Text;
            }

            if (chkImeiNumber.Checked)
            {
                criteria.IMEINumber = cmbImeiNumber.Text;
            }

        }

        private string ValidateCriteriaInput()
        {
            string errorMsg = null;

            if (dtpFromDate.Enabled && dtpToDate.Enabled)
            {
                if (dtpToDate.Value < dtpFromDate.Value)
                {
                    errorMsg += "\"From Date\" should be less than or equal to \"To Date\"";
                }
            }

            if (dtpFromTime.Enabled && dtpToTime.Enabled)
            {
                if (dtpToTime.Value < dtpFromTime.Value)
                {
                    errorMsg += "\n\"From Time\" should be less than or equal to \"To Time\"";
                }
            }

            if (cmbCallerMobileNumber.Enabled && cmbCalleeMobileNumber.Enabled)
            {
                if (cmbCallerMobileNumber.Text == cmbCalleeMobileNumber.Text)
                {
                    errorMsg += "\n\"Caller Mobile number\" and \"Callee Mobile number\" should be different";
                }
            }

            if (chkCallerNumber.Checked && cmbCallerMobileNumber.Text == "")
            {
                errorMsg += "\n\"Caller mobile number can not be blank\" ";
            }

            if (chkCalleeMobileNumber.Checked && cmbCalleeMobileNumber.Text == "")
            {
                errorMsg += "\n\"Caller mobile number can not be blank\" ";
            }

            if (chkImeiNumber.Checked && cmbImeiNumber.Text == "")
            {
                errorMsg += "\n\"IMEI number can not be blank\" ";
            }

            return errorMsg;
        }

        private void PasteClipboardToDataGrid()
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dgInputCallLog.RowCount > 0)
                    dgInputCallLog.Rows.Clear();
                
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    dgInputCallLog.Rows.Add();
                    int myRowIndex = dgInputCallLog.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dgInputCallLog.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
            }

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            PasteClipboardToDataGrid();

            LoadCriteriaInputDropDowns(dgInputCallLog);
        }

        private void LoadCriteriaInputDropDowns(DataGridView sourceDataGrid)
        {
            cmbCallerMobileNumber.Items.Clear();
            cmbCalleeMobileNumber.Items.Clear();
            cmbTowerId.Items.Clear();
            cmbImeiNumber.Items.Clear();
            
            string callerMobileNumber = null;
            string calleeMobileNumber = null;
            string fromTowerId = null;
            string toTowerId = null;
            string callerImeiNumber = null;
            string calleeImeiNumber = null;

            foreach (DataGridViewRow row in sourceDataGrid.Rows)
            {
                callerMobileNumber = row.Cells[1].Value.ToString().Trim();
                calleeMobileNumber = row.Cells[2].Value.ToString().Trim();

                fromTowerId = row.Cells[6].Value.ToString().Trim();
                toTowerId = row.Cells[7].Value.ToString().Trim();

                callerImeiNumber = row.Cells[9].Value.ToString().Trim();
                calleeImeiNumber = row.Cells[10].Value.ToString().Trim();

                // Add unique Caller's Mobile number
                if (cmbCallerMobileNumber.FindStringExact(callerMobileNumber) == -1)
                {
                    cmbCallerMobileNumber.Items.Add(callerMobileNumber);
                }

                // Add unique Callee's Mobile number
                if (cmbCalleeMobileNumber.FindStringExact(calleeMobileNumber) == -1)
                {
                    cmbCalleeMobileNumber.Items.Add(calleeMobileNumber);
                }

                // Add unique TowerId into the TowerId dropdown
                if (cmbTowerId.FindStringExact(fromTowerId) == -1)
                {
                    cmbTowerId.Items.Add(fromTowerId);
                }

                if (cmbTowerId.FindStringExact(toTowerId) == -1)
                {
                    cmbTowerId.Items.Add(toTowerId);
                }

                // Add unique IMEI number into the IMEI dropdown
                if (cmbImeiNumber.FindStringExact(callerImeiNumber) == -1)
                {
                    cmbImeiNumber.Items.Add(callerImeiNumber);
                }

                if (cmbImeiNumber.FindStringExact(calleeImeiNumber) == -1)
                {
                    cmbImeiNumber.Items.Add(calleeImeiNumber);
                }

            }
        }
        
        #region "Checkbox CheckedChanged events"
        private void chkFromMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            cmbCallerMobileNumber.Enabled = chkCallerNumber.Checked;
        }

        private void chkToMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            cmbCalleeMobileNumber.Enabled = chkCalleeMobileNumber.Checked;
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkFromDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFromDate.Enabled = chkFromDate.Checked;
        }

        private void chkToDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = chkToDate.Checked;
        }

        private void dtpFromTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkFromTime_CheckedChanged(object sender, EventArgs e)
        {
            dtpFromTime.Enabled = chkFromTime.Checked;
        }

        private void chkToTime_CheckedChanged(object sender, EventArgs e)
        {
            dtpToTime.Enabled = chkToTime.Checked;
        }

        private void chkStartTower_CheckedChanged(object sender, EventArgs e)
        {
            cmbTowerId.Enabled = chkStartTower.Checked;
        }

        private void chkImeiNumber_CheckedChanged(object sender, EventArgs e)
        {
            cmbImeiNumber.Enabled = chkImeiNumber.Checked;
        }


        #endregion

        private void FrmCallLogAnalysis_Load(object sender, EventArgs e)
        {
            DisableInputControls();
        }
    }
}
