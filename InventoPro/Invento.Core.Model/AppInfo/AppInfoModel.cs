using Invento.Core.Common;
using Invento.Core.Model.Admob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.AppInfo
{
    public class AppInfoModel
    {
        public string AppId { get; set; }
        public EStore CurrentStore { get; set; }
        public List<StoreDataModel> Stores { get; set; }

        public List<AppDetailModel> AppDetail { get; set; }
        public List<AdmobModel> AdvertisingInfo { get; set; }
    }
}
