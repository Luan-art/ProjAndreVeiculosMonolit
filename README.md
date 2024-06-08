# André's Veículos

**Visão Geral**

A aplicação "André's Veículos" é um sistema de gerenciamento para uma garagem de veículos. Desenvolvido em C# e abrange funcionalidades relacionadas a funcionários, clientes, vendas, compras, pagamentos e serviços prestados aos veículos.
Este documento define as regras de negócio e requisitos do sistema.

## Regras de Negócio

**1. Funcionários**

* Cada funcionário tem um identificador único, nome, cargo e comissão de vendas.
* A comissão de vendas é calculada como um percentual do valor total das vendas realizadas pelo funcionário.
* Um funcionário pode registrar vendas, compras e serviços de veículos.

**3. Clientes**
   
* Cada cliente possui um identificador único, nome, CPF/CNPJ, e endereço completo (rua, número, complemento, bairro, cidade, estado, CEP).
* Clientes podem comprar e vender veículos, bem como solicitar serviços para seus veículos.

**5. Veículos**

* Cada veículo tem um identificador único (placa), marca, modelo, ano, cor, quilometragem, e número de chassi.
* Veículos podem estar disponíveis para venda, já vendidos, ou em serviço (pintura, limpeza, conserto, etc).

**7. Vendas de Veículos**
   
* Uma venda de veículo envolve um cliente comprador, um funcionário vendedor, e um veículo.
* A venda deve registrar a data da venda e o valor da venda.
* O valor da comissão do funcionário vendedor é calculado com base no valor da venda e a taxa de comissão do funcionário.

**9. Compras de Veículos**
* Uma compra de veículo envolve um cliente vendedor, um funcionário responsável pela compra, e um veículo.
* A compra deve registrar a data da compra e o valor da compra.

**11. Pagamentos**
    
* Pagamentos podem ser realizados via cartão, pix ou boleto.
* Cada pagamento possui um identificador único, valor, data do pagamento e tipo de pagamento (cartão, pix, boleto).
* Detalhes adicionais são necessários dependendo do tipo de pagamento:
* Cartão: número do cartão, nome no cartão, validade, código de segurança.
* Pix: chave pix.
* Boleto: código de barras do boleto.

**13. Serviços de Veículos**
    
* Serviços oferecidos incluem pintura, limpeza, conserto, entre outros.
* Cada serviço deve registrar o tipo de serviço, descrição, data de início, data de conclusão e custo.
* Serviços são vinculados a um veículo e um cliente solicitante.

## Requisitos Funcionais

**1. Gerenciamento de Funcionários**
   
* Adicionar, editar e remover funcionários.
* Visualizar informações detalhadas dos funcionários, incluindo total de vendas e comissões acumuladas.

**3. Gerenciamento de Clientes**
   
* Adicionar, editar e remover clientes.
* Visualizar informações detalhadas dos clientes, incluindo histórico de compras, vendas e serviços solicitados.

**5. Gerenciamento de Veículos**
   
* Adicionar, editar e remover veículos do inventário.
* Visualizar informações detalhadas dos veículos, incluindo status (disponível, vendido, em serviço).

**7. Processamento de Vendas**
   
* Registrar novas vendas de veículos.
* Calcular e registrar a comissão de vendas para o funcionário responsável.
* Emitir comprovantes de venda para o cliente.

**9. Processamento de Compras**
    
* Registrar novas compras de veículos.
* Emitir comprovantes de compra para o cliente vendedor.

**11. Processamento de Pagamentos**
    
* Registrar pagamentos realizados via cartão, pix ou boleto.
* Validar informações de pagamento de acordo com o tipo selecionado.
* Emitir comprovantes de pagamento para o cliente.

**13. Gerenciamento de Serviços**
    
* Registrar novos serviços solicitados por clientes.
* Atualizar status dos serviços (em andamento, concluído).
* Emitir comprovantes de serviço para o cliente.

## Requisitos Não Funcionais

**1. Segurança**
   
* Criptografia de dados sensíveis (como informações de cartão de crédito).

**3. Usabilidade**
   
* Interface amigável e intuitiva para usuários finais.
* Funcionalidades de busca e filtros para facilitar a localização de registros.

**5. Desempenho**
   
* Tempo de resposta aceitável para todas as operações.
* Suporte a múltiplos usuários simultâneos sem degradação significativa do desempenho.

**7. Manutenibilidade**
   
* Código modular e bem documentado para facilitar futuras manutenções e atualizações.
* Adoção de boas práticas de desenvolvimento e padrões de codificação.

**9. Confiabilidade**
    
* Garantir a integridade dos dados através de transações atômicas.
* Sistema de backup e recuperação para prevenir perda de dados.

## Fluxo / Diagramas:

![Atividade_5](https://github.com/aannddrree/ProjAndreVeiculos/assets/8753843/ab2b1614-a014-4eb6-8dda-5d532e236a20)
