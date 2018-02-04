using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.AutoMap
{
    public interface IMapper
    {
        TDestination ConvertTo<TDestination>(object source);
        TDestination ConvertTo<TDestination>(object source, TDestination destination);
    }
}
