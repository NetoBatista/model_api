# ModelAPI
 É um modelo para criação de outras API'S utilizando conceito clean code api

## Framework

Foi utilizado .net 6.0 na criação desse modelo

## Sobre a arquitetura

 - Com essa arquitetura é possível fazer com que cada request caia sobre um unico negócio. 
 - Toda chamada será realizada através do método *Execute* ou *ExecuteAsync* descrito em **IUseCase**
 - Toda requisicao irá trafegar entre seus serviços que estarão de acordo com o objeto de **request** e **response**
 - Dessa forma é garantido um código pequeno, estável e com responsabilidade unica. Onde possui uma unica entrada e uma unica saida desejada além de ter seu prório serviço

 Exemplo:
  - Caso a rota **/User** seja chamada como **POST** entao seu objeto de entrada e saida serão unicos **UserAddRequest** e **UserAddResponse**. Com isso irá cair no serviço responsavel por adicionar o usuario **UserAddService** que por sua vez poderá efetuar sua regra de negocio descrita tanto em seu *service* quanto nos métodos chamados nos *repository*
  
  - Caso a rota **/HelloWorld** seja chamada como **GET** entao seu objeto de entrada e saida serão unicos **HelloWorldRequest** e **UserAddResponse**. Com isso irá cair no serviço responsavel por retornar uma mensagem **HelloWorldResponse** que por sua vez poderá efetuar sua regra de negocio descrita tanto em seu *service* quanto nos métodos chamados nos *repository*


## Modelo API
 É dividido nos seguintes módulos:
  - API
  - Domain
  - Infra.data
  - Service

## API

 É onde encontra-se os modelos de configuração e execução da API. 
 Esse módulo apresenta os controllers, extensões, middlewares e configurações para o **Startup.cs** e **Program.cs**

## Domain

 É responsável pela implementação de classes/modelos, as quais serão mapeadas para o banco de dados, além de obter as declarações de interfaces, constantes, DTOs (Data Transfer Object) e enums.

## Infra.data

 Pode ser dividida em duas sub-camadas
- Data: realiza a persistência com o banco de dados, utilizando, ou não, algum ORM.
- Cross-Cutting: uma camada a parte que não obedece a hierarquia de camada. Como o próprio nome diz, essa camada cruza toda a hierarquia. Contém as funcionalidades que pode ser utilizada em qualquer parte do código, consumo de API externa e utilização de alguma segurança.

## Service

 É responsável pelas regras de negócios e validações antes de persistir os dados no banco de dados ou consumir API externas
