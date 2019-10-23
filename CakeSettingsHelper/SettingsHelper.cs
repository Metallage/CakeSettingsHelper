using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CakeSettingsHelper
{
    public class SettingsHelper:ISettings
    {
        /// <summary>
        /// Хранит путь к файлу
        /// </summary>
        private string filePath;


        /// <summary>
        /// Хранит json из файла
        /// </summary>
        private JObject settingsFile;

        /// <summary>
        /// Получить знасение настройки по имени
        /// </summary>
        /// <param name="settingName">Имя настройки</param>
        /// <returns>Значение</returns>
        public string GetSettingValue(string settingName) => FindSetting(settingName);
        

        public SettingsHelper(string filePath)
        {
            this.filePath = filePath;
        }
        
        /// <summary>
        /// Проверяет файл с настройками на корректность
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>Есть или нет</returns>
        private bool CheckFile(string filePath)
        {
            if (filePath == null)
                return false;
            if (!File.Exists(filePath))
                return false;

            return true;
        }

        /// <summary>
        /// Загружает json из файла
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        private JObject LoadFile(string filePath)
        {
            JObject loaded = null;
            if(CheckFile(filePath))
                using (StreamReader sr = new StreamReader(filePath))
                {                  
                    string jsonText = sr.ReadToEnd();
                    loaded = JObject.Parse(jsonText);
                }
            return loaded;
        }

        /// <summary>
        /// Возвращает значение определённой настройки
        /// </summary>
        /// <param name="settingName">Имя настройки</param>
        /// <returns>значение настройки</returns>
        private string FindSetting(string settingName)
        {
            if (settingsFile == null)
                settingsFile = LoadFile(filePath);
            return (string)settingsFile[settingName];
        }
    }
}
