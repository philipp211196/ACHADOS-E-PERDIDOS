# Achados e Perdidos — Guia para Visual Studio 2022

## Requisitos

- Windows com Visual Studio 2022 e carga de trabalho *Desenvolvimento para desktop com .NET*.
- SDK .NET 8.
- MySQL Server e acesso ao MySQL Workbench.
- Conexão com a internet para restaurar os pacotes NuGet inicialmente.

## Inicializar o banco

1. Abra `Banco Achados e Perdidos.sql` no MySQL Workbench e execute o script.
2. O script cria o banco `achados_perdidos` com as tabelas `Usuarios` e `Itens`, se não existirem.
3. Configure `AP_DB_HOST`, `AP_DB_PORT`, `AP_DB_USER` e `AP_DB_PASSWORD` nas variáveis de ambiente da sua conta Windows.
4. Feche e reabra o Visual Studio após alterar as variáveis.

**Importante:** esta versão do código usa **MySQL**, e não SQLite. Instruções antigas de `dados.db` não se aplicam.

## Abrir e executar

1. Abra `AchadosPerdidos.csproj` no Visual Studio.
2. Aguarde a restauração do NuGet.
3. Pressione F5.
4. O ponto de entrada chama `Database.Initialize()` e abre `LoginForm`.
5. No primeiro acesso, o programa oferece a criação de administrador. Use senha de pelo menos 8 caracteres.
6. Após o login, utilize o menu principal para cadastrar, localizar ou devolver itens.

## Designer do Windows Forms

No Gerenciador de Soluções, expanda `UI`. Clique com o botão direito nos formulários e escolha **Exibir Designer** (Shift+F7). Os arquivos `.Designer.cs` e `.resx` dão suporte às telas. Algumas partes do layout de `MainForm` e `LabelForm` são construídas programaticamente.

## Dados e segurança

- Dados estruturados ficam no MySQL.
- Fotografias ficam na pasta `%LOCALAPPDATA%\AchadosPerdidos\Fotos`.
- As senhas são armazenadas como hashes PBKDF2-SHA256 com salt aleatório.
- Nunca publique senha do MySQL. Faça backup do banco e dos arquivos de fotos juntos.
- Não exponha o servidor MySQL diretamente à internet.

## Testes recomendados

- Primeiro login e criação de administrador.
- Bloqueio de senha incorreta.
- Cadastro de objeto com foto e etiqueta.
- Busca e filtros.
- Devolução e histórico.
- Cadastro de funcionários pelo administrador.

**Aviso:** código ainda não compilado/testado em uma instalação Windows neste atendimento.
