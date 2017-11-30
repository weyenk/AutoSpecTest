using System;
using System.Collections.Generic;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
	[TestFixture()]
	public class Test
	{
		IWebDriver driver;
		[SetUp]
		public void setup()
		{
			driver = new ChromeDriver(chromeDriverDirectory:"/home/weyenk/Downloads/");
		}
		[TearDown]
		public void teardown()
		{
			driver.Close();
		}
		[Test()]
		public void URLTest()
		{

			driver.Url = "http://www.demoqa.com";
			List<IWebElement> things = new List<IWebElement>(driver.FindElements(By.XPath("//*[contains(text(), " +
			                                                                             "'Draggable')]")));
			foreach (IWebElement item in things)
			{
				if (item.Displayed == true)
				{
					item.Click();
				}
			}
		}
	}
}
