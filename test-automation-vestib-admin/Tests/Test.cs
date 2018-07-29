using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_automation_vestib_admin.Uteis;

namespace test_automation_vestib_admin.Tests
{
    
    public class Teste : WebDriver
    {
        [Test]
        public void Teste_Relatorio()
        {
            Relatorio.iniciarTeste("Teste Teste");
            Relatorio.criarArquivoLog();
            Relatorio.gravarLogInfo("Teste gravar");

        }

    }
}
