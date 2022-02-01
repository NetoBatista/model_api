# ModelAPI
 É um modelo para criação de outras API'S utilizando conceito de microserviço

 É dividido nos seguintes módulos:
  - API
  - Application

## Framework

Foi utilizado .net 6.0 na criação desse modelo

## API

 É onde encontra-se os modelos de configuração e execução da API. 
 Esse modulo contem **Program.cs**, **InjectionDependences** e **Endpoints** para configuração da API

  ### **Program.cs**
 É a configuração padrão da API. Nele é declarado a criação do swagger, https redirection, além de executar a funções de injeção de dependência e criação de endpoint.

  ### **InjectionDependences**
É onde fica declarado as injeções de dependência da API

  ### **Endpoints**
É onde fica a criação e configuração de execução dos endpoints

## Application

É responsavel por apresentar a camada de contratros (Request e response), além dos serviços e de suas respectivas interfaces.



