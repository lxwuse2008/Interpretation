using Model;
using Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Interface
{
    public interface IDemoService : IBaseService
    {
        DemoModel GetById(int id);
        int Add(DemoModel model);
        bool Update(DemoModel model);
        bool Delete(int id);
    }
}