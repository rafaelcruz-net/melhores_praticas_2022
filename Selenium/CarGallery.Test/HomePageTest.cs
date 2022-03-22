using OpenQA.Selenium;
using System.Collections.Generic;
using Xunit;

namespace CarGallery.Test
{
    public class HomePageTest
    {
        [Fact]
        public void DeveMostrarItensPaginaHome()
        {
            IWebDriver webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

            webDriver.Url = "https://localhost:5001";
            webDriver.Navigate();

            var elements = webDriver.FindElements(By.ClassName("col-lg-6"));

            Assert.True(elements.Count == 5);

            webDriver.Quit();
        }

        [Fact]
        public void DeveMostrarItensPaginaHomeComImagem()
        {
            IWebDriver webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

            webDriver.Url = "https://localhost:5001";
            webDriver.Navigate();

            var elements = webDriver.FindElements(By.ClassName("col-lg-6"));

            foreach (var item in elements)
            {
                var image = (IWebElement)item.FindElement(By.ClassName("img-responsive"));
                Assert.NotNull(image.GetAttribute("src"));
            }

            webDriver.Quit();
        }

        [Fact]
        public void DeveEntrarNaGalariaPeloMenu()
        {
            IWebDriver webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

            webDriver.Url = "https://localhost:5001";
            webDriver.Navigate();

            var menu = webDriver.FindElement(By.ClassName("dropdown-menu")).FindElements(By.ClassName("nav-link"));

            List<(string name, string link)> menuItens = new List<(string, string)>();

            foreach (var item in menu)
            {
                (string name, string link) tupla = (name: item.Text, link: item.GetAttribute("href"));
                menuItens.Add(tupla);
            }

            foreach (var item in menuItens)
            {
                webDriver.Url = item.link;
                webDriver.Navigate();

                var element = webDriver.FindElement(By.TagName("h1"));

                Assert.NotNull(element);
                Assert.True(webDriver.Url == item.link);
            }

            webDriver.Quit();

        }

        [Fact]
        public void DeveEnviarContatoComSucesso()
        {
            IWebDriver webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

            webDriver.Url = "https://localhost:5001/Contact";
            webDriver.Navigate();

            IWebElement inputName = webDriver.FindElement(By.Id("Name"));
            IWebElement inputEmail = webDriver.FindElement(By.Id("Email"));
            IWebElement inputMensagem = webDriver.FindElement(By.Id("Message"));
            IWebElement button = webDriver.FindElement(By.ClassName("btn-primary"));

            inputName.SendKeys("Rafael Cruz");
            inputEmail.SendKeys("teste@teste.com");
            inputMensagem.SendKeys("lorem ipsum bla bla bla");

            button.Submit();

            IWebElement mensagem = webDriver.FindElement(By.ClassName("alert-success"));
            Assert.True(mensagem.Displayed);

            webDriver.Quit();

        }

        [Fact]
        public void DeveValidarInputNomeNoFormularioContato()
        {
            IWebDriver webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

            webDriver.Url = "https://localhost:5001/Contact";
            webDriver.Navigate();

            IWebElement inputEmail = webDriver.FindElement(By.Id("Email"));
            IWebElement inputMensagem = webDriver.FindElement(By.Id("Message"));
            IWebElement button = webDriver.FindElement(By.ClassName("btn-primary"));

            inputEmail.SendKeys("teste@teste.com");
            inputMensagem.SendKeys("lorem ipsum bla bla bla");

            button.Submit();

            IWebElement mensagem = webDriver.FindElement(By.Id("Name-error"));
            Assert.True(mensagem.Displayed);
            Assert.True(mensagem.Text == "Nome é obrigatório");

            webDriver.Quit();

        }



    }
}