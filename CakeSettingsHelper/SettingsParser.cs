using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace CakeSettingsHelper
{
    class SettingsParser 
    {
        private List<Setting> ParseSettings(string jsonText)
        {
            
            
            return new List<Setting>();
        }

        private Dictionary<string, string> FormDictionary(List<Setting> settings)
        {
            Dictionary<string, string> dictSettings = new Dictionary<string, string>();

            foreach (Setting st in settings)
                dictSettings.Add(st.SettingName, st.SettingValue);
            return dictSettings;
        }
    }
}
