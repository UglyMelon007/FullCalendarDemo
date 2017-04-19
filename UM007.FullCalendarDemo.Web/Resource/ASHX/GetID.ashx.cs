using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace UM007.FullCalendarDemo.Web.Resource.ASHX
{
    /// <summary>
    /// GetID 的摘要说明
    /// </summary>
    public class GetID : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string d = System.Web.HttpUtility.UrlDecode(context.Request["title"], Encoding.UTF8);
            context.Response.Write(d);
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