using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.Model;
using FluentValidation.Results;
using Jaezer_POS_and_Inventory.View.User_Control;
using System.Threading;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmEditStockPrice : Form
    {
        StockinModel model = new StockinModel();
        StockInUC uc;
        frmLoadingScreen load = new frmLoadingScreen();
        StockIn obj = new StockIn();
        public frmEditStockPrice(List<int> StockIDs, StockInUC _uc)
        {
            InitializeComponent();
            StockinList(StockIDs);
            uc = _uc;
        }

        struct DataParams
        {
            public int Process;
            public int Delay;
        }

        private DataParams _inputParams;

        private void StockinList(List<int> StockIDs)
        {
            StockInDG.Rows.Clear();
            foreach (var item in model.GetStockInHistory(StockIDs).ProductList)
            {
                StockInDG.Rows.Add(item.StockID,StockInDG.Rows.Count +1,item.ReferenceNo, item.ProductName, item.DateArrival, item.DateExpiry, item.SupplierName);
            }

        }
        private void StockInDG_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Qty_KeyPress);
            string ColName = StockInDG.Columns[StockInDG.CurrentCell.ColumnIndex].Name;
            if (ColName == "CostPrice")
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Qty_KeyPress);
                }

            }
        }

        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockInDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockInDG.Rows.Count > 0)
            {
                switch (StockInDG.Columns[e.ColumnIndex].Name)
                {
                    case "delete":
                        StockInDG.Rows.Remove(StockInDG.CurrentRow);
                        int n = 1;
                        foreach (DataGridViewRow item in StockInDG.Rows)
                        {
                            item.Cells["nrows"].Value = n++;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            obj.ProductList.Clear();
            foreach (DataGridViewRow item in StockInDG.Rows)
            {
                obj.ProductList.Add(new StockIn
                {
                    StockID = int.Parse(item.Cells["StockID"].Value.ToString()),
                    ProductName = item.Cells["ProductNameSI"].Value.ToString(),
                    Price = item.Cells["CostPrice"].Value != null ? decimal.Parse(item.Cells["CostPrice"].Value.ToString()):0
                });
            }

            var rules = new StockInPriceValidator();
            var result = rules.Validate(obj);
            if (!result.IsValid)
            {
                string msg = string.Empty;
                foreach (var item in result.Errors)
                {
                    msg += $"{item.ErrorMessage} \n";
                }

                MessageBox.Show(msg);
                return;
            }


            if (!backgroundWorker.IsBusy)
            {
                _inputParams.Delay = 200;
                _inputParams.Process = obj.ProductList.Count();
                backgroundWorker.RunWorkerAsync(_inputParams);
                load.ShowDialog();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;
            try
            {
                foreach (var item in obj.ProductList)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        if (model.UpdateStockCostPrice(item))
                        {
                            backgroundWorker.ReportProgress(index++ * 100 / process);
                        }
                        Thread.Sleep(delay);
                    }

                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            load.pb.Value = e.ProgressPercentage;
            load.pb.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Stocks Successfully Updated", model.AppName);
            uc.StockInHistory();
            load.Close();
            this.Close();
        }
    }
}
