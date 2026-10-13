# ProjetoMVC — Agência de Viagem

> 📦 **Projeto de estudo — não recebe mais atualizações.**

Site de uma agência de viagem fictícia, feito em dezembro de 2021 como exercício de estudo. O repositório traz duas versões do mesmo projeto:

- **`AgenciaDeViagem/`**: versão estática em HTML + CSS (páginas inicial, destinos, promoções e contato).
- **`AG/Agencia/`**: a mesma ideia portada para **ASP.NET Core MVC**, com um CRUD de clientes (nome, CPF, telefone, endereço, nascimento e situação) persistido em SQL Server via Entity Framework Core.
- **`AG/*.brM` e `AG/Marcio_Logio_script.sql`**: modelos conceitual e lógico do banco (brModelo) e o script SQL gerado.

## Tecnologias

- C# / ASP.NET Core MVC (.NET 5)
- Entity Framework Core 5 (SQL Server, migrations)
- HTML, CSS e Bootstrap
- brModelo (modelagem do banco)

## Como abrir / rodar

**Versão estática:** abra `AgenciaDeViagem/index.html` no navegador.

**Versão MVC:**

1. Instale o SDK do .NET 5 (ou um SDK mais novo com o *targeting pack* do .NET 5) e um SQL Server local.
2. Ajuste a string de conexão em `AG/Agencia/Agencia/Data/Contexto.cs` — hoje ela aponta para a máquina original (`DESKTOP-KOD9I0N`); troque por `Server=.;Database=Agencia;Trusted_Connection=True` ou equivalente.
3. Crie o banco com as migrations:
   ```bash
   cd AG/Agencia/Agencia
   dotnet tool install --global dotnet-ef   # se ainda não tiver
   dotnet ef database update
   ```
4. Rode o projeto:
   ```bash
   dotnet run
   ```
5. Acesse o endereço exibido no terminal (veja `Properties/launchSettings.json`). O cadastro de clientes fica em `/Cliente`.

> O .NET 5 está fora de suporte. Para rodar num ambiente atual, pode ser necessário trocar o `TargetFramework` no `Agencia.csproj` e atualizar os pacotes do EF Core.
