using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Jaezer_POS_and_Inventory.Model
{
    class DashboardModel:DBConnection
    {
        public SummarySales getSumRpt()
        {
            var obj = new SummarySales();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        MySqlTransaction tr = con.BeginTransaction();
                        //Year Sales
                        cmd.CommandText = "select * from year_sales";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while(rd.Read())
                            {
                                obj.Year_sales.Add(new SummarySales() {
                                    Year = rd.GetString("yr"),
                                    Sales = rd.GetDecimal("total")
                                });
                            }
                        }
                        //Top Monthly Selling Items
                        cmd.CommandText = "select * from topsell_month order by sales asc limit 20";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                obj.MoTopSelling.Add(new SummarySales()
                                {
                                    Prod = rd.GetString("productName"),
                                    Sales = rd.GetDecimal("sales")
                                });
                            }
                        }

                        //Monthly Sales of the current year
                        cmd.CommandText = "select date_format(sdate, '%b') as mo, sum(total) as total_sales from sold_items where date_format(sdate, '%Y') = date_format(CURDATE(), '%Y') GROUP BY MONTH(sdate)";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while(rd.Read())
                            {
                                if (!rd.IsDBNull(0))
                                {
                                    obj.MonthlySales.Add(new SummarySales
                                    {
                                        Month = rd.GetString("mo"),
                                        Sales = rd.GetDecimal("total_sales")
                                    });
                                }
                            }
                        }

                        //Monthly Purchase of the current year
                        cmd.CommandText = "select * from monthly_purchase";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                obj.MonthlyPurchase.Add(new SummarySales()
                                {
                                    Month = rd.GetString("mo"),
                                    Purchases = rd.GetDecimal("totalPurchase")
                                });
                            }
                        }
                        //Daily Sales
                        cmd.CommandText = "SELECT (case when sum(total) > 0 then sum(total) ELSE 0 END)  as sdaily from sold_items where sdate = date_format(now(), '%Y-%m-%d')";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                    obj.Sales = rd.GetDecimal("sdaily");
                        }
                        //Product Lines
                        cmd.CommandText = "SELECT case when COUNT(productName) > 0 then COUNT(productName) else 0 end AS prodItems FROM tbl_product WHERE deleted = false";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                    obj.ProdItems = rd.GetInt32("prodItems");
                        }

                        //Total Onhand
                        cmd.CommandText = "SELECT case when SUM(onhand) > 0 then SUM(onhand) else 0 end AS onhand FROM inventory ";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                    obj.Onhand = rd.GetInt32("onhand");
                        }

                        //Critical Items
                        cmd.CommandText = "SELECT case when  COUNT(productName)  > 0 then  COUNT(productName)  else 0 end AS critItems FROM inventory WHERE onhand <= reorder";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                    obj.CritItems = rd.GetInt32("critItems");
                        }

                        //Expiry Items
                        cmd.CommandText = "SELECT case when COUNT(productName) > 0 then COUNT(productName) else 0 end  AS expItems FROM expiry_products r";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                    obj.ExpItems = rd.GetInt32("expItems");
                        }
                        tr.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return obj;
        }
    }

    public class SummarySales
    {
        public decimal Sales { get; set; }
        public decimal Purchases { get; set; }
        public int ProdItems { get; set; }
        public int Onhand { get; set; }
        public int CritItems { get; set; }
        public int ExpItems { get; set; }
        public string Prod { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }

        public List<SummarySales> Year_sales = new List<SummarySales>();
        public List<SummarySales> MoTopSelling = new List<SummarySales>();
        public List<SummarySales> MonthlyPurchase = new List<SummarySales>();
        public List<SummarySales> MonthlySales = new List<SummarySales>();
    }

}
