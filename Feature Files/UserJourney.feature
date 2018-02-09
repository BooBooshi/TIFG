Feature: Medical Declaration
	In order to get a quote and purchase travel inssurance
	As a user
	I want to be able to navigate through the pages 

Background: 
    Given I'm on the protectif website


Scenario: Entering Travel Insurance policy number
	Given I have navigated to the Travel Insurance details page
	When I enter a policy number
	And I click on the Next button
	Then I am presented with the Information about your policy form

Scenario: Completing Information about your policy form
    Given I have navigated to the Information about your policy form
	When I select the country of residence
	And I select the country I am travelling to
	And I select a singletrip policy type
	And I select the departure date
	And I select the return date
	And I select the level of cover
	And I click on the Next button
	Then I am navigated to the Medical Declaration page
	
Scenario: Adding a Traveller
    Given I have navigated to the Traveller details page
	When I select a title 
	And I enter a Firstname
	And I enter a Surname
	And I enter the date of birth
	And I enter the hight 
	And I enter the weight
	Then I am navigated to the Medication page

Scenario: Adding Medication
    Given I have navigated to the Medication page
	When I Enter the Medication
	And I select a medical condition
	And I click on the No more conditions button on the pop up box
	Then the medication is added

Scenario: Start Medical Declaration
    Given I have navigated to the Medical Declaratin page
	When I have selected an answer for the first question
	And I click on the Continue button
	And I click on the Summary page Continue button
	And I enter the contact details
	



