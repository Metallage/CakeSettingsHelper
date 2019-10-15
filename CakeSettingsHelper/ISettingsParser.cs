using System;
using System.Collections.Generic;
using System.Text;

namespace CakeSettingsHelper
{
    interface ISettingsParser
    {
        Dictionary<string, string> ParseFile(string filePath);
    }
}
