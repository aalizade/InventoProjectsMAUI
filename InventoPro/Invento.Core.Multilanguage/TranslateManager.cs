using Invento.Core;
using Invento.Core.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invento.Core.Multilanguage
{
    public class TranslateManager:Singleton<TranslateManager>
    {
        List<MultilanguageJsonModel> _data;
        private TranslateManager()
        {
            _data = new List<MultilanguageJsonModel>();
        }


        /// <summary>
        /// Veri listesine genel tercüme verilerine ekler.
        /// </summary>
        /// <param name="translateDatas">List<MultilanguageJsonModel>  json formatında tercüme verileri</param>
        /// <returns></returns>
        public EOperationResult AddJsonTranslateList(List<MultilanguageJsonModel> translateDatas)
        {
            try
            {
                _data.AddRange(translateDatas);
                return EOperationResult.Success;
            }
            catch (Exception)
            {
                return EOperationResult.Failure;
            }
        }

        /// <summary>
        /// Dosya isminden verileri okur ver tercüme listesine ekler
        /// </summary>
        /// <param name="jsonPath">Json dosya yolu</param>
        /// <returns></returns>
        public EOperationResult AddJsonTranslateList(string jsonPath)
        {
            try
            {
                using (StreamReader r = new StreamReader(jsonPath))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<MultilanguageJsonModel>>(json);
                    if (items != null) AddJsonTranslateList(items);
                    
                }
                return EOperationResult.Success;
            }
            catch (Exception)
            {
                return EOperationResult.Failure;
            }
        }

        //TODO mesajlardan yüklenecek.
        public string GetTranslateData(string messageCode, ELanguage language)
        {
            var searchResult = _data.FirstOrDefault(t => t.MessageCode == messageCode);

            if (searchResult == null)
            {
                return messageCode;
            }
            switch (language)
            {
                case ELanguage.Turkish: return string.IsNullOrWhiteSpace(searchResult.Turkish)? messageCode: searchResult.Turkish;
                case ELanguage.English: return string.IsNullOrWhiteSpace(searchResult.English) ? messageCode : searchResult.English;
                case ELanguage.Japanese: return string.IsNullOrWhiteSpace(searchResult.Japanese) ? messageCode : searchResult.Japanese;
                case ELanguage.Azerbaijani: return string.IsNullOrWhiteSpace(searchResult.Azerbaijani) ? messageCode : searchResult.Azerbaijani;
                case ELanguage.Russian: return string.IsNullOrWhiteSpace(searchResult.Russian) ? messageCode : searchResult.Russian;
                case ELanguage.Armenian: return string.IsNullOrWhiteSpace(searchResult.Armenian) ? messageCode : searchResult.Armenian;
                case ELanguage.French: return string.IsNullOrWhiteSpace(searchResult.French) ? messageCode : searchResult.French;
                case ELanguage.Germany: return string.IsNullOrWhiteSpace(searchResult.Germany) ? messageCode : searchResult.Germany;
                case ELanguage.Spanish: return string.IsNullOrWhiteSpace(searchResult.Spanish) ? messageCode : searchResult.Spanish;
                case ELanguage.Arabic: return string.IsNullOrWhiteSpace(searchResult.Arabic) ? messageCode : searchResult.Arabic;
                case ELanguage.ChineseSimplifiead: return string.IsNullOrWhiteSpace(searchResult.ChineseSimplifiead) ? messageCode : searchResult.ChineseSimplifiead;
                case ELanguage.ChineseTraditional: return string.IsNullOrWhiteSpace(searchResult.ChineseTraditional) ? messageCode : searchResult.ChineseTraditional;
                case ELanguage.Crotian: return string.IsNullOrWhiteSpace(searchResult.Crotian) ? messageCode : searchResult.Crotian;
                case ELanguage.Czech: return string.IsNullOrWhiteSpace(searchResult.Czech) ? messageCode : searchResult.Czech;
                case ELanguage.Danish: return string.IsNullOrWhiteSpace(searchResult.Danish) ? messageCode : searchResult.Danish;
                case ELanguage.Dutch: return string.IsNullOrWhiteSpace(searchResult.Dutch) ? messageCode : searchResult.Dutch;
                case ELanguage.Finnish: return string.IsNullOrWhiteSpace(searchResult.Finnish) ? messageCode : searchResult.Finnish;
                case ELanguage.Greek: return string.IsNullOrWhiteSpace(searchResult.Greek) ? messageCode : searchResult.Greek;
                case ELanguage.Hebrew: return string.IsNullOrWhiteSpace(searchResult.Hebrew) ? messageCode : searchResult.Hebrew;
                case ELanguage.Hindi: return string.IsNullOrWhiteSpace(searchResult.Hindi) ? messageCode : searchResult.Hindi;
                case ELanguage.Hungarian: return string.IsNullOrWhiteSpace(searchResult.Hungarian) ? messageCode : searchResult.Hungarian;
                case ELanguage.Indonesian: return string.IsNullOrWhiteSpace(searchResult.Indonesian) ? messageCode : searchResult.Indonesian;
                case ELanguage.Itailian: return string.IsNullOrWhiteSpace(searchResult.Itailian) ? messageCode : searchResult.Itailian;
                case ELanguage.Norwegien: return string.IsNullOrWhiteSpace(searchResult.Norwegien) ? messageCode : searchResult.Norwegien;
                case ELanguage.Polish: return string.IsNullOrWhiteSpace(searchResult.Polish) ? messageCode : searchResult.Polish;
                case ELanguage.Portuguese: return string.IsNullOrWhiteSpace(searchResult.Portuguese) ? messageCode : searchResult.Portuguese;
                case ELanguage.Romanian: return string.IsNullOrWhiteSpace(searchResult.Romanian) ? messageCode : searchResult.Romanian;
                case ELanguage.Slovak: return string.IsNullOrWhiteSpace(searchResult.Slovak) ? messageCode : searchResult.Slovak;
                case ELanguage.Swedish: return string.IsNullOrWhiteSpace(searchResult.Swedish) ? messageCode : searchResult.Swedish;
                case ELanguage.Thai: return string.IsNullOrWhiteSpace(searchResult.Thai) ? messageCode : searchResult.Thai;
                case ELanguage.Ukrainian: return string.IsNullOrWhiteSpace(searchResult.Ukrainian) ? messageCode : searchResult.Ukrainian;
                case ELanguage.Vietnamese: return string.IsNullOrWhiteSpace(searchResult.Vietnamese) ? messageCode : searchResult.Vietnamese;
                case ELanguage.Catalan: return string.IsNullOrWhiteSpace(searchResult.Catalan) ? messageCode : searchResult.Catalan;
                case ELanguage.Korean: return string.IsNullOrWhiteSpace(searchResult.Korean) ? messageCode : searchResult.Korean;
                case ELanguage.Malay: return string.IsNullOrWhiteSpace(searchResult.Malay) ? messageCode : searchResult.Malay;
                default: return messageCode;
            }

        }


        
    }
}
