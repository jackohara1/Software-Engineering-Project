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

    //retrieves all data about departments from the department file
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
      
    }
}
