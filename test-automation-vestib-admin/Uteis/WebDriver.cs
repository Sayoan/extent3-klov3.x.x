using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_automation_vestib_admin.Uteis
{
    public class WebDriver
    {

        public static IWebDriver driver { get; set; }

        public Relatorio Relatorio { get; protected set; }


        public WebDriver()
        {
            Relatorio = new Relatorio();
        }//fim construtor




        [SetUp]
        public void SetUp()
        {
            try
            {
                //Método responsável para criar o log de relatórios antes de iniciar o teste
                Relatorio.criarArquivoLog();

                driver = new ChromeDriver(@"C:\Drivers");
                driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }         
        }//fim void

        [TearDown]
        public void TearDown()
        {
            Relatorio.report.Flush();
            driver.Quit();
        }//fim void



    }//fim class
}//fim namespace
