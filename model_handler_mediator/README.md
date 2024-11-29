### ModelAPI
  It is a model for creating other APIs using the **Mediator** concept

The translation of Mediator into Portuguese is mediator, which is exactly what the pattern does. It mediates our communications, abstracting this for us.
In short, what we are going to do is simply receive a command and tell the Mediator to do its thing, and it will be in charge of finding the responsible Handler and executing it.

##Framework

.NET 8.0 was used to create this model

### About the architecture

  - With this architecture, it is possible to make each request fall on a single business.
  - Every call will be made through the *Send* method described in **Model.Handlers**
  - Every request will travel between your services that will be in accordance with the **request** and **response** object
  - This way, a small, stable code with a single responsibility is guaranteed. Where there is a single input and a single desired output in addition to having its own service

  Example:
   - If the route **/User** is called **POST** then its input and output objects will be unique **UserAddRequest** and **UserAddResponse**. This will fall to the service responsible for adding the user **UserAddService**, which in turn will be able to carry out your business rule described both in your *service* and in the methods called in the *repository*
  
   - If the route **/HelloWorld** is called **GET** then its input and output objects will be unique **HelloWorldRequest** and **UserAddResponse**. This will fall to the service responsible for returning a **HelloWorldResponse** message which in turn can carry out your business rule described both in your *service* and in the methods called in the *repository*


### API Model
  It is divided into the following modules:
   - API
   -Domain
   - Infra.data
   - Handlers

### API

  This is where the API configuration and execution models are located.
  This module presents the controllers, extensions, middleware and configurations for **Startup.cs** and **Program.cs**

### Domain

  It is responsible for implementing classes/models, which will be mapped to the database, in addition to obtaining declarations of interfaces, constants, DTOs (Data Transfer Object) and enums.

### Infra.data

  Can be divided into two sub-layers
- Data: performs persistence with the database, whether or not using an ORM.
- Cross-Cutting: a separate layer that does not follow the layer hierarchy. As the name suggests, this layer crosses the entire hierarchy. Contains functionalities that can be used in any part of the code, consumption of external API and use of some security.

### Service

  Responsible for business rules and validations before persisting data in the database or consuming external APIs

# 

### ModelAPI
 É um modelo para criação de outras API'S utilizando conceito **Mediator**

 A tradução de Mediator para o português é mediador, justamente o que o padrão faz. Ele intermédia as comunicações da nossa abstraindo isto pra gente.
 Em suma o que vamos fazer é simplesmente receber um comando e dizer para o Mediator se virar, e ele se encarregará de encontrar o Handler responsável e executá-lo.

### Framework

Foi utilizado .net 8.0 na criação desse modelo

### Sobre a arquitetura

 - Com essa arquitetura é possível fazer com que cada request caia sobre um unico negócio. 
 - Toda chamada será realizada através do método *Send* descrito em **Model.Handlers**
 - Toda requisicao irá trafegar entre seus serviços que estarão de acordo com o objeto de **request** e **response**
 - Dessa forma é garantido um código pequeno, estável e com responsabilidade unica. Onde possui uma unica entrada e uma unica saida desejada além de ter seu prório serviço

 Exemplo:
  - Caso a rota **/User** seja chamada como **POST** entao seu objeto de entrada e saida serão unicos **UserAddRequest** e **UserAddResponse**. Com isso irá cair no serviço responsavel por adicionar o usuario **UserAddService** que por sua vez poderá efetuar sua regra de negocio descrita tanto em seu *service* quanto nos métodos chamados nos *repository*
  
  - Caso a rota **/HelloWorld** seja chamada como **GET** entao seu objeto de entrada e saida serão unicos **HelloWorldRequest** e **UserAddResponse**. Com isso irá cair no serviço responsavel por retornar uma mensagem **HelloWorldResponse** que por sua vez poderá efetuar sua regra de negocio descrita tanto em seu *service* quanto nos métodos chamados nos *repository*


### Modelo API
 É dividido nos seguintes módulos:
  - API
  - Domain
  - Infra.data
  - Handlers

### API

 É onde encontra-se os modelos de configuração e execução da API. 
 Esse módulo apresenta os controllers, extensões, middlewares e configurações para o **Startup.cs** e **Program.cs**

### Domain

 É responsável pela implementação de classes/modelos, as quais serão mapeadas para o banco de dados, além de obter as declarações de interfaces, constantes, DTOs (Data Transfer Object) e enums.

### Infra.data

 Pode ser dividida em duas sub-camadas
- Data: realiza a persistência com o banco de dados, utilizando, ou não, algum ORM.
- Cross-Cutting: uma camada a parte que não obedece a hierarquia de camada. Como o próprio nome diz, essa camada cruza toda a hierarquia. Contém as funcionalidades que pode ser utilizada em qualquer parte do código, consumo de API externa e utilização de alguma segurança.

### Service

 É responsável pelas regras de negócios e validações antes de persistir os dados no banco de dados ou consumir API externas
