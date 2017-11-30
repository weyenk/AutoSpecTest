using System;

using TechTalk.SpecFlow;

namespace SeleniumTest
{
	[Binding]
	public class SpecTestSteps
	{
		[Given ("I have navigated to the search page")]
		public void GivenIHaveEnteredSomethingIntoTheCalculator (int number)
		{
			// TODO: implement arrange (recondition) logic
			// For storing and retrieving scenario-specific data, 
			// the instance fields of the class or the
			//     ScenarioContext.Current
			// collection can be used.
			// To use the multiline text or the table argument of the scenario,
			// additional string/Table parameters can be defined on the step definition
			// method. 

			ScenarioContext.Current.Pending ();
		}

		[When ("I enter (.*) in the search box and click the search button")]
		public void WhenIPressAdd ()
		{
			// TODO: implement act (action) logic

			ScenarioContext.Current.Pending ();
		}

		[Then ("the url matches the (.*)")]
		public void ThenTheResultShouldBe (int result)
		{
			// TODO: implement assert (verification) logic
          
			ScenarioContext.Current.Pending ();
		}
	}
}
		
