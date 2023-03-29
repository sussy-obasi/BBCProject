Feature: BBCHomePage

 As a user on BBC
 l want to go on the homepage
 so that l can read the news

@tag1
Scenario: Verify a user can view BBC homepage
	Given a user navigate to the website "https://www.bbc.co.uk/"
	When a user click on sport menu
	Then sport page is displayed
	
