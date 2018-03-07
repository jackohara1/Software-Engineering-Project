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
        // instance variables
        private int saleitem_id;
        private int qtysold;
        private decimal price;
        private int sale_id;
        private int stock_id;
        private string status;




        // no argument constructor
        public Saleitem()
        {
            saleitem_id = 0;
            qtysold = 0;
            price = 0;
            sale_id = 0;
            stock_id = 0;
            status = "";

        }
        //Define setters
        public void setSaleitem_id(int Saleitem_id)
        {
            this.saleitem_id = Saleitem_id;
        }
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
        public void setStatus(string Status)
        {
            this.status = Status;
        }






        //Define getters
        public int getSaleitem_id()
        {
            return saleitem_id;
        }

        public int getQtysold()
        {
            return qtysold;
        }

        public decimal getPrice()
        {
            return price;
        }

        public int Sale_ID()
        {
            return sale_id;
        }

        public decimal getStock_ID()
        {
            return stock_id;
        }
        public string getStatus()
        {
            return status;
        }

        //define a static method to get all data from Stock table
        public static DataSet getAllSaleItem(DataSet DS, String OrderBy)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT saleitem_id, qtysold, price, sale_id, stock_id FROM Saleitems ORDER BY " + OrderBy;

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

        public static DataSet getMatchingSaleItem(DataSet DS, int Sale_id)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT stock_id, stock_name, qtysold, price FROM Saleitems WHERE sale_id = " + Sale_id;

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


        public static int getNextSaleitem_id()
        {


            int intNextSaleid;


            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Saleitem_id) FROM Saleitems";

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
        public void addSaleitems()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Saleitems VALUES(" + this.saleitem_id +
                "," + this.qtysold + ",'" + this.price + "," +
                this.sale_id + "'," + this.stock_id + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

    }
}