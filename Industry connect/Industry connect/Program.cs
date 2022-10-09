using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V104.Media;

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

    
