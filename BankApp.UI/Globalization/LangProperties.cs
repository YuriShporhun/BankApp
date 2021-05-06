using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BankApp.UI.Globalization
{
    public static class LangProperties
    {
        public static readonly DependencyProperty RussianProperty =
            DependencyProperty.RegisterAttached("RU", typeof(string), typeof(LangProperties), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty EnglishProperty =
            DependencyProperty.RegisterAttached("EN", typeof(string), typeof(LangProperties), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty SwitchLang =
            DependencyProperty.RegisterAttached("SwitchLang", typeof(string), typeof(LangProperties), new PropertyMetadata(default(bool)));

        public static void SetRussianText(UIElement uIElement, string value) =>
            uIElement.SetValue(RussianProperty, value);

        public static void SetEnglishText(UIElement uIElement, string value) =>
            uIElement.SetValue(EnglishProperty, value);
    }
}
