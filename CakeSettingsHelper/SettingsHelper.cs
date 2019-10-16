using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CakeSettingsHelper
{
    class SettingsHelper:ISettings
    {
        private Dictionary<string, string> settings = new Dictionary<string, string>();

        private string filePath;

        private JObject settingsFile;
        public string GetSettingValue(string settingName) => FindSetting(settingName);
        

        public SettingsHelper(string filePath)
        {
            this.filePath = filePath;
        }
        
        /// <summary>
        /// Проверяет файл с настройками на корректность
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>Правильно или нет</returns>
        private bool CheckFile(string filePath)
        {
            if (filePath == null)
                return false;
            if (!File.Exists(filePath))
                return false;
            //try
            //{
            //    LoadFile(filePath);
            //}
            //catch
            //{
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// Загружает json из файла
        /// </summary>
        /// <param name="filePath"></param>
        private JObject LoadFile(string filePath)
        {
            JObject loaded = null;
            if(!CheckFile(filePath))
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string jsonText = sr.ReadToEnd();
                    loaded = JObject.Parse(jsonText);
                }
            return loaded;
        }

        private string FindSetting(string settingName)
        {
            if (settingsFile == null)
                settingsFile = LoadFile(filePath);
            return (string)settingsFile[settingName];
        }
    }
}
