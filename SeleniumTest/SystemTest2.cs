using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace SeleniumTest
{
    public class Tests2
    {
        IWebDriver driver;
        [OneTimeSetUp] //methode s'execute avant toute le test
        public void préparation()
        {
            driver = new EdgeDriver();
        }
        [SetUp]//methode qui s'execute avant  chaque test
        public void Setup()
        {

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            Console.WriteLine("Inisialisation du site web");

        }
        [TearDown] //methode qui s'execute aprés chaque test
        public void Clean()
        {
            driver.Close();
            Console.WriteLine("Fermeture du site web");
        }
        [OneTimeTearDown]//methode qui s'execute aprés la fin de tous les tests
        public void Quit()
        {
            driver.Quit();
            Console.WriteLine("Fermeture du driver");
        }
        [Test]
        public void FirstTestOfSelenium1()
        {
            
            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.Name("btnK"));
            searchBox.SendKeys("Selenium");
            searchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value");

            Console.WriteLine(searchQuery);
            Assert.Pass();
        }
    }
}