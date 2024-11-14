using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Taller.PageObject
{
    public class LoginPage
    {
        public IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private readonly By _txtUsername = By.Id("username");
        private readonly By  _txtPassword = By.Id("username");
        private readonly By _btnLogin = By.CssSelector("#login > button > i");

        //La flecha es un operador, parte izquierda haga las propiedas y parte derecha devuelva ese valor.
        public IWebElement username => _driver.FindElement(_txtUsername); 
        public IWebElement password => _driver.FindElement(_txtPassword); 
        public IWebElement botonLogin => _driver.FindElement(_btnLogin);

        public void IngresarCredenciales(String user, String pass) 
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            botonLogin.Click();
        }
    }
}
