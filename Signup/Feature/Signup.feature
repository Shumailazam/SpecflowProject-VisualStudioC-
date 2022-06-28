Feature: Signup

A short summary of the feature

@smoke
Scenario: Signup page validation check
	Given open page
	And select sigin
	And select signuplink
	And click on submit button
	And click on email field and enter something
	Then validation prompt appear
