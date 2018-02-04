using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.MapBuilders
{
    public interface IMapBuilder
    {
        void BuildMap(IMapperConfigurationExpression cfg);
    }
}