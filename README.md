# 📚 Livraria API

API REST em ASP.NET Core para gerenciamento de livros em uma livraria online. Permite criar, listar, editar e remover livros com armazenamento em memória (simulado).

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core (.NET 7)
- C#
- Swagger (Swashbuckle)
- Simulação de persistência com lista em memória (`static List<T>`)

---

## 🔧 Funcionalidades

| Verbo HTTP | Rota              | Ação                            |
|------------|-------------------|----------------------------------|
| `GET`      | `/api/Livro`      | Lista todos os livros            |
| `GET`      | `/api/Livro/{id}` | Busca um livro por ID            |
| `POST`     | `/api/Livro`      | Cria um novo livro               |
| `PUT`      | `/api/Livro/{id}` | Atualiza dados de um livro       |
| `DELETE`   | `/api/Livro/{id}` | Remove um livro da listagem      |

---

## 📘 Estrutura esperada de um Livro

```json
{
  "titulo": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "genero": "Fantasia",
  "preco": 79.90,
  "quantidade": 50
}
```
---

🗂️ Estrutura do Projeto

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

---

▶️ Como executar o projeto localmente
1. Clonar o repositório

git clone https://github.com/seu-usuario/livraria-api.git
cd livraria-api

2. Executar o projeto

dotnet run

3. Testar no navegador (Swagger)

Acesse:

https://localhost:7287/swagger

---

⚠️ Observações

    Os dados são armazenados em memória, ou seja, se perdem ao reiniciar a aplicação.

    Ideal para testes locais, prototipagem e desafios técnicos.

    Para uso real, recomenda-se integrar com o Entity Framework Core e um banco de dados relacional.
