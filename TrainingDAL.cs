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
    public class TrainingDAL
    {
        List<Training> t1 = new List<Training>();
        public List<Training> showall()
        {
            string s = "select * from Training";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                Training e = new Training();
                e.Empid = Convert.ToInt32(t.Rows[i][0]);
                e.Batchno = Convert.ToInt32(t.Rows[i][1]);
                e.Batchname = Convert.ToString(t.Rows[i][2]);
                e.courses = Convert.ToString(t.Rows[i][3]);
                e.startdate = Convert.ToDateTime(t.Rows[i][4]);

                e.enddate = Convert.ToDateTime(t.Rows[i][5]);
                e.Status = Convert.ToString(t.Rows[i][6]);
                e.TraineerId = Convert.ToInt32(t.Rows[i][7]);
                e.MangerId = Convert.ToInt32(t.Rows[i][8]);
                t1.Add(e);

            }
            return t1;
        }

        public void addtraining(Training e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from Training", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[0] = e.Empid;
            r[1] = e.Batchno;
            r[2] = e.Batchname;
            r[3] = e.courses;

            r[4] = e.startdate;
            r[5] = e.enddate;
            r[6] = e.Status;
            r[7] = e.TraineerId;
            r[8] = e.MangerId;


            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
    }
}
