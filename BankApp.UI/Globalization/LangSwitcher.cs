using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BankApp.UI.Globalization
{
    public class LangSwitcher
    {
        readonly UIElement uIElement;
        readonly string language;

        public LangSwitcher(UIElement uIElement, string language)
        {
            this.uIElement = uIElement;
            this.language = language;
        }

        public void Switch()
        {

        }
    }
}
