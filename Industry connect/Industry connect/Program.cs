using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V104.Media;
using OpenQA.Selenium.Support.Events;

IWebDriver driver = new ChromeDriver();

// Navigate to TurnUp portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/login?ReturnUrl=%2f");
driver.Manage().Window.Maximize(); 

//identify username textbox and enter valid username
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

// Identify password textbox and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

// identify login butrton and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if user logged on sucessfully 
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a")); 

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in Sucessfully, Test Passed");
}
else
{
    Console.WriteLine("Login failed, Test failed");
}

// Go to administration drop down and select Time and materials
IWebElement administrationDropDown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
administrationDropDown.Click();

IWebElement TimeMaterialClick = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
    TimeMaterialClick.Click();

// Create New Time and material
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
Thread.Sleep(1000);

IWebElement typeCodeDropbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
    typeCodeDropbox.Click();
Thread.Sleep(1000);

IWebElement SelectTimeOption = driver.FindElement(By.Id("TypeCode_option_selected"));
    SelectTimeOption.Click();

IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
    codeTextbox.SendKeys("rasan");
Thread.Sleep(1000);

IWebElement priceFirstClick = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
    priceFirstClick.Click();


IWebElement priceSecondClick = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
    priceSecondClick.Click();
priceSecondClick.SendKeys("$59.99");

IWebElement DescribeTextbox = driver.FindElement(By.Id("Description"));
DescribeTextbox.Click();
DescribeTextbox.SendKeys("Rasan");

IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(1000);


//check created username

IWebElement endPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
endPageButton.Click();
Thread.Sleep(1000);

IWebElement lastListing = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (lastListing.Text == "rasan")
{
    Console.WriteLine("Time record has been created Sucessfully");

}
else
{
    Console.WriteLine("Time record hasn't been created");
}





