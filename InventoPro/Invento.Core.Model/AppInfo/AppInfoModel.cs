using Invento.Core.Common;
using Invento.Core.Model.Admob;
using Invento.Core.Multilanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.AppInfo
{
    public class AppInfoModel
    {
        /// <summary>
        /// SKU Sample=>com.invento.XalqNagillari
        /// </summary>
        public string AppId { get; set; } 
        public EMessageCode AppName { get; set; }
        public List<AdmobModel> AdvertisingInfo { get; set; }
    }
}
