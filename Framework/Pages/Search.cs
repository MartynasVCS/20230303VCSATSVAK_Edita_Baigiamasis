﻿using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    public class Search
    {
        public static void Open()
        {
            Driver.OpenPage("https://eurovision.tv/");
        }

        public static void EnterMessage(string message)
        {
            string locator = "(//*[@id='search-header'])[2]";
            Common.SendKeys(locator, message);
        }

        public static void ClickSearchIcon()
        {
            string locator = "(//*[@id='search-popup-trigger'])[1]";
            Common.Click(locator);
        }

        public static string GetMessage()
        {
            string locator = "//*[@id='edit-search']";
            return Common.GetElementText(locator);
        }
    }
}
