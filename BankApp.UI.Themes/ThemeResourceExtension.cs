using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BankApp.UI.Themes
{
    public sealed class ThemeResourceExtension: DynamicResourceExtension
    {
        public new ThemeResourceKey ResourceKey
        {
            get
            {
                Enum.TryParse(base.ResourceKey.ToString(), out ThemeResourceKey resourceKey);
                return resourceKey;
            }
            set
            {
                base.ResourceKey = value.ToString();
            }
        }
    }
}
