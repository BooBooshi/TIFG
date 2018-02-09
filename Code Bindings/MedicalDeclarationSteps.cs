using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace TIFG
{
    [Binding]
    public class MedicalDeclarationSteps
    {
        IWebDriver driver;
        private readonly object wait;

        [Given(@"I'm on the protectif website")]
        public void GivenIMOnTheProtectifWebsite()
        {
            driver = new ChromeDriver();
            driver.Url = "https://alpha.protectif.co.uk";

        }

        [Given(@"I have navigated to the Travel Insurance details page")]
        public void GivenIHaveNavigatedToTheTravelInsuranceDetailsPage()
        {
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("next-button")).Displayed);
            driver.FindElement(By.Id("next-button")).Click();
        }
        
        [Given(@"I have navigated to the Information about your policy form")]
        public void GivenIHaveNavigatedToTheInformationAboutYourPolicyForm()
        {
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("next-button")).Displayed);
            driver.FindElement(By.Id("next-button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("policyReferenceNum")).SendKeys("12345678");
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("residentCountry")).Displayed);
           
        }
        
        [Given(@"I have navigated to the Traveller details page")]
        public void GivenIHaveNavigatedToTheTravellerDetailsPage()
        {
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("next-button")).Displayed);
            driver.FindElement(By.Id("next-button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("policyReferenceNum")).SendKeys("12345678");
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("residentCountry")).Displayed);
            new SelectElement(driver.FindElement(By.Id("residentCountry"))).SelectByText("United Kingdom");
            new SelectElement(driver.FindElement(By.Id("destination"))).SelectByText("Australasia");
            new SelectElement(driver.FindElement(By.Id("policyTypes"))).SelectByText("Alpha Longstay");
            driver.FindElement(By.Id("departureDate")).SendKeys("15-February-2018");
            driver.FindElement(By.Id("returnDate")).SendKeys("15-May-2018");
            new SelectElement(driver.FindElement(By.Id("policy"))).SelectByText("Alpha 150 Longstay");
            driver.FindElement(By.Id("next-button")).Click();
            //Assert.That(driver.FindElement(By.Id("add-traveller-button")).Displayed);
            driver.FindElement(By.Id("add-traveller-button")).Click();
        }
        
        [Given(@"I have navigated to the Medication page")]
        public void GivenIHaveNavigatedToTheMedicationPage()
        {
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("next-button")).Displayed);
            driver.FindElement(By.Id("next-button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("policyReferenceNum")).SendKeys("12345678");
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("residentCountry")).Displayed);
            new SelectElement(driver.FindElement(By.Id("residentCountry"))).SelectByText("United Kingdom");
            new SelectElement(driver.FindElement(By.Id("destination"))).SelectByText("Australasia");
            new SelectElement(driver.FindElement(By.Id("policyTypes"))).SelectByText("Alpha Longstay");
            driver.FindElement(By.Id("departureDate")).SendKeys("15-February-2018");
            driver.FindElement(By.Id("returnDate")).SendKeys("15-May-2018");
            new SelectElement(driver.FindElement(By.Id("policy"))).SelectByText("Alpha 150 Longstay");
            driver.FindElement(By.Id("next-button")).Click();
            //Assert.That(driver.FindElement(By.Id("add-traveller-button")).Displayed);
            driver.FindElement(By.Id("add-traveller-button")).Click();
            new SelectElement(driver.FindElement(By.Id("title"))).SelectByText("Mrs");
            driver.FindElement(By.Id("firstname")).SendKeys("Test");
            driver.FindElement(By.Id("lastname")).SendKeys("TifTest");
            new SelectElement(driver.FindElement(By.Id("dropdownDay"))).SelectByText("14");
            new SelectElement(driver.FindElement(By.Id("dropdownMonth"))).SelectByText("11");
            new SelectElement(driver.FindElement(By.Id("dropdownYear"))).SelectByText("1985");
            driver.FindElement(By.Id("height")).SendKeys("1.75");
            driver.FindElement(By.Id("weight")).SendKeys("76");
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/button[1]")).Click();
            Assert.That(driver.FindElement(By.Id("medication")).Displayed);
        }
        
        [Given(@"I have navigated to the Medical Declaratin page")]
        public void GivenIHaveNavigatedToTheMedicalDeclaratinPage()
        {
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("next-button")).Displayed);
            driver.FindElement(By.Id("next-button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("policyReferenceNum")).SendKeys("12345678");
            driver.FindElement(By.Id("next-button")).Click();
            Assert.That(driver.FindElement(By.Id("residentCountry")).Displayed);
            new SelectElement(driver.FindElement(By.Id("residentCountry"))).SelectByText("United Kingdom");
            new SelectElement(driver.FindElement(By.Id("destination"))).SelectByText("Australasia");
            new SelectElement(driver.FindElement(By.Id("policyTypes"))).SelectByText("Alpha Longstay");
            driver.FindElement(By.Id("departureDate")).SendKeys("15-February-2018");
            driver.FindElement(By.Id("returnDate")).SendKeys("15-May-2018");
            new SelectElement(driver.FindElement(By.Id("policy"))).SelectByText("Alpha 150 Longstay");
            driver.FindElement(By.Id("next-button")).Click();
            //Assert.That(driver.FindElement(By.Id("add-traveller-button")).Displayed);
            driver.FindElement(By.Id("add-traveller-button")).Click();
            new SelectElement(driver.FindElement(By.Id("title"))).SelectByText("Mrs");
            driver.FindElement(By.Id("firstname")).SendKeys("Test");
            driver.FindElement(By.Id("lastname")).SendKeys("TifTest");
            new SelectElement(driver.FindElement(By.Id("dropdownDay"))).SelectByText("14");
            new SelectElement(driver.FindElement(By.Id("dropdownMonth"))).SelectByText("11");
            new SelectElement(driver.FindElement(By.Id("dropdownYear"))).SelectByText("1985");
            driver.FindElement(By.Id("height")).SendKeys("1.75");
            driver.FindElement(By.Id("weight")).SendKeys("76");
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/button[1]")).Click();
            Assert.That(driver.FindElement(By.Id("medication")).Displayed);
            driver.FindElement(By.Id("medication")).SendKeys("Cetirizine / Zirtek");
            driver.FindElement(By.Id("2459")).Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/button[1]")).Click();
            Assert.That(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div/div[1]/div[3]/traveller-component/div/div/div[1]/h4[contains(., 'Tiftest')]")).Displayed);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/button[2]")).Click();
        }

        [When(@"I enter a policy number")]
        public void WhenIEnterAPolicyNumber()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("policyReferenceNum")).SendKeys("12345678");
        }

        [When(@"I click on the Next button")]
        public void WhenIClickOnTheNextButton()
        {
            driver.FindElement(By.Id("next-button")).Click();
        }
        
        [When(@"I select the country of residence")]
        public void WhenISelectTheCountryOfResidence()
        {
            new SelectElement(driver.FindElement(By.Id("residentCountry"))).SelectByText("United Kingdom");
        }
        
        [When(@"I select the country I am travelling to")]
        public void WhenISelectTheCountryIAmTravellingTo()
        {
            new SelectElement(driver.FindElement(By.Id("destination"))).SelectByText("Australasia");
        }
        
        [When(@"I select a singletrip policy type")]
        public void WhenISelectASingletripPolicyType()
        {
            new SelectElement(driver.FindElement(By.Id("policyTypes"))).SelectByText("Alpha Longstay");
        }
        
        [When(@"I select the departure date")]
        public void WhenISelectTheDepartureDate()
        {
            driver.FindElement(By.Id("departureDate")).SendKeys("15-February-2018");
        }
        
        [When(@"I select the return date")]
        public void WhenISelectTheReturnDate()
        {
            driver.FindElement(By.Id("returnDate")).SendKeys("15-May-2018");
        }
        
        [When(@"I select the level of cover")]
        public void WhenISelectTheLevelOfCover()
        {
            new SelectElement(driver.FindElement(By.Id("policy"))).SelectByText("Alpha 150 Longstay");
        }
        
        [When(@"I select a title")]
        public void WhenISelectATitle()
        {
            new SelectElement(driver.FindElement(By.Id("title"))).SelectByText("Mrs");
        }
        
        [When(@"I enter a Firstname")]
        public void WhenIEnterAFirstname()
        {
            driver.FindElement(By.Id("firstname")).SendKeys("Test");
        }
        
        [When(@"I enter a Surname")]
        public void WhenIEnterASurname()
        {
            driver.FindElement(By.Id("lastname")).SendKeys("TifTest");
        }
        
        [When(@"I enter the date of birth")]
        public void WhenIEnterTheDateOfBirth()
        {
            
            new SelectElement(driver.FindElement(By.Id("dropdownDay"))).SelectByText("14");
            new SelectElement(driver.FindElement(By.Id("dropdownMonth"))).SelectByText("11");
            new SelectElement(driver.FindElement(By.Id("dropdownYear"))).SelectByText("1985");
        }
        
        [When(@"I enter the hight")]
        public void WhenIEnterTheHight()
        {
            driver.FindElement(By.Id("height")).SendKeys("1.75");
        }
        
        [When(@"I enter the weight")]
        public void WhenIEnterTheWeight()
        {
            driver.FindElement(By.Id("weight")).SendKeys("76");
        }
        
        [When(@"I Enter the Medication")]
        public void WhenIEnterTheMedication()
        {
            driver.FindElement(By.Id("medication")).SendKeys("Cetirizine / Zirtek");
        }
        
        [When(@"I select a medical condition")]
        public void WhenISelectAMedicalCondition()
        {
            driver.FindElement(By.Id("2459")).Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }
        
        [When(@"I click on the No more conditions button on the pop up box")]
        public void WhenIClickOnTheNoMoreConditionsButtonOnThePopUpBox()
        {
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/button[1]")).Click();
            
        }

        [When(@"I have selected an answer for the first question")]
        public void WhenIHaveSelectedAnAnswerForTheFirstQuestion()
        {
            driver.FindElement(By.Id("answer-109636")).Click();
        }

        [When(@"I click on the Continue button")]
        public void WhenIClickOnTheContinueButton()
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("purchase-button")).Click();

        }

        [When(@"I click on the Summary page Continue button")]
        public void WhenIClickOnTheSummaryPageContinueButton()
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [When(@"I enter the contact details")]
        public void WhenIEnterTheContactDetails()
        {
            driver.FindElement(By.Name("email")).SendKeys("Test@test.com");
            driver.FindElement(By.Name("confirmEmail")).SendKeys("Test@test.com");
            driver.FindElement(By.Name("postcode")).SendKeys("ME4 6BP");
            driver.FindElement(By.Id("single-button")).Click();
            new SelectElement(driver.FindElement(By.ClassName("ng-binding"))).SelectByText("Flat 1 Hazel View Old Road Chatham ME4 6BP");
            driver.Quit();
        }
        
        [Then(@"I am presented with the Information about your policy form")]
        public void ThenIAmPresentedWithTheInformationAboutYourPolicyForm()
        {
            Assert.That(driver.FindElement(By.Id("residentCountry")).Displayed);
            driver.Quit();
        }
        
        [Then(@"I am navigated to the Medical Declaration page")]
        public void ThenIAmNavigatedToTheMedicalDeclarationPage()
        {
            Assert.That(driver.FindElement(By.Id("add-traveller-button")).Displayed);
            driver.Quit();

        }
        
        [Then(@"I am navigated to the Medication page")]
        public void ThenIAmNavigatedToTheMedicationPage()
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/button[1]")).Click();
            Assert.That(driver.FindElement(By.Id("medication")).Displayed);
            driver.Quit();
        }
        
        [Then(@"the medication is added")]
        public void ThenTheMedicationIsAdded()
        {
            driver.FindElement(By.Id("screen-button")).Click();
            Assert.That(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div/div[1]/div[3]/traveller-component/div/div/div[1]/h4[contains(., 'Tiftest')]")).Displayed);    
        }
    }
}
