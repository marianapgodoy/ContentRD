using System.Collections.Generic;
using Newtonsoft.Json;

namespace SeleNUnit.WebObjects
{
    public static class ConfigHelper
    {
        #region PublicGetters

        public static string GetBrowserName()
        {
            return GetConfigValue("BrowserName");
        }

        public static string GetBrowserVersion()
        {
            return GetConfigValue("BrowserVersion");
        }

        public static string GetSeleniumUrl()
        {
            return GetConfigValue("SeleniumUrl");
        }

        #endregion

        #region Private

        // This will hold the configuration once loaded from file
        private static Dictionary<string, string> config;

        private static string GetConfigValue(string key)
        {
            string value = null;
            if(LoadConfig())
            {
                config.TryGetValue(key, out value);
            }
            return value;
        }

        private static bool LoadConfig()
        {
            bool loaded = false;
            if (config == null)
            {
                if (System.IO.File.Exists("config.json"))
                {
                    string json = System.IO.File.ReadAllText("config.json");
                    config = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    loaded = true;
                }
            }
            else loaded = true;
            return loaded;
        }

        #endregion
    }
}
