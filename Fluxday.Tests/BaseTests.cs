using Fluxday.Data;
using Framework.SeleniumUtils;
using NUnit.Framework;
using System;

namespace Fluxday.Tests
{
    public abstract class BaseTests
    {
        [SetUp]
        public  void Initialize()
        {
            Driver.Init();
            Driver.Goto(Urls.loginPageUrl);
            Console.WriteLine("Opened url");
        }       




        [TearDown]
        public void AfterEachTestCleanup()
        {
            Driver.Current.Quit();
            Console.WriteLine("Closed app");
        }
    }
}
