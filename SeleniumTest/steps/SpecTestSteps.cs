using System;

using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

namespace SeleniumTest
{
	[Binding]
	public class SpecTestSteps
	{
		private IWebDriver driver;
		private DuckDuckGoHomePage homepage;

		[BeforeScenario]
		public void beforeScenario()
		{
			this.driver = new ChromeDriver(chromeDriverDirectory:"/home/weyenk/Downloads/");
			this.homepage = new DuckDuckGoHomePage(this.driver);
		}

		[Given ("test case: (.*)")]
		private void printTestCaseName(string TestCase)
		{
			return;
		}
		[Given ("I have navigated to the search page")]
		public void GivenIHaveNavigatedToTheSearchPage ()
		{
			this.driver.Url = "http://www.duckduckgo.com";
		}

		[When ("I enter (.*) in the search box and click the search button")]
		public void WhenIEnterSomethingInTheSearchBoxAndClickTheSearchButton (string bang)
		{
			this.homepage.enterPhraseInSearchBox (bang);
			this.homepage.clickSearchButton ();
		}

		[Then ("the url matches the (.*)")]
		public void ThenTheUrlMatchesThe (string expectedUrl)
		{
			string actualUrl = this.homepage.getUrl ();
			Assert.That (string.Equals(actualUrl, expectedUrl, StringComparison.OrdinalIgnoreCase));
		}

		[AfterScenario]
		public void AfterScenario()
		{
			this.driver.Close();
			this.driver.Dispose();
		}
	}
}
		
