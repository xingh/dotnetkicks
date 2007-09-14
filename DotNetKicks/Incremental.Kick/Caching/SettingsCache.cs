using System;
using System.Collections.Generic;
using System.Text;
using Incremental.Kick.Dal;

namespace Incremental.Kick.Caching {
    public class SettingsCache {
        public static string GetSetting(string name) {
            if (Settings.ContainsKey(name))
                return Settings[name].ValueX;
            else
                throw new ArgumentException("Invalid Setting name : " + name);
        }

        public static Dictionary<string, Setting> Settings {
            get {
                CacheManager<string, Dictionary<string, Setting>> cache = GetSettingCache();
                string cacheKey = "Settings";
                Dictionary<string, Setting> settingDictionary = cache[cacheKey];

                if (settingDictionary == null) {
                    settingDictionary = new Dictionary<string, Setting>();
                    SettingCollection settings = new SettingCollection();
                    settings.LoadAndCloseReader(Setting.FetchAll());

                    foreach (Setting setting in settings) {
                        settingDictionary.Add(setting.Name, setting);
                    }

                    cache.Insert(cacheKey, settingDictionary, CacheHelper.CACHE_DURATION_IN_SECONDS);
                }

                return settingDictionary;
            }
        }

        private static CacheManager<string, Dictionary<string, Setting>> GetSettingCache() {
            return CacheManager<string, Dictionary<string, Setting>>.GetInstance();
        }
    }
}
