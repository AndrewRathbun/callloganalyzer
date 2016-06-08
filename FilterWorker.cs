using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CallLogAnalyser
{
    class FilterWorker
    {
        public IEnumerable<DataGridViewRow> Work(DataGridViewRow[] inputTable, CallLogCriteria criteria)
        {
            var filteredRows = (from row in inputTable
                                select row);

            // Filter all outgoing calls from given number
            if (criteria.FromMobileNumber != null)
            {
                filteredRows = filteredRows.Where(row => row.Cells[1].Value.ToString().Contains(criteria.FromMobileNumber));
            }

            // Filter all incoming calls for a given number
            if (criteria.ToMobileNumber != null)
            {
                filteredRows = filteredRows.Where(row => row.Cells[2].Value.ToString().Contains(criteria.ToMobileNumber));
            }

            // Filter all calls which were made in given tower Id (Either call started / ended on the given tower Id)
            if (criteria.TowerId != null)
            {
                filteredRows = filteredRows.Where(row => row.Cells[6].Value.ToString().Contains(criteria.TowerId) || row.Cells[7].Value.ToString().Contains(criteria.TowerId));
            }

            // // Filter on Date range 
            if (criteria.FromDate != null && criteria.ToDate != null)
            {
                filteredRows = filteredRows.Where(row => DateTime.Parse(row.Cells[3].Value.ToString()) >= criteria.FromDate.Value.Date &&
                                                         DateTime.Parse(row.Cells[3].Value.ToString()) <= criteria.ToDate.Value.Date);
            }
            else if (criteria.FromDate != null)
            {
                filteredRows = filteredRows.Where(row => DateTime.Parse(row.Cells[3].Value.ToString()) >= criteria.FromDate.Value.Date);
            }
            else if (criteria.ToDate != null)
            {
                filteredRows = filteredRows.Where(row => DateTime.Parse(row.Cells[3].Value.ToString()) <= criteria.ToDate.Value.Date);
            }

            // Filter on Time range 
            if (criteria.FromTime != null && criteria.ToTime != null)
            {
                filteredRows = filteredRows.Where(row => DateTime.Parse(row.Cells[4].Value.ToString()) >= criteria.FromTime &&
                                                         DateTime.Parse(row.Cells[4].Value.ToString()) <= criteria.ToTime);
            }
            else if (criteria.FromTime != null)
            {
                filteredRows = filteredRows.Where(row => DateTime.Parse(row.Cells[4].Value.ToString()) >= criteria.FromTime);
            }
            else if (criteria.ToTime != null)
            {
                filteredRows = filteredRows.Where(row => DateTime.Parse(row.Cells[4].Value.ToString()) <= criteria.ToTime);
            }

            // Filter all calls which were made using mobile of given IMEI number (Either caller or callee's mobile IMEI is matched)
            if (criteria.IMEINumber != null)
            {
                filteredRows = filteredRows.Where(row => row.Cells[9].Value.ToString().Contains(criteria.IMEINumber)
                                                         || row.Cells[10].Value.ToString().Contains(criteria.IMEINumber));
            }

            return filteredRows;
        }
    }
}
