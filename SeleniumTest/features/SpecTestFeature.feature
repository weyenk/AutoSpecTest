Feature: !Bang Function
	In order quickly search around the web
	As a duckduckgo user
	I would like to have my search results redirected to a corresponding !Bang

@demo
Scenario Outline: Enter 
	Given test case: <testCase>
    Given I have navigated to the search page
    When I enter <phrase> in the search box and click the search button
    Then the url matches the <searchURL>

Examples:
	| testCase 			                      | phrase                          | searchURL                                                                                      |
	| Search Linux on YouTube                 | linux !yt                       | https://www.youtube.com/results?search_query=linux                                             |
	| Search Linux on Wikipedia               | linux !w                        | https://en.wikipedia.org/wiki/Linux                                                            |
	| Search Linux on Amazon                  | linux !a                        | https://www.amazon.com/s/?url=search-alias%3Daps&field-keywords=linux&tag=duckduckgo-ffab-b-20 |
	| Search specflow on NuGet.org            | specflow !nuget                 | https://www.nuget.org/packages?q=specflow&sortOrder=package-download-count                     |
