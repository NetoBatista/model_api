### ModelAPI
  It is a model for creating other API'S using DDD (Domain Driven Design) concept

  It is divided into the following modules:
   - API
   -Domain
   - Infra.data
   - Service

### Framework

.NET 8.0 was used to create this model

### API

  This is where the API configuration and execution models are located.
  This module presents the controllers, extensions, middleware and configurations for **Startup.cs** and **Program.cs**

### Domain

  It is responsible for implementing classes/models, which will be mapped to the database, in addition to obtaining declarations of interfaces, constants, DTOs (Data Transfer Object) and enums.

### Infra

  Can be divided into two sub-layers
- Data: performs persistence with the database, whether or not using an ORM.
- Cross-Cutting: a separate layer that does not follow the layer hierarchy. As the name suggests, this layer crosses the entire hierarchy. Contains functionalities that can be used in any part of the code, consumption of external API and use of some security.

### Service

  Responsible for business rules and validations before persisting data in the database or consuming external APIs

#

### ModelAPI
 É um modelo para criação de outras API'S utilizando conceito DDD (Domain Driven Design)

 É dividido nos seguintes módulos:
  - API
  - Domain
  - Infra.data
  - Service

### Framework

Foi utilizado .net 8.0 na criação desse modelo

### API

 É onde encontra-se os modelos de configuração e execução da API. 
 Esse módulo apresenta os controllers, extensões, middlewares e configurações para o **Startup.cs** e **Program.cs**

### Domain

 É responsável pela implementação de classes/modelos, as quais serão mapeadas para o banco de dados, além de obter as declarações de interfaces, constantes, DTOs (Data Transfer Object) e enums.

### Infra

 Pode ser dividida em duas sub-camadas
- Data: realiza a persistência com o banco de dados, utilizando, ou não, algum ORM.
- Cross-Cutting: uma camada a parte que não obedece a hierarquia de camada. Como o próprio nome diz, essa camada cruza toda a hierarquia. Contém as funcionalidades que pode ser utilizada em qualquer parte do código, consumo de API externa e utilização de alguma segurança.

### Service

 É responsável pelas regras de negócios e validações antes de persistir os dados no banco de dados ou consumir API externas
