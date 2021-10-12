# ModelAPI
 É um modelo para criação de outras API'S utilizando conceito DDD (Domain Driven Design)

 É dividido nos seguintes módulos:
  - API
  - Domain
  - Infra.data
  - Service

## Framework

Foi utilizado .net 5.0 na criação desse modelo

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
