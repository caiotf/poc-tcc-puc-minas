
# POC TCC PUC Minas

Neste repositório, encontra-se uma aplicação de microsserviços construída na plataforma .NET e executada através do Docker. Esta aplicação é composta por um serviço principal Web, o qual se conecta a um API Gateway responsável por orquestrar as requisições destinadas a duas APIs distintas: uma voltada para a gestão de Produtos e outra dedicada à Avaliação.

## Pré-requisitos
Para executar a aplicação, você precisará ter o Docker instalado em sua máquina.

## Executando a aplicação
Para executar a aplicação, siga os passos abaixo:

1 - Clone o repositório em sua máquina local

2 - Navegue até o diretório `GSL_Publish_DockerHub`

3 - Execute o comando `docker-compose up -d`

4 - Acesse a aplicação no seu navegador através do endereço http://localhost:2222/Home/Index

## APIs
A aplicação possui duas APIs:

- Produtos: API responsável por gerenciar os produtos dos clientes na transportadora (http://localhost:5555/swagger/index.html)
- Avaliação: API responsável por gerenciar as avaliações dos clientes sobre a transportadora (http://localhost:4444/swagger/index.html)

## Usuários
A aplicação já possui alguns usuários cadastrados:

| Username             | Profile      | Password |
| --------- | ---------------- | -------- |
| Adm | Administrador | 123456 |
| Alfa | Cliente | 123456 |
| Beta | Cliente | 123456 |
| Delta | Cliente | 123456 |


Para cadastrar ou alterar um usuário, é necessário acessar o Keycloak e fazer as modificações necessárias. Para isso, acesse http://localhost:8080/auth/admin/master/console/ e entre com as credenciais: 

`Username: Admin` 

`Password: Admin`




