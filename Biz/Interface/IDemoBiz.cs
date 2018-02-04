using Biz.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz.Interface
{
    public interface IDemoBiz : IBaseBiz
    {
        int Add(DemoModel model);

        bool Update(DemoModel model);
        bool Delete(int id);

        DemoModel GetById(int id);
    }
}
