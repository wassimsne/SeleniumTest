using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.pageGoogle
{
    public class GoogleSearchPage
    {
        IWebDriver driver;
        public IWebElement SearchBox { get; private set; }
        public IWebElement SearchButton { get; private set; }

        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.Name("btnK"));

        }
    }
}
