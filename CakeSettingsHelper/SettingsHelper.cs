using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CakeSettingsHelper
{
    class SettingsHelper:ISettings
    {
        private Dictionary<string, string> settings = new Dictionary<string, string>();
        public string GetSettingValue(string settingName) => FindSetting(settingName);

        private string FindSetting(string settingName)
        {
            if (settings.ContainsKey(settingName))
                return settings[settingName];
            else
                return null;
        }
    }
}
