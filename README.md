# API de Gerenciamento de Pedidos

Projeto desenvolvido utilizando **C#**, **ASP.NET Core Minimal API**, **Entity Framework Core** e **SQLite**, com o objetivo de implementar uma API REST para gerenciamento de pedidos, realizando operações completas de CRUD (Create, Read, Update e Delete).

## 📖 Sobre o Projeto

Esta aplicação permite o cadastro, consulta, atualização e exclusão de pedidos através de endpoints RESTful.

O projeto foi desenvolvido para praticar conceitos fundamentais de desenvolvimento back-end, incluindo:

* Criação de APIs REST
* Minimal APIs do ASP.NET Core
* Persistência de dados com SQLite
* Entity Framework Core
* Operações CRUD
* Consultas utilizando LINQ
* Manipulação de requisições HTTP

---

## 🛠 Tecnologias Utilizadas

* C#
* .NET
* ASP.NET Core Minimal API
* Entity Framework Core
* SQLite
* LINQ

---

## 📂 Estrutura do Projeto

```text
📦 API-Pedidos
 ┣ 📜 Program.cs
 ┣ 📜 pedidos.db
 ┣ 📜 appsettings.json
 ┣ 📜 requests.http
 ┗ 📜 README.md
```

---

## ⚙️ Funcionalidades

### ✅ Criar Pedido

Permite cadastrar um novo pedido.

```http
POST /pedidos
```

Exemplo:

```json
{
  "nome": "Produto",
  "produto": "Produto",
  "quantidade": 5,
  "preco": 20.00
}
```

---

### ✅ Listar Todos os Pedidos

```http
GET /pedidos
```

---

### ✅ Buscar Pedido por ID

```http
GET /pedidos/{id}
```

---

### ✅ Buscar Pedido por Nome

```http
GET /pedidos/nome/{nome}
```

---

### ✅ Atualizar Pedido

```http
PUT /pedidos/{id}
```

Exemplo:

```json
{
  "nome": "ProdutoEditado",
  "produto": "ProdutoEditado",
  "quantidade": 50,
  "preco": 200.00
}
```

---

### ✅ Excluir Pedido

```http
DELETE /pedidos/{id}
```

---

## 🚀 Como Executar o Projeto

### 1. Clonar o Repositório

```bash
git clone https://github.com/SEU-USUARIO/NOME-DO-REPOSITORIO.git
```

### 2. Acessar a Pasta

```bash
cd NOME-DO-REPOSITORIO
```

### 3. Restaurar Dependências

```bash
dotnet restore
```

### 4. Executar o Projeto

```bash
dotnet run
```

A API ficará disponível em:

```text
http://localhost:5190
```

---

## 🧪 Testando a API

Você pode testar utilizando:

* Visual Studio HTTP File (.http)
* Postman
* Insomnia
* Swagger (caso seja implementado)

## 🎯 Objetivos de Aprendizagem

Este projeto foi desenvolvido para consolidar conhecimentos em:

* Desenvolvimento Back-end
* APIs RESTful
* Entity Framework Core
* Banco de Dados SQLite
* Programação em C#
* Arquitetura de APIs

---

## 👩‍💻 Desenvolvedora

**Letícia Justino Wehbe**

Estudante de Análise e Desenvolvimento de Sistemas, apaixonada por tecnologia, desenvolvimento de software e aprendizado contínuo.

---

⭐ Se você gostou deste projeto, deixe uma estrela no repositório!
