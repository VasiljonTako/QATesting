using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public static class SelectDropdown
    {
        public static void SelectDropdownList(this IWebElement element , int value)
        {
            new SelectElement(element).SelectByIndex(value);
        }
    }
}
