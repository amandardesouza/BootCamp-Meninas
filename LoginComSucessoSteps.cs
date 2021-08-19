using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;

namespace BootCamp_Meninas
{
    [Binding]
    public class LoginComSucessoSteps
    {
        [Given(@"acessar a pagina")]
        public void GivenAcessarAPagina()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://framedlife.com.br/fotoescambo/users/login");
            driver.Quit();

        }

        [Given(@"preenhcer os campos")]
        public void GivenPreenhcerOsCampos()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://framedlife.com.br/fotoescambo/users/login");
            //Preencher os campos usuário e senha:
            IWebElement username = driver.FindElement(By.Id("UserEmail"));
            username.SendKeys("guifreitag@gmail.com");

            IWebElement password = driver.FindElement(By.Id("UserPassword"));
            password.SendKeys("passw0rd10");
            System.Threading.Thread.Sleep(2000);

            driver.Quit();

        }

        [When(@"clique em login")]
        public void WhenCliqueEmLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://framedlife.com.br/fotoescambo/users/login");
            //Preencher os campos usuário e senha:
            IWebElement username = driver.FindElement(By.Id("UserEmail"));
            username.SendKeys("guifreitag@gmail.com");

            IWebElement password = driver.FindElement(By.Id("UserPassword"));
            password.SendKeys("passw0rd10");
            IWebElement button = driver.FindElement(By.XPath("//*[@id='UserLoginForm']/div[4]/input"));
            button.Click();

            driver.Quit();

        }

        [Then(@"acessa a area logada")]
        public void ThenAcessaAAreaLogada()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://framedlife.com.br/fotoescambo/users/login");
            //Preencher os campos usuário e senha:
            IWebElement username = driver.FindElement(By.Id("UserEmail"));
            username.SendKeys("guifreitag@gmail.com");

            IWebElement password = driver.FindElement(By.Id("UserPassword"));
            password.SendKeys("passw0rd");
            IWebElement button = driver.FindElement(By.XPath("//*[@id='UserLoginForm']/div[4]/input"));
            button.Click();
            IWebElement link = driver.FindElement(By.LinkText("Collections"));
            link.Click();
            driver.Quit();

        }
    }
}
