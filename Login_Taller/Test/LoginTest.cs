using Login_Taller.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Login_Taller.Test
{
    [TestFixture("tomsmith", "SuperSecretPassword")]            //Ejecuta en todas la cantidad de test, ejecución general
    public class Tests
    {
        public IWebDriver driver;
        public LoginPage login;
        public String baseURL = "https://the-internet.herokuapp.com/login";
        

        [SetUp]
        public void IniciarNavegador()
        { 
            driver = new ChromeDriver();   
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseURL);
            login = new LoginPage(driver);
        }

        [TearDown]
        public void CerrarDriver() 
        {
            driver.Close();
            driver.Quit();
        }

        /*
        [Order(1)]                                      // Orden para ejecutar     
        [TestCase("tomsmith", "SuperSecretPassword")]   // Escenario usuario correcto
        [TestCase("tomsmith", "pass")]                  // Escenario usuario incorrecto
        [Category("Regresion")]                         // Categoriza 
        [Repeat(3)]                                     // Se repita 3 veces 
        [Ignore("No se aprueba")]                       // No ejecuta el caso  
        [Order(2)]
        [TestCase("tomsmith", "pass")]// Escenario usuario incorrecto
        */

        [TestCase("tomsmith", "SuperSecretPassword")]
        public void IngresoCorrecto(String user, string pass)
        {
            login.IngresarCredenciales(user,pass);
        }

    }
}