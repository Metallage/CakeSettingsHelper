using System;

namespace CakeSettingsHelper
{
    interface ISettings
    {
        string GetSettingValue(string settingsName);
    }
}
