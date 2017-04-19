using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UM007.FullCalendarDemo.Web.Resource.ASHX
{
    /// <summary>
    /// removedate 的摘要说明
    /// </summary>
    public class removedate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string id = context.Request["id"];
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DocumentManagement;Integrated Security=False;User ID=sa;Password=123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            string dfsdf = "DELETE FROM  [Userdate]  where ID=" + id + "";

            SqlDataAdapter da = new SqlDataAdapter(dfsdf, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}