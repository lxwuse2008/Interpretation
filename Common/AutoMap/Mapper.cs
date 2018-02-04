using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.AutoMap
{
    public class Mapper : IMapper
    {
        public TDestination ConvertTo<TDestination>(object source)
        {
            if (source == null) return default(TDestination);
            return (TDestination)AutoMapper.Mapper.Map(source, source.GetType(), typeof(TDestination));
        }
        public TDestination ConvertTo<TDestination>(object source, TDestination destination)
        {
            if (source == null) return default(TDestination);
            return (TDestination)AutoMapper.Mapper.Map(source, destination, source.GetType(), typeof(TDestination));
        }
    }
}