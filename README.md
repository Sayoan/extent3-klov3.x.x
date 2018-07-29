# extent3-klov3.x.x
Projeto com exemplo da aplicação do recurso Klov e ExtentReport3

Instalação:

# Instalar MongoDB

  - Utilizar mondoDB versão inferior à 3.4.
  - Disponível em: https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/
  - Criar o path "data/db"
  - Criar o path "data/log"
  - Abrir um prompt em modo admin e executar: "C:\Program Files\MongoDB\Server\3.SUAVERSAO\bin\mongod.exe" --dbpath="c:\data\db"
  - Permitir no firewall
  - Caso esteja corretamente configurado, será exibido a mensagem: "[initandlisten] waiting for connections"


# Instalar Mongo

  - Pré-requisito: MongoDB instalado.
  - Executar o serviço "C:\Program Files\MongoDB\Server\3.2\bin\mongo.exe"


# Baixar o Klov

  - Disponível em: http://extentreports.com/community/
  - Extrair no diretório: C:
  - No diretório onde foi extraído, verificar a porta, configurar conforme necessidade no arquivo: application.properties. A variável se chama "server.port".
  - Executar o serviço do klov: "C:\klov\klov-x.x\java -jar klov-x-x.jar"
  - Acessar localhost:porta para validar o sucesso


#Configurar o projeto de automação de testes com o Extent3
  - Vide projeto neste repositório.
  - Funções no App.config
  - Funções nas classes Relatorio.cs e Webdriver.cs
