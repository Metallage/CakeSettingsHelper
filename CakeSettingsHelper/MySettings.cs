using System;
using System.Collections.Generic;
using System.Text;

namespace CakeSettingsHelper
{
    class MySettings
    {
        private static MySettings instance;

        public List<Setting> Settings { get; set; } = new List<Setting>();

        public static MySettings GetInstance()
        {
            if (instance == null)
                instance = new MySettings();
            return instance;
        }
    }
}
