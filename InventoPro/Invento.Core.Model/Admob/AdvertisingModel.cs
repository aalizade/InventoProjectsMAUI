using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.Admob
{
    public class AdvertisingModel
    {
        public EAdvertisingType AdvertisingType { get; set; }
        public string Id { get; set; }
        public long Frequency { get; set; }
        public long CurrentCount { get; set; }
    }
}
