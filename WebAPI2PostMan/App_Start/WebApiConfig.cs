﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI2PostMan
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API 路由
            config.MapHttpAttributeRoutes();
        }
    }
}
