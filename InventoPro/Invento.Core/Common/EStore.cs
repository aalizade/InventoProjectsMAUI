using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Common
{
    //TODO Hangi platformlarda uygulamayı yayınlayacağımız ile ilgili bir altyapı
    //Burda Huawei, App Store IOS, App Store MAC, Windows Store şeklinde olacak
    public enum EStore
    {
        HuaweiStore=1,
        AppStoreIOS=2,
        AppStoreMAC,
        WindowStore,
    }
}
