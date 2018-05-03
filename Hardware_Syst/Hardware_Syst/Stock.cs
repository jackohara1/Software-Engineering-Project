using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

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
        private string status;
        // no argument constructor
        public Stock()
        {
            stock_id = 0;
            stock_name = "";
            cost_p = 0;
            sale_p = 0;
            qty = 0;
            department_id = 1;
            status = "A";
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
        public void setStatus(string Status)
        {
            this.status = Status;
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
        public string getStatus()
        {
            return status;
        }

        //retrieves all data about an item of stock in relation to stock id
        public void getStock(int StockID)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define SQL Query
            String strSQL = "SELECT * FROM Stock  WHERE stock_id = " + StockID;
            //execute query using Data Reader


           OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setStock_id(dr.GetInt32(0));
                setStock_name(dr.GetString(1));
                setQty(dr.GetInt32(2));
                setCost_p(dr.GetDecimal(3));
                setSale_p(dr.GetDecimal(4));
                setStatus(dr.GetString(5));
                setDepartment_id(dr.GetInt32(6));           
            }
            //close db
            conn.Close();
        }

        // sets the status of U (unavalable) to an item of stock that the user wishes to discontinue
        public static void discontinueStock(int StockID)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define SQL Query
            String strSQL = "UPDATE Stock SET status='U' WHERE stock_id = " + StockID;
            //execute query using Data Reader

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();


        }
        //selects all items of stock with a simular name to the name entered
        public static DataSet getMatchingStock(DataSet DS, String Name)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT stock_id, stock_name, Sale_P FROM Stock WHERE stock_name LIKE UPPER('" + Name + "%')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        } //selects all items of stock with a simular name to the name entered, with a status of A(avalable) and a quantity greater than zero
        public static DataSet getMatchingSaleStock(DataSet DS, String Name)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT stock_id, stock_name, Sale_P, qty FROM Stock WHERE stock_name LIKE UPPER('" + Name + "%')AND status = 'A' AND qty > 0";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }
        //selects all items of stock with a simular name to the name entered, with a status of A(avalable) 
        public static DataSet getAvalableStock(DataSet DS, String Name)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT stock_id, stock_name, Sale_P FROM Stock WHERE stock_name LIKE UPPER('" + Name + "%') AND status = 'A'";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }//retrieves the next stock id from stock file 
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
        //registers an item of stock in the stock file
        public void addStock()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Stock VALUES(" + this.stock_id.ToString() +
                ",'" + this.stock_name.ToUpper() + "'," + this.qty + "," + this.cost_p + "," +
                this.sale_p + ",'"+this.status+"'," + this.department_id + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //updates an old item of stock settin new values of name, cost price, sale price, quantity, department and status in relation to the stock id passed through 
        public void updateStock()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
             
            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET stock_name= '" 
                + this.stock_name.ToUpper() + "', cost_p= " + this.cost_p + ",sale_p= " +
                this.sale_p + ",qty= " + this.qty + ",department_id= " + this.department_id + ",status='" + this.status + "' WHERE stock_id = "+this.stock_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static void returnStock(int Stock_id, int amount)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET qty = (qty+"+amount+") WHERE stock_id = " + Stock_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //updates the quantity of a stock by subtracting the current quanty by the amount purchased 
        public static void replaceStock(int Stock_id, int amount)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET qty = (qty-" + amount + ") WHERE stock_id = " + Stock_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        //selects data from all items of stock including how many sales the item made from a selected department
        public static DataSet getStockAnalysis(DataSet DS, int Department)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT s.stock_id, stock_name, cost_p, sale_p, (SELECT SUM(qtysold)FROM Saleitems si WHERE s.stock_id = si.stock_id GROUP BY stock_id) FROM stock s WHERE department_id =" + Department+ "ORDER BY (SELECT SUM(qtysold)FROM Saleitems si WHERE s.stock_id = si.stock_id GROUP BY stock_id)";
            


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
        //retrieves all data from the stock file about a single item of stock in relation to the stock id
        public static DataSet getEnquiry(DataSet DS, int Stock_id)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT stock_id, stock_name, Cost_P, Sale_P, qty, department_name, status FROM Stock S INNER JOIN DEPARTMENT D ON S.department_id = D.department_id WHERE stock_id ="+ Stock_id;
    

            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }



    }
}
