﻿using System.Web;
using System.Web.Mvc;

namespace SQL_Web_Server_Angular_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
