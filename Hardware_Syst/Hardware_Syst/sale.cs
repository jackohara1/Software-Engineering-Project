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
            status = "S";
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







        //Define getters
        public int getSale_id()
        {
            return sale_id;
        }

        public int getCustomer_id()
        {
            return customer_id;
        }

        public string getSaleDate()
        {
            return saleDate;
        }

        public String getStatus()
        {
            return status;
        }

        public decimal getSaleValue()
        {
            return saleValue;
        }


        //define a static method to get all data from Stock table
        public static DataSet getAllSale(DataSet DS, String OrderBy)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT sale_id, customer_id, sale_date, status, sale_value FROM Sale ORDER BY " + OrderBy;

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
        public void addSale()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            if (this.customer_id.Equals(0))
                   
            {
                String strSQL = "INSERT INTO Sale (Sale_Id, Staus,Sale_Value, Sale_Date) VALUES(" + this.sale_id +
                    ",'" + this.status + "'," + this.saleValue + ",'" + this.saleDate + "')";

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

            }

            else
            {
                String strSQL = "INSERT INTO Sale VALUES(" + this.sale_id+
                    "," + this.customer_id + ",'" + this.status + "'," +
                    this.saleValue + ",'" + this.saleDate + "')";

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

            }
   
            //close DB connection
            myConn.Close();
        }
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
        public static void refundSale(int Sale_id, decimal value)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Sale SET sale_value = (sale_value +" + value + ") WHERE sale_id = " + Sale_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}