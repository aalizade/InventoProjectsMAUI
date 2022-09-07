using Invento.Core;
using Invento.Core.Model.AppInfo;
using Invento.Core.Multilanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Mobil.AppInfo
{
    public class AppInfoManager:Singleton<AppInfoManager>
    {
        AppInfoModel _appInfoModel;
        private AppInfoManager()
        {
            _appInfoModel = new AppInfoModel();
        }

        public void SetAppInfo(AppInfoModel appInfo)
        {
            _appInfoModel = appInfo;
        }

        public string GetAppId()
        {
            return _appInfoModel.AppId;
        }

        public string GetAppName(ELanguage language)
        {
            var appDetailInfo = _appInfoModel.AppDetail.FirstOrDefault(t => t.Language == language);
            if (appDetailInfo != null)
            {
                return appDetailInfo.AppName;
            }
            else return _appInfoModel.AppId;
        }

    }
}
