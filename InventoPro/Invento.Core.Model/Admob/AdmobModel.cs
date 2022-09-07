using Invento.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.Admob
{
    public class AdmobModel
    {
        public EPlatform Platform { get; set; }
        public AdvertisingModel Banner { get; set; }
        public AdvertisingModel AdvancedBanner { get; set; }
        public AdvertisingModel Transition { get; set; }
        public AdvertisingModel TransitionReward { get; set; }
        public AdvertisingModel Reward { get; set; }
    }
}
