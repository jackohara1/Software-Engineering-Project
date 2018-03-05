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
    class Department
    {
        private int Department_id;
        private string Department_name;
        public Department()
        {
            Department_id = 1;
            Department_name = "";
            

        }

        public void setDepartment_id(int Department_id)
        {
            this.Department_id = Department_id;
        }
        public void setDepartment_name(String Department_name)
        {
            this.Department_name = Department_name;
        }

        public int getDepartment_id()
        {
            return Department_id;
        }

        public string getDepartment_name()
        {
            return Department_name;
        }
        public static DataSet getDepartment(DataSet DS)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define SQL Query
            String strSQL = "SELECT department_id, department_name FROM Department ORDER BY department_id";

            //execute query using Data Reader


            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close db
            conn.Close();
            return DS;

        }
        public static DataSet getDepartmentDetails(DataSet DS, int DID)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            //Define SQL Query
            String strSQL = "SELECT department_name FROM Department WHERE department_id="+ DID;

            //execute query using Data Reader


            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            //close db
            conn.Close();
            return DS;

        }
      
    }
}
