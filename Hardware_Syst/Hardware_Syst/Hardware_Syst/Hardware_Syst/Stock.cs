using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Hardware_Syst
{
    class Stock
    {
        // instance variables
        private int stock_id;
        private string stock_name;
        private decimal cost_p;
        private decimal sale_p;
        private int qty;
        private int department_id;



        // no argument constructor
        public Stock()
        {
            stock_id = 0;
            stock_name = "";
            cost_p = 0;
            sale_p = 0;
            qty = 0;
            department_id = 1;


        }
        //Define setters
        public void setStock_id(int Stock_id)
        {
            this.stock_id = Stock_id;
        }
        public void setStock_name(String Stock_name)
        {
            this.stock_name = Stock_name;
        }

        public void setCost_p(decimal Cost_p)
        {
            this.cost_p = Cost_p;
        }

        public void setSale_p(decimal Sale_p)
        {
            this.sale_p = Sale_p;
        }

        public void setQty(int Qty)
        {
            this.qty = Qty;
        }

        public void setDepartment_id(int Department_id)
        {
            this.department_id = Department_id;
        }





        //Define getters
        public int getStock_id()
        {
            return stock_id;
        }

        public string getStock_name()
        {
            return stock_name;
        }

        public decimal getCost_p()
        {
            return cost_p;
        }

        public decimal getSale_p()
        {
            return sale_p;
        }

        public int getQty()
        {
            return qty;
        }

        public int getDepartment_id()
        {
            return department_id;
        }


        //define a static method to get all data from Stock table
        public static DataSet getAllStock(DataSet DS, String OrderBy)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT stock_id, stock_name, cost_p, sale_p, qty, department_id FROM Stock ORDER BY " + OrderBy;

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "ss");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }
        public static DataSet getSelectedStock(DataSet DS, String EnteredStock)
        {
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            
            String strSQL = "SELECT stock_id, stock_name FROM Stock WHERE stock_name LIKE '"+EnteredStock+"'";

            
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

           
            da.Fill(DS, "ss");

            
            conn.Close();

            
            return DS;
        }


        public static int getNextStock_id()
        {

            
            int intNextStockid;

           
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(stock_id) FROM Stock";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

             OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

           
            if (dr.IsDBNull(0))
                intNextStockid = 1;
            else
                intNextStockid = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            
            return intNextStockid;

        }
        public void addStock()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Stock VALUES(" + this.stock_id.ToString() +
                ",'" + this.stock_name.ToUpper() + "'," + this.cost_p + "," +
                this.sale_p + "," + this.qty + ",'" + this.department_id + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void StockTypeError()
        {
            MessageBox.Show("Stock Type was left blank");
        }
        public void StockNameError()
        {
            MessageBox.Show("Stock Name was left blank");
        }
        public void StockQtyError()
        {
            MessageBox.Show("Stock qty was left blank");
        }
    }
}
