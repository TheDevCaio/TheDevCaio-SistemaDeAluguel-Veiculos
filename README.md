DOCUMENTAÇÃO DO SOFTWARE

Sumário:

/Introdução - pg 3/

/Objetivos do Projeto - pg	3/

/Público-alvo	3 - pg 3/

/Requisitos Funcionais - pg 4/

/Arquitetura e Tecnologias Utilizadas	- pg 4/

/Fluxo de Funcionalidades	4 - pg 4/

/Diagrama de Caso de Uso	5 - pg 5/

/Descrição de caso de uso	5 - pg 5/


 
Introdução:

Este documento descreve o projeto de desenvolvimento de software para o Sistema de Controle de Atendimento de Locação de Automóveis. O sistema tem como objetivo otimizar as operações da loja, facilitando o controle de cadastros, agendamentos, serviços e informações financeiras. Este documento detalha os requisitos do sistema, sua arquitetura, tecnologias utilizadas, interfaces de usuário e fluxos de trabalho.
Objetivos do Projeto
O Sistema de Atendimento de Locação de Automóveis tem como principais objetivos:
•	Automatizar o processo de cadastro de clientes e veículos.
•	Permitir o registro de informações dos carros, como modelo, potência, cor, entre outras características.
•	Facilitar o agendamento de locação dos produtos.
•	Proporcionar um controle financeiro integrado com o registro de transações financeiras.
•	Melhorar a eficiência operacional e proporcionar uma experiência de atendimento mais ágil e organizada aos clientes.
Público-alvo
Este documento se destina aos arquitetos de software, engenheiros de software e testadores.

Requisitos Funcionais
Os principais requisitos funcionais do Sistema de Atendimento de Locação de Automóveis são:
1.0 Cadastro de Clientes:
Permitir o registro de novos clientes, incluindo nome, endereço, telefone e outros dados pertinentes.
1.1 Cadastro de Veículos:
Possibilitar o registro de carros e motos pertencentes ao dono da locadora.
1.2 Registro de Locação
Permitir o registro das datas dos últimos carros alugado, junto aos que estão ou não disponíveis.
1.3 Agendamento:
Permitir o agendamento de produto, possibilitando a escolha de data e horário disponíveis.
1.4 Controle Financeiro:
Exigir senha para acesso ao módulo financeiro.
Permitir o registro de transações financeiras, como pagamentos e recebimentos.
Gerar relatórios financeiros, como balanço de caixa e faturamento.
1.5 Interface de Usuário Amigável:
Fornece uma interface gráfica intuitiva e de fácil navegação para atendentes e funcionários do sistema.
Arquitetura e Tecnologias Utilizadas
O Sistema para Controle de Atendimento de Locação de Automóveis foi desenvolvido como uma aplicação desktop utilizando a linguagem de programação C#. A interface gráfica é criada utilizando framework .NET Framework (WPF). O banco de dados utilizado é o MySql para armazenar as informações de forma local.
Fluxo de Funcionalidades
A seguir, são apresentados os fluxos de funcionalidades do sistema:
Fluxo de Cadastro de Veículos:
1.	O atendente acessa a tela de cadastro de veículos.
2.	O atendente preenche os campos de informações do veículo.
3.	O sistema salva as informações.
4.	O atendente acessa a tela de cadastro.
5.	O atendente associa o produto ao pedido e faz a solicitação.
6.	O sistema salva o pedido do veículo e associa-o ao respectivo dono.
Fluxo de Atendente (Funcionário):
1.	O atendente seleciona o produto desejado na tela de busca.
2.	O atendente acessa a tela de registro.
3.	O atendente seleciona o tipo pedido e confirma, com os devidos dados.
4.	O sistema registra as informações na base de dados.
Fluxo de Agendamento de Veículos:
1.	O atendente acessa a tela de agendamento.
2.	O atendente seleciona o veículo para agendar.
3.	O atendente verifica se está disponível aquele horário e preenche os dados.
4.	O sistema registra o agendamento.
Fluxo de Controle Financeiro:
1.	O atendente seleciona a opção "Pagamento" no menu.
2.	O sistema exige a inserção de uma senha de acesso ao módulo financeiro.
3.	Se a senha estiver correta, o sistema abre a tela de controle financeiro, que permite gerenciar transações financeiras, como pagamentos e recebimentos.
4.	O atendente registra as transações financeiras necessárias.
5.	O sistema salva as informações no banco de dados.
Diagrama de Caso de Uso
 

Descrição de caso de uso
Este documento de software fornece uma visão geral do Sistema de Controle do Atendimento de Locação de Veículos, detalhando seus principais requisitos, arquitetura e fluxos de funcionamento. O projeto visa proporcionar a loja, uma solução automatizada e eficiente para melhorar suas operações e atendimento aos clientes.
Caso de Uso - Tela de Login
Ator Principal: Atendente da Empresa
Descrição: O caso de uso descreve as opções disponíveis desde a entrada no aplicativo, até a navegação pelo mesmo.
Fluxo Básico:
1. O atendente inicia o sistema e é apresentado à tela de Login e Cadastro.
2. Após logar, a tela de Menu exibe na parte superior: 
   1. Cadastros: Permite cadastrar novos veículos e pedidos.
   2. Pagamentos: Veja um dashboard dos pagamentos em Crédito e Débito (Requer senha de acesso);
   3. Logout: Volta para o menu.
3. O atendente seleciona uma das opções do menu.
Fluxos Alternativos:
Opção 1 - Cadastros:
    1. O atendente seleciona a opção "Cadastro" no menu.
    2. O sistema abre duas opções, a tela de cadastro de veículos e uma tela para realizar um pedido.
    3. O atendente preenche os detalhes necessários e confirma o cadastro de veículo ou o pedido do cliente, dependendo de onde entrou.
    4. O sistema salva as informações no banco de dados.
Opção 2 - Pagamento:
    1. O atendente seleciona a opção "Pagamento" no menu e abre “Crédito” ou “Débito”.
    2. O sistema em ambas as opções, exibe o total de contas a pagar, todos os registros de pedidos e demais informações necessárias.
    4. O sistema exibe os resultados encontrados na tela, caso você queira fazer uma busca nessa área.    1. O atendente seleciona a opção "Controle Financeiro" no menu.
    5. O sistema salva as informações no banco de dados.
 
As ações realizadas pelo atendente são devidamente registradas no banco de dados e refletem as mudanças nos dados do sistema (cadastros, agendamentos, etc.).
O sistema permanece disponível para uso contínuo ou para ser encerrado a qualquer momento pelo atendente, e suas telas são as seguintes:




![LoginV](https://github.com/TheDevCaio/TheDevCaio-SistemaDeAluguel-Veiculos/assets/110746976/5d2db3de-77d6-4a5e-8760-f2d7c0f9f787)

![RegistroV](https://github.com/TheDevCaio/TheDevCaio-SistemaDeAluguel-Veiculos/assets/110746976/30b544a7-43a9-41f4-b6e6-532e25e924d2)

![MenuV](https://github.com/TheDevCaio/TheDevCaio-SistemaDeAluguel-Veiculos/assets/110746976/716c0c00-cbb9-4c12-a0b3-28e736429c19)

![DebitV](https://github.com/TheDevCaio/TheDevCaio-SistemaDeAluguel-Veiculos/assets/110746976/67579f4e-d84d-4450-b367-f85d7e7a255e)

![CreditV](https://github.com/TheDevCaio/TheDevCaio-SistemaDeAluguel-Veiculos/assets/110746976/cb6910a3-ceae-4530-91fa-ecbbba42e7c2)

![PedidoV](https://github.com/TheDevCaio/TheDevCaio-SistemaDeAluguel-Veiculos/assets/110746976/b61a3674-d618-4ff1-a865-958073c47dfd)

