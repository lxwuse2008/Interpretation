using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Model;
using Document;

namespace Web.MapBuilders
{
    public class DemoMapBuilder : IMapBuilder
    {
        public void BuildMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DemoModel, DemoDocument>().ReverseMap();
        }
    }
}