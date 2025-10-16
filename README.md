# 📚 Livraria Controle de Empréstimo — Projeto CAFÉ COM BUG (MVC) ☕

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/C%23-Language-239120?logo=c-sharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/Architecture-MVC-lightgrey" alt="MVC">
  <img src="https://img.shields.io/badge/Entity%20Framework-Core-5C2D91?logo=entity-framework&logoColor=white" alt="EF Core">
  <img src="https://img.shields.io/badge/License-MIT-yellow" alt="License">
</p>

---

## ☕ Sobre o Projeto

Este projeto faz parte da série **Café com Bug** no YouTube e tem como objetivo demonstrar a criação de uma aplicação completa para **controle de empréstimos de livros**, utilizando **arquitetura MVC** com boas práticas de desenvolvimento em .NET.

O projeto enfatiza **organização, separação de responsabilidades** e **integração entre front-end e back-end**.

---

## 🏗️ Estrutura da Solução

O projeto segue a estrutura típica de **MVC (Model-View-Controller)**:

📁 LivrariaControleEmprestimo.MVC  
│  
├── 📂 Controllers  
├── 📂 Views  
├── 📂 Models  
├── 📂 Data  
└── 📂 wwwroot  



---

## 🔍 Finalidade de Cada Pasta / Camada

### **1️⃣ Controllers**
- Responsáveis por **processar as requisições HTTP**.
- Chamam a **camada de Models** para obter dados e retornam **Views** ao usuário.
- Contêm a lógica de **navegação e fluxo da aplicação**.

### **2️⃣ Views**
- Contêm os arquivos **HTML/Razor**, responsáveis pela **interface visual do usuário**.
- Renderizam os dados enviados pelos Controllers.

### **3️⃣ Models**
- Representam as **entidades e dados da aplicação**.
- Podem incluir **validações e regras simples de negócio**.
- Servem como ponte entre o banco de dados e as Views.

### **4️⃣ Data**
- Responsável pela **persistência de dados**, geralmente usando **Entity Framework Core**.
- Contém **DbContext**, **mapeamentos e repositórios**.

### **5️⃣ wwwroot**
- Contém arquivos **estáticos** como CSS, JS, imagens e fontes.

---

## 🧠 Fluxo da Aplicação (MVC)

1. O usuário realiza uma ação no navegador (clicando em botão, link ou formulário).  
2. O **Controller** processa a requisição e consulta os **Models**.  
3. O **Model** acessa o banco de dados e retorna os dados ao Controller.  
4. O **Controller** envia os dados para a **View** correspondente.  
5. A **View** renderiza o HTML final e envia ao navegador do usuário.  

> Diferente do padrão RESTful, aqui a aplicação **renderiza páginas completas**, não apenas JSON.

---

## 🌐 Arquitetura MVC x REST

| Aspecto | **Arquitetura MVC (Web App)** | **Arquitetura REST (API)** |
|----------|-------------------------------|-----------------------------|
| **Finalidade** | Renderizar páginas e fornecer interface ao usuário | Expor endpoints para comunicação entre sistemas |
| **Camadas** | Controller → View → Model | API → Application → Domain → Infra.Data → IoC |
| **Retorno** | HTML/Razor renderizado | JSON/XML |
| **Front-end** | Integrado à aplicação | Externo (React, Angular, mobile) |
| **Uso típico** | Aplicações web monolíticas | Microsserviços, APIs e integrações |

➡️ **Em resumo:**  
Este projeto é uma **aplicação MVC tradicional**, voltada para **interface e interação direta com o usuário**, enquanto o outro projeto segue **RESTful API** para serviços e integrações.

---

## 🧩 Tecnologias Utilizadas

- 🟣 **.NET 8 (ou superior)**
- 🧱 **Entity Framework Core**
- 🗄️ **SQL Server**
- 💬 **C# 12**
- 🎨 **Razor / Views**
- ⚙️ **MVC Pattern**

---

## 📘 Objetivos do Projeto

Este projeto foi desenvolvido com fins **educacionais**, para demonstrar:
- Boas práticas de **arquitetura MVC**;
- Integração entre **Views e Controllers**;
- Uso de **Entity Framework Core** para persistência de dados;
- Aplicação prática de **C# e Razor Pages**.

---

## 🧑‍💻 Como Executar o Projeto

```bash
Clone o repositório:
git clone https://github.com/JsnEvt/LivrariaControleEmprestimo.git

Acesse o diretório:
cd LivrariaControleEmprestimo

Configure o banco de dados:
Ajuste a ConnectionString no appsettings.json.

Execute as migrations (se aplicável):

dotnet ef database update

Inicie a aplicação:

dotnet run
```

Acesse a aplicação no navegador:

https://localhost:{porta} 

☕ Créditos

Projeto baseado na série Café com Bug do YouTube, adaptado e expandido para estudo e aprendizado de arquitetura MVC em .NET.

🏷️ Licença

Este projeto é de uso livre para fins educacionais.
Sinta-se à vontade para clonar, estudar e evoluir o código!

✨ Desenvolvido com dedicação, café e código limpo ☕💻


