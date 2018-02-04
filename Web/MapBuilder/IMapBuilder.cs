using AutoMapper;
using System;

namespace Web.MapBuilder
{
    public interface IMapBuilder
    {
        void BuildMap(IMapperConfigurationExpression cfg);
    }
}