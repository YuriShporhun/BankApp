using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BankApp.UI.Themes
{
    public sealed class ThemeResourceDictionary: ResourceDictionary
    {
        public ThemeResourceDictionary()
        {
            MergedDictionaries.Add(Theme.ResourceDictionary);
        }
    }
}
