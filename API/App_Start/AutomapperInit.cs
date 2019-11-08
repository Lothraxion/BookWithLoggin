using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BLL.Automapper;

namespace API.App_Start
{
    public class AutomapperInit
    {

        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<BookPofile>();
            });
        }
       
      
    }
}