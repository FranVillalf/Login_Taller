using Login_Taller.Genericos;
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
        public LeerJson json;
        public String baseURL = "https://the-internet.herokuapp.com/login";
        

        [SetUp]
        public void IniciarNavegador()
        { 
            driver = new ChromeDriver();   
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseURL);
            login = new LoginPage(driver);
            json = new LeerJson();
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


        public void IngresoCorrecto()
        {
            var data = json.Login_data();
            String user = json.Login_data().username;
            String pass = json.Login_data().password;

            login.IngresarCredenciales(user,pass);
        }

    }
}