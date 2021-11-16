using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRBAL;

namespace HRDAL
{
    public class LoginDAL
    {
       
        public int ValidateUser(HRBAL.login P)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            cn.Open();
            string s = "SELECT [dbo].[Admin_Validation](@adminId, @adminPassword)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@adminId", P.username);
            cmd.Parameters.AddWithValue("@adminPassword", P.password);
            var result = cmd.ExecuteScalar();
            cn.Close();
            cn.Dispose();
            return (int)result;
        }
        public void  add(Employeedetails e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from EmployeeDetails", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[1] = e.EmployeeName;
            r[2] = e.DateOfBirth;
            r[3] = e.Gender;
            r[4] = e.EmpStatus;

            r[5] = e.Designation;
            r[6] = e.DeptNo;
            r[7] = e.Address;
            r[8] = e.Nationality;
            r[9] = e.PhoneNo;
            r[10] = e.ManagerId;
            r[11] = e.WorkLoc;
            r[12] = e.Joiningdate;
            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
        public void update (int i,Employeedetails e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from EmployeeDetails", cn);
            d.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet t = new DataSet();
            d.Fill(t);
            //d.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataRow r=t.Tables[0].Rows.Find(i);
            r[1] = e.EmployeeName;
            r[2] = e.DateOfBirth;
            r[3] = e.Gender;
            r[4] = e.EmpStatus;

            r[5] = e.Designation;
            r[6] = e.DeptNo;
            r[7] = e.Address;
            r[8] = e.Nationality;
            r[9] = e.PhoneNo;
            r[10] = e.ManagerId;
            r[11] = e.WorkLoc;
            r[12] = e.Joiningdate;
            // t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);



        }


    }
}
