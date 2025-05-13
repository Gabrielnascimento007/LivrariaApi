# 📚 Livraria API

API REST desenvolvida em ASP.NET Core para gerenciamento de livros em uma livraria online. Permite operações de **criação**, **edição**, **listagem**, **busca por ID** e **exclusão** de livros, com persistência simulada em memória.

---

## 🚀 Tecnologias Utilizadas

- .NET 7 / ASP.NET Core Web API
- C#
- Swagger (Swashbuckle) para testes e documentação
- Simulação de repositório em memória (`static List<T>`)

---

## 🔧 Funcionalidades da API

| Verbo HTTP | Rota               | Ação                                  |
|------------|--------------------|----------------------------------------|
| `GET`      | `/api/Livro`       | Lista todos os livros                  |
| `GET`      | `/api/Livro/{id}`  | Retorna um livro específico por ID     |
| `POST`     | `/api/Livro`       | Cria um novo livro                     |
| `PUT`      | `/api/Livro/{id}`  | Atualiza um livro existente            |
| `DELETE`   | `/api/Livro/{id}`  | Remove um livro do sistema             |

---

## 🧱 Estrutura Esperada de um Livro

```json
{
  "titulo": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "genero": "Fantasia",
  "preco": 79.90,
  "quantidade": 50
}

---

📂 Organização do Projeto

LivrariaApi/
├── Controllers/
│   └── LivroController.cs
├── Communication/
│   ├── Requests/
│   │   └── RequestsLivroJson.cs
│   └── Response/
│       └── ResponseRegisterLivroJson.cs
├── Data/
│   └── LivroRepository.cs
├── Models/
│   └── Livro.cs
├── Program.cs
├── Startup.cs (caso esteja separado)

---

🧪 Como testar localmente

    Clone o repositório:

git clone https://github.com/seu-usuario/livraria-api.git
cd livraria-api

    Rode a aplicação:

dotnet run

    Acesse o Swagger para testar a API:

https://localhost:7287/swagger

---

💡 Observações

    A API usa um repositório em memória, então os dados serão perdidos ao reiniciar o servidor.

    Ideal para protótipos, testes locais ou desafios de programação.

    Caso deseje persistência real, considere integrar com o Entity Framework Core e um banco de dados (SQL Server, SQLite, etc).
