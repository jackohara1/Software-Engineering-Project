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
                setDepartment_id(dr.GetInt32(5));
                setStatus(dr.GetString(6));
               
            }
            //close db
            conn.Close();


        }


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
        public static DataSet getSelectedStockid(DataSet DS, String EnteredStock)
        {
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            
            String strSQL = "SELECT stock_id FROM Stock WHERE stock_name LIKE UPPER('"+EnteredStock+"%')";

             
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            
            OracleDataAdapter dc = new OracleDataAdapter(cmd);

           
            dc.Fill(DS, "ss");

            
            conn.Close();

            
            return DS;
        }
        public static DataSet getSelectedDepartment(DataSet DS, int DID)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT department_id FROM Department WHERE department_id=" +DID;


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }


        public static DataSet getMatchingStock(DataSet DS, String Name)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT stock_id, stock_name, Sale_P FROM Stock WHERE stock_name LIKE UPPER('" + Name + "%')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }
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
        public static DataSet getAvalableStock(DataSet DS, String Name)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT stock_id, stock_name, Sale_P FROM Stock WHERE stock_name LIKE UPPER('" + Name + "%') AND status = 'A'";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


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
                this.sale_p + "," + this.qty + "," + this.department_id + ",'"+this.status+"')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
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
        public static DataSet getStockAnalysis(DataSet DS, int Department)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT ST.stock_id, ST.stock_name, ST.cost_p, ST.sale_p, SUM(SI.qtysold),( ST.sale_p*SUM(SI.qtysold)) FROM Stock ST INNER JOIN SaleItems SI ON ST.Stock_id= SI.Stock_id WHERE department_id = " + Department;


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
        




    }
}
