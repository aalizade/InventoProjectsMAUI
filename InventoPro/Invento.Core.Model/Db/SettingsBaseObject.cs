using Invento.Core.Multilanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.Db
{
    public class SettingsBaseObject:BaseObject
    {
        public string UserUniqueId { get; set; }
        public ELanguage? CurrentLanguage { get; set; }
        public bool TransitionSound { get; set; }
        public bool BackgroundSound { get; set; }
    }
}
