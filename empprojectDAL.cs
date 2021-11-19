using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRBAL;

namespace HRDAL
{
    public class empprojectDAL
    {
        public List<empproject> showall()
        {
            string s = "select * from EmpProject";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            da.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                empproject e = new empproject();
                e.empId = Convert.ToInt32(t.Rows[i][0]);
                e.ProjectId = Convert.ToInt32(t.Rows[i][1]);

            }
        }
    }
}
