using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using System.IO;
using System;
using Xunit;

namespace CoyoteNETCore.Tests
{
    public class FrontEnd
    {
        IWebDriver driver;

        public FrontEnd()
        {
            throw new NotImplementedException();

            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArguments("--headless");
            driver = new FirefoxDriver(path, firefoxOptions);
        }

        [Fact]
        public void Test1()
        {
            driver.Url = "localhost:5000/Login";
            driver.Navigate();

            var login = driver.FindElement(By.Id("login"));
            var password = driver.FindElement(By.Id("password"));
            var result = driver.FindElement(By.Id("result"));

            Assert.Empty(result.Text);
        }
    }
}
