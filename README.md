# **Sistema de Lembretes**

Este projeto consiste em um sistema de criação de lembretes desenvolvido em C# .NET 6, utilizando a interface gráfica Windows Forms. 
Com esse sistema, os usuários podem adicionar novos lembretes, informando o nome e a data desejada. O sistema realiza validações nos campos para garantir que estejam preenchidos corretamente, e que a data informada seja válida e esteja no dia presente ou no futuro. 
Os lembretes adicionados são exibidos em uma lista, que é organizada em ordem cronológica.

## **Funcionalidades**
O sistema oferece as seguintes funcionalidades:

- Adicionar novo lembrete: O usuário pode adicionar um novo lembrete, informando o nome e a data do lembrete desejado.

- Validação dos campos: Ao clicar em "Criar", os campos são validados seguindo as seguintes regras:
    - O campo "Nome" deve estar preenchido.
    - O campo "Data" deve estar preenchido com uma data válida, e essa data deve ser a atual ou uma data futura.
    - Exibição dos lembretes: Os lembretes válidos são exibidos na seção "Lista de lembretes" do sistema.

- Deletar lembrete: É possível excluir um lembrete anteriormente adicionado clicando no botão "Remover".

- Agrupamento por data: Ao adicionar um novo lembrete, caso a data já exista, o lembrete será exibido juntamente com os outros referente àquele dia.

- Ordenação cronológica: Os dias da lista de lembretes são exibidos em ordem cronológica, garantindo uma visualização organizada.

## **Como executar o projeto**
Certifique-se de ter o ambiente de desenvolvimento C# .NET 6 instalado em sua máquina.

1. Clone o repositório para o seu ambiente local. <br>
`git clone https://github.com/seu-usuario/nome-do-repositorio.git`

2. Abra a solução do projeto utilizando o Visual Studio.

3. Compile o projeto para garantir que todas as dependências sejam baixadas e as classes sejam compiladas corretamente.

4. Execute o projeto

Também é possível baixar o projeto zip e o executar pelo .exe <br>
[Clique aqui para baixar o projeto](https://github.com/gabriellaxdantas/Sistema-de-Lembretes/tree/dev) <br>



