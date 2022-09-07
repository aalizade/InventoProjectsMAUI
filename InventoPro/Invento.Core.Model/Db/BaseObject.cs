using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.Db
{
    public class BaseObject
    {
        public BaseObject()
        {
            CreatedTime = DateTime.Now;
            Deleted = false;
        }

        public long Oid { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}
