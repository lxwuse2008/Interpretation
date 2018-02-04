using AutoMapper;
using Document;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.MapBuilder
{
    public class DemoMapBuilder : IMapBuilder
    {
        public void BuildMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DemoDocument, DemoModel>().ReverseMap();
        }
    }
}