<div align="center">

# 🔎 Achados e Perdidos

### Sistema de controle de objetos encontrados e devolvidos

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)

**Projeto acadêmico | Aplicação desktop | Em desenvolvimento**

</div>

## 📌 Sobre

Aplicação desktop para registrar, localizar e devolver objetos perdidos em um ambiente institucional. Possui login para funcionários, cadastro de itens, histórico e emissão de etiquetas com QR Code.

## ✨ Funcionalidades presentes no código

- Autenticação de funcionários e criação de administrador no primeiro acesso.
- Senhas protegidas usando **PBKDF2-SHA256**, salt individual e 210.000 iterações.
- Cadastro e edição de objetos encontrados, com categoria, local, data e fotografia.
- Pesquisa e filtros por categoria e situação.
- Registro da devolução com dados do responsável e histórico.
- Etiquetas com código interno e geração de QR Code.
- Cadastro de usuários por administradores.

> O QR Code representa o código interno do objeto, não um endereço público.

## 🛠️ Tecnologias

| Camada | Tecnologia |
| --- | --- |
| Interface | C# / Windows Forms / .NET 8 |
| Banco de dados | MySQL |
| Conexão | MySqlConnector |
| QR Code | QRCoder |
| Fotos | Armazenamento local no diretório de dados do usuário |

## 🗂️ Estrutura

```text
AchadosPerdidos/
├── Data/Database.cs
├── Models/Item.cs
├── Services/MediaService.cs
├── UI/
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   ├── ItemForm.cs
│   ├── ReturnForm.cs
│   ├── LabelForm.cs
│   └── UserForm.cs
├── Program.cs
├── Banco Achados e Perdidos.sql
├── AchadosPerdidos.csproj
└── GUIA_LOGIN_E_DESIGNER.md
```

Os arquivos `.Designer.cs` e `.resx` das telas estão incluídos.

## ▶️ Instalação

1. Instale o **Visual Studio 2022** com a carga de trabalho **Desenvolvimento para desktop com .NET** e o **SDK .NET 8**.
2. Instale e inicie o **MySQL Server**.
3. Importe `Banco Achados e Perdidos.sql` no MySQL Workbench. Isso cria o banco `achados_perdidos` e as tabelas.
4. Configure as variáveis de ambiente do MySQL.
5. Abra `AchadosPerdidos.csproj` no Visual Studio, restaure os pacotes NuGet e execute com **F5**.
6. No primeiro acesso, cadastre um administrador com senha de pelo menos oito caracteres.

### Variáveis de ambiente

| Nome | Padrão |
| --- | --- |
| `AP_DB_HOST` | `127.0.0.1` |
| `AP_DB_PORT` | `3306` |
| `AP_DB_USER` | `root` |
| `AP_DB_PASSWORD` | vazia |

O nome do banco no código é `achados_perdidos`. Configure uma conta MySQL própria com permissões restritas em vez de usar `root` fora do ambiente de desenvolvimento. **Não publique credenciais.**

## 🧪 Estado do projeto

- [x] Código de telas, modelos e acesso ao banco incluído.
- [x] Ponto de entrada `Program.cs` incluído no pacote para GitHub.
- [x] Script MySQL incluído.
- [ ] Compilar e validar no Windows com MySQL configurado.
- [ ] Adicionar capturas reais das telas.
- [ ] Revisar tratamento de erros e testes de segurança antes de uso real.

> A aplicação **não foi compilada nem testada neste ambiente**. O material é um projeto de desenvolvimento, não um sistema homologado.

## 👨‍💻 Autor

[Philipp Magalhães](https://github.com/philipp211196)
