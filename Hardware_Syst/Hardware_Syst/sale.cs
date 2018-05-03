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
    class Sale
    {
        // instance variables
        private int sale_id;
        private int customer_id;
        private String saleDate;
        private String status;
        private decimal saleValue;




        // no argument constructor
        public Sale()
        {
            sale_id = 0;
            customer_id = 0;
            saleDate = "0/0/00";
            status = "U";
            saleValue = 0;

        }
        //Define setters
        public void setSale_id(int Sale_id)
        {
            this.sale_id = Sale_id;
        }
        public void setCustomer_id(int Customer_id)
        {
            this.customer_id = Customer_id;
        }

        public void setSaleDate(String SaleDate)
        {
            this.saleDate = SaleDate;
        }

        public void setStatus(String Status)
        {
            this.status = Status;
        }
        public void setSaleValue(decimal SaleValue)
        {
            this.saleValue = SaleValue;
        }

        //Retrieves the next sale id
        public static int getNextSale_id()
        {
            int intNextSaleid;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Sale_id) FROM Sale";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            if (dr.IsDBNull(0))
                intNextSaleid = 1;
            else
                intNextSaleid = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();


            return intNextSaleid;

        }
        //registers a sale in the database
        public void addSale()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            if (this.customer_id.Equals(0))
                   
            {
                String strSQL = "INSERT INTO Sale (Sale_Id, Sale_Date, status, Sale_Value) VALUES(" + this.sale_id +
                      "," + this.saleValue + ",'" +  this.saleDate + "','" + this.status + "')";

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

            }

            else
            {
                String strSQL = "INSERT INTO Sale VALUES(" + this.sale_id +",'" + this.saleDate + 
                   "','"+this.status +"'," + this.customer_id + "," + this.saleValue +")";

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

            }
   
            //close DB connection
            myConn.Close();
        }
        //updates the sale value of a sale due to an item being returned
        public static void returnSale(int Sale_id, decimal value)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Sale SET sale_value = (sale_value -" + value + ") WHERE sale_id = " + Sale_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        //updates the status of a customers purchases from U(unpayed) to P(Payed)
        public static void invoicePayed(int Sale_id)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define SQL Query
            String strSQL = "UPDATE Sale SET status='P' WHERE sale_id = " + Sale_id;
            //execute query using Data Reader

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();


        }
        //Desplays all sales the customer has made in the shop during a selected year
        public static DataSet getSaleAnalysisCust(DataSet DS, String Date, int CustID)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT sale_id, sale_value, status, sale_date FROM Sale S INNER JOIN Customer C ON S.Customer_id= C.Customer_id WHERE sale_date LIKE '%" +Date+ "' AND S.Customer_id = "+CustID;



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

        //displays all sales that take place on the system during a selected year
        public static DataSet getSaleAnalysis(DataSet DS, String Date)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT sale_id, sale_value, sale_date FROM Sale  WHERE sale_date LIKE '%" + Date+"' AND Status = 'P'";



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
        //desplays a chart of all the sales that have been payed for during a selected year it is organized by month and value
        public static decimal getSaleAnalysisChart(DataSet DS, String Date)
        {

            decimal totalSales;
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT  SUM(sale_value) FROM Sale WHERE sale_date LIKE '%" + Date + "' AND Status = 'P'";



            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            if (dr.IsDBNull(0))
                totalSales = 0;
            else
                totalSales = Convert.ToDecimal(dr.GetValue(0)) + 1;

            conn.Close();


            return totalSales;
        }
        //displays a chart of all sales that a customer has payed for throughout the year
        public static decimal getSaleCustomerChart(DataSet DS, String Date, int CustId)
        {

            decimal totalSales;
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT  SUM(sale_value) FROM Sale WHERE sale_date LIKE '%" + Date + "' AND Customer_ID = " + CustId + " AND Status = 'P'";



            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            if (dr.IsDBNull(0))
                totalSales = 0;
            else
                totalSales = Convert.ToDecimal(dr.GetValue(0)) + 1;

            conn.Close();


            return totalSales;
        }
        //displays a chart of the amount of sales an item of stock has made throughout the year ordered by month 
        public static decimal getStockSales(DataSet DS, String Date, int StockId)
        {

            decimal totalSales;
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT SUM(qtySold) FROM SaleItems SI INNER JOIN Sale S ON SI.Sale_id = S.Sale_id WHERE stock_id = " + StockId+ " AND sale_date LIKE '%" + Date + "'";



            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            if (dr.IsDBNull(0))
                totalSales = 0;
            else
                totalSales = Convert.ToDecimal(dr.GetValue(0)) + 1;

            conn.Close();


            return totalSales;
        }
    }
}