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
    class Customer
    {
        // instance variables
        private int customer_id;
        private string forename;
        private string surname;
        private string addln1;
        private string addln2;
        private string addln3;
        private decimal balance;



        // no argument constructor
        public Customer()
        {
            customer_id = 0;
            forename = "";
            surname = "";
            addln1 = "";
            addln2 = "";
            addln3 = "";
            balance = 0;


        }
        //Define setters
        public void setCustomer_id(int Customer_id)
        {
            this.customer_id = Customer_id;
        }
        public void setForename(String Forename)
        {
            this.forename = Forename;
        }

        public void setSurname(String Surname)
        {
            this.surname = Surname;
        }

        public void setAddln1(String Addln1)
        {
            this.addln1 = Addln1;
        }

        public void setAddln2(String Addln2)
        {
            this.addln2 = Addln2;
        }

        public void setAddln3(String Addln3)
        {
            this.addln3 = Addln3;
        }
        public void setBalance(decimal Balance)
        {
            this.balance = Balance;
        }




        //Define getters
        public int getCustomer_id()
        {
            return customer_id;
        }

        public string getForename()
        {
            return forename;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getAddln1()
        {
            return addln1;
        }

        public string getAddln2()
        {
            return addln2;
        }

        public string getAddln3()
        {
            return addln3;
        }
        public decimal getBalance()
        {
            return balance;
        }

        //define a static method to get all data from Stock table
        public static DataSet getAllCustomer(DataSet DS, String OrderBy)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT customer_id, forename, surname, addressln1, addressln2, addressln3, balance FROM Customer ORDER BY " + OrderBy;

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
        public static DataSet getSelectedCustomer(DataSet DS, String EnteredSurname)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT customer_id, surname, forename FROM Customer WHERE surname LIKE UPPER('" + EnteredSurname + "%')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }


        public static int getNextCustomer_id()
        {


            int intNextCustomerid;


            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Customer_id) FROM Customer";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            if (dr.IsDBNull(0))
                intNextCustomerid = 1;
            else
                intNextCustomerid = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();


            return intNextCustomerid;

        }
        public void addCustomer()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Customer VALUES(" + this.customer_id.ToString() +
                ",'" + this.forename.ToUpper() + "','" + this.surname + "','" +
                this.addln1 + "','" + this.addln2 + "','" + this.addln3 + "'," + 0.0 +")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static DataSet getSelectedSurnameName(DataSet ds, DataSet Data)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT surname FROM Stock WHERE customer_id = " + Data + "";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(ds, "ss");


            conn.Close();


            return ds;
        }

        public static DataSet getMatchingSurname(DataSet DS, String Name)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String strSQL = "SELECT customer_id, surname, forename FROM Customer WHERE surname LIKE UPPER('" + Name + "%')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter dc = new OracleDataAdapter(cmd);


            dc.Fill(DS, "ss");


            conn.Close();


            return DS;
        }

        public void getCustomer(int Customer_ID)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define SQL Query
            String strSQL = "SELECT * FROM Customer  WHERE customer_id = " + Customer_ID;
            //execute query using Data Reader


            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setCustomer_id(dr.GetInt32(0));
                setSurname(dr.GetString(1));
                setForename(dr.GetString(2));
                setAddln1(dr.GetString(3));
                setAddln2(dr.GetString(4));
                setAddln3(dr.GetString(5));
                setBalance(dr.GetDecimal(6));

            }
            //close db
            conn.Close();


        }
        public void updateCustomer()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Customer SET forename= '"
                + this.forename.ToUpper() + "', surname= '" + this.surname + "',addressln1= '" +
                this.addln1 + "',addressln2= '" + this.addln2 + "',addressln3= '" + this.addln3 + "' WHERE customer_id = " + this.customer_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}