using Biz.Base;
using Biz.Interface;
using Dal.Impl;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Biz.Impl
{
    public class DemoBiz : BaseBiz, IDemoBiz
    {
        private readonly IDemoDal demoDal;

        public DemoBiz()
        {
            demoDal = new DemoDal();
        }

        public int Add(DemoModel model)
        {
            return demoDal.Add(model);
        }

        public bool Delete(int id)
        {
            return demoDal.Delete<DemoModel>(id);
        }

        public DemoModel GetById(int id)
        {
            return demoDal.GetById<DemoModel>(id);
        }

        public bool Update(DemoModel model)
        {
            return demoDal.Update(model);
        }
    }
}
