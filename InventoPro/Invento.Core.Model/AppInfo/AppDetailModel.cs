using Invento.Core.Model.Admob;
using Invento.Core.Multilanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Model.AppInfo
{
    public class AppDetailModel
    {
        public ELanguage Language { get; set; }
        public string AppName { get; set; }
        public List<string> About { get; set; }
        public List<InstructionModel> Instructions { get; set; }
    }
}
