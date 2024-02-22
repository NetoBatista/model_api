### ModelAPI
  It is a model for creating other API'S using the microservice concept

  It is divided into the following modules:
    - API
    -Application

### Framework
  .NET 8.0 was used to create this model

### API
  This is where the API configuration and execution models are located.
  This module contains **Program.cs**, **InjectionDependences** and **Endpoints** for API configuration

### **Program.cs**
  It is the default API configuration. It declares the creation of swagger, https redirection, in addition to executing dependency injection and endpoint creation functions.

### **InjectionDependences**
  This is where API dependency injections are declared

### **Endpoints**
  This is where the creation and configuration of the execution of endpoints is located.

### Application

  It is responsible for presenting the contract layer (Request and response), in addition to the services and their respective interfaces.

#

### ModelAPI
 É um modelo para criação de outras API'S utilizando conceito de microserviço

 É dividido nos seguintes módulos:
  - API
  - Application

### Framework

Foi utilizado .net 8.0 na criação desse modelo

### API

 É onde encontra-se os modelos de configuração e execução da API. 
 Esse modulo contem **Program.cs**, **InjectionDependences** e **Endpoints** para configuração da API

### **Program.cs**
 É a configuração padrão da API. Nele é declarado a criação do swagger, https redirection, além de executar a funções de injeção de dependência e criação de endpoint.

### **InjectionDependences**
É onde fica declarado as injeções de dependência da API

### **Endpoints**
É onde fica a criação e configuração de execução dos endpoints

### Application

É responsavel por apresentar a camada de contratros (Request e response), além dos serviços e de suas respectivas interfaces.



