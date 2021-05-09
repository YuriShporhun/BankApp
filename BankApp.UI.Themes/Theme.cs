using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace BankApp.UI.Themes
{
    public class Theme
    {
        [ThreadStatic]
        private static ResourceDictionary resourceDictionary;

        internal static ResourceDictionary ResourceDictionary
        {
            get
            {
                if(resourceDictionary != null)
                {
                    return resourceDictionary;
                }

                resourceDictionary = new ResourceDictionary();
                LoadTheme(ThemeType.Light);
                return resourceDictionary;
            }
        }

        public static ThemeType ThemeType { get; set; } = ThemeType.Light;

        public static void LoadTheme(ThemeType type)
        {
            ThemeType = type;
            switch (type)
            {
                case ThemeType.Dark:
                    SetResource(ThemeResourceKey.WindowBackground.ToString(),
                        new SolidColorBrush(Color.FromArgb(255, 25, 25, 25)));
                    break;
                case ThemeType.Light:
                    SetResource(ThemeResourceKey.WindowBackground.ToString(),
                        new SolidColorBrush(Color.FromArgb(255, 92, 95, 88)));
                    break;
                case ThemeType.Green:
                    break;
                default:
                    break;
            }
        }

        internal static object GetResource(ThemeResourceKey resourceKey) =>
            resourceDictionary.Contains(resourceKey.ToString()) ?
                resourceDictionary[resourceKey.ToString()] : null;

        internal static void SetResource(object key, object resource) =>
            resourceDictionary[key] = resource;
    }
}
