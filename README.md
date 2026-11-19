# 🔎 Achados e Perdidos

Sistema acadêmico desktop desenvolvido com **C#**, **.NET 8**, **Windows Forms** e **MySQL** para gerenciar objetos encontrados e devoluções.

## Funcionalidades do projeto

- Autenticação de funcionários e criação de administrador.
- Cadastro e consulta de objetos perdidos.
- Fotos dos itens, pesquisa e filtros.
- Registro de devolução com histórico.
- Etiquetas e QR Code.
- Administração de usuários.

## Tecnologias

C# · .NET 8 · Windows Forms · MySQL · MySqlConnector · QRCoder

## Preparação

1. Abra `AchadosPerdidos.csproj` no Visual Studio 2022 com suporte ao .NET 8.
2. Execute o script `Banco Achados e Perdidos.sql` no MySQL.
3. Configure `AP_DB_HOST`, `AP_DB_PORT`, `AP_DB_USER` e `AP_DB_PASSWORD` nas variáveis de ambiente.
4. Restaure os pacotes NuGet e execute o projeto.

Consulte [GUIA_LOGIN_E_DESIGNER.md](GUIA_LOGIN_E_DESIGNER.md).

> **Status:** arquivos em publicação. A compilação ainda não foi testada no Windows. Não use senhas reais no código.

**Autor:** [Philipp Magalhães](https://github.com/philipp211196)
