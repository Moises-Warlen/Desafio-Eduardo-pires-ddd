📌 Descrição do Projeto - Arquitetura DDD (Domain-Driven Design)
Este projeto foi desenvolvido com base nos conceitos e práticas da arquitetura DDD (Domain-Driven Design), conforme ensinados pelo especialista Eduardo Pires. O objetivo é criar uma estrutura limpa, escalável e de fácil manutenção, separando claramente as responsabilidades entre as camadas da aplicação e promovendo um domínio rico e bem estruturado.

✅ Objetivos
Aplicar os princípios do DDD com foco em regras de negócio.

Separar infraestrutura, aplicação, domínio e interfaces.

Implementar uma arquitetura em camadas (Layers) com Injeção de Dependência, SOLID, Separation of Concerns e Testabilidade.

Demonstrar um padrão de projeto real para aplicações empresariais.

🧱 Estrutura da Solução
O projeto segue a seguinte divisão em camadas:

Domain: Contém as entidades, agregados, value objects, interfaces de repositórios e serviços de domínio. Tudo que representa a lógica de negócio da aplicação.

Application: Camada responsável pelos casos de uso da aplicação. Contém os serviços de aplicação e os DTOs (Data Transfer Objects).

Infra.Data: Responsável pelo acesso a dados. Implementa os repositórios definidos na camada de domínio, utilizando EF Core ou outro ORM.

Infra.CrossCutting: Centraliza recursos comuns como autenticação, notificações, mapeamento (AutoMapper), validações, e configuração de injeção de dependências.

Presentation (API ou MVC): Camada de interface com o usuário. Responsável por expor os endpoints (REST, MVC, etc) e interagir com a camada de aplicação.

🧰 Tecnologias Utilizadas
ASP.NET Core

C#

Entity Framework Core

AutoMapper

FluentValidation

MediatR

Swagger

SQL Server

📚 Princípios Aplicados
Domain-Driven Design (DDD)

SOLID

Clean Code

Repository Pattern

Unit of Work

CQRS (Command and Query Responsibility Segregation)
