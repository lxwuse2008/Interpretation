using Biz.Impl;
using Biz.Interface;
using Model;
using Service.Base;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Impl
{
    public class DemoService : BaseService, IDemoService
    {
        private IDemoBiz demoBiz;
        public DemoService()
        {
            demoBiz = new DemoBiz();
        }

        public int Add(DemoModel model)
        {
            return demoBiz.Add(model);
        }

        public bool Update(DemoModel model)
        {
            return demoBiz.Update(model);
        }

        public DemoModel GetById(int id)
        {
            return demoBiz.GetById(id);
        }

        public bool Delete(int id)
        {
            return demoBiz.Delete(id);
        }
    }
}