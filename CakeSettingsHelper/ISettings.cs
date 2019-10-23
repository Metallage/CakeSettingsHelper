using System;

namespace CakeSettingsHelper
{
    /// <summary>
    /// Интерфейс взаимодействия с файлом настроек
    /// </summary>
    interface ISettings
    {
        /// <summary>
        /// Возвращает значение настройки
        /// </summary>
        /// <param name="settingsName">Имя настройки</param>
        /// <returns>Значение</returns>
        string GetSettingValue(string settingsName);
    }
}
