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
    class Saleitem
    {
     
        private int sale_id;
        private int stock_id;
        private int qtysold;
        private decimal price;



        // no argument constructor
        public Saleitem()
        {
            sale_id = 0;
            stock_id = 0;
            qtysold = 0;
            price = 0;
        }
   
        //Define setters
    
        public void setQtysold(int Qtysold)
        {
            this.qtysold = Qtysold;
        }

        public void setPrice(decimal Price)
        {
            this.price = Price;
        }

        public void setSale_id(int Sale_id)
        {
            this.sale_id = Sale_id;
        }
        public void setStock_id(int Stock_id)
        {
            this.stock_id = Stock_id;
        }




        public static DataSet getMatchingSaleItem(DataSet DS, int Sale_id)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT SI.stock_id, stock_name, qtysold, price FROM Saleitems SI JOIN Stock S ON SI.Stock_id= S.Stock_id WHERE sale_id = " + Sale_id;

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

        public static DataSet getMatchingInvoice(DataSet DS, int Customer_id)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT SI.sale_id, SI.stock_id, S.stock_name, SI.price, SI.qtysold, (SI.price*SI.qtysold), SA.sale_date FROM ((Saleitems SI INNER JOIN Sale SA ON SI.Sale_id= SA.Sale_id) INNER JOIN Stock S ON SI.stock_id = S.stock_id) WHERE SA.customer_id = " + Customer_id + " AND SA.status = 'U'";


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


        public void addSaleitem()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Saleitems VALUES("+this.qtysold +
                "," + this.price + "," + this.sale_id + "," +
                this.stock_id +")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public static void returnStock(int Stock_id, int amount, int Sale_id)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Saleitems SET qtysold = qtysold -" + amount + " WHERE stock_id = " + Stock_id+"And sale_id = "+Sale_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

   
    }
}