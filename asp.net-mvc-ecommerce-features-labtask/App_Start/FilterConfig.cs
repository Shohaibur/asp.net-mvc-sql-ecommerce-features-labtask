﻿using System.Web;
using System.Web.Mvc;

namespace asp.net_mvc_ecommerce_features_labtask
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
