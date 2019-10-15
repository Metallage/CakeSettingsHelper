using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace CakeSettingsHelper
{
    class SettingsParser 
    {
        private MySettings ParseSettings(string jsonText)
        {
            MySettings mySettings = MySettings.GetInstance();

            
            return mySettings;
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
