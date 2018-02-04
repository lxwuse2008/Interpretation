using Base.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    public class DemoDocument : BaseDocument
    {

        public DemoDocument()
        {
            Demo = "DemoDocument";
        }
        public string Demo { set; get; }

        public int Id { set; get; }
    }
}
