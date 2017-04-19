using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace UM007.FullCalendarDemo.Web.Resource.ASHX
{
    /// <summary>
    /// Updateinfo 的摘要说明
    /// </summary>
    public class Updateinfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string title = System.Web.HttpUtility.UrlDecode(context.Request["title"], Encoding.UTF8);
            string fullname = System.Web.HttpUtility.UrlDecode(context.Request["fullname"], Encoding.UTF8);
            string description = System.Web.HttpUtility.UrlDecode(context.Request["description"], Encoding.UTF8);
            string confname = System.Web.HttpUtility.UrlDecode(context.Request["confname"], Encoding.UTF8);
            string start = System.Web.HttpUtility.UrlDecode(context.Request["start"], Encoding.UTF8);
            string confshortname = System.Web.HttpUtility.UrlDecode(context.Request["confshortname"], Encoding.UTF8);
            string end = System.Web.HttpUtility.UrlDecode(context.Request["end"], Encoding.UTF8);
            string id = context.Request["id"];
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DocumentManagement;Integrated Security=False;User ID=sa;Password=123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            string dfsdf = "UPDATE    Userdate SET   Title = '" + title + "', start = '" + start + "', [end] = '" + end + "' , fullname = '" + fullname + "', confname = '" + confname + "', confshortname = '" + confshortname + "', allDay = 0 , description = '" + description + "' where ID=" + id + "";
            ;
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