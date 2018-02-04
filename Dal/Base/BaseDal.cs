using Common.AutoMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Document;
using System.Data.SqlClient;
using DapperExtensions;

namespace Dal.Base
{
    public class BaseDal<Document> : IBaseDal<Document> where Document : class
    {
        private readonly IMapper mapper;
        public BaseDal()
        {
            mapper = new Mapper();
        }

        public virtual string ConnectionKey => "Data Source=LXWUSE2008-PC;Initial Catalog=demo;;User ID=sa;Pwd=123456";

        public int Add<T>(T t)
        {
            var doc = mapper.ConvertTo<Document>(t);
            using (SqlConnection cn = new SqlConnection(ConnectionKey))
            {
                cn.Open();
                var id = cn.Insert(doc);
                cn.Close();
                return id;
            }
        }

        public bool Delete<T>(int id)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionKey))
            {
                cn.Open();
                var doc = cn.Get<Document>(id);
                var result = cn.Delete(doc);
                cn.Close();
                return result;
            }
        }

        public T GetById<T>(int id)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionKey))
            {
                cn.Open();
                var doc = cn.Get<Document>(id);
                cn.Close();
                return mapper.ConvertTo<T>(doc);
            }
        }

        public List<T> GetList<T>()
        {
            return new List<T>();
        }

        public List<T> GetListByPage<T>()
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T t)
        {
            var doc = mapper.ConvertTo<Document>(t);
            using (SqlConnection cn = new SqlConnection(ConnectionKey))
            {
                cn.Open();
                cn.Update(doc);
                cn.Close();
            }
            return true;
        }
    }
}
