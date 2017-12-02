using System;

using OpenQA.Selenium;


namespace SeleniumTest
{
	public class DuckDuckGoHomePage
	{
		
		private IWebDriver driver;

		public DuckDuckGoHomePage (IWebDriver driver)
		{
			this.driver = driver;
		}
		public void enterPhraseInSearchBox(string phrase)
		{
			IWebElement searchBox = this.driver.FindElement(By.Id("search_form_input_homepage"));
			searchBox.Clear ();
			searchBox.SendKeys (phrase);
		}
		public void clickSearchButton()
		{
			IWebElement searchButton = this.driver.FindElement (By.Id("search_button_homepage"));
			searchButton.Click ();
		}
		public string getUrl()
		{
			string currentUrl = this.driver.Url.ToString ();
			return currentUrl;
		}
	}
}

