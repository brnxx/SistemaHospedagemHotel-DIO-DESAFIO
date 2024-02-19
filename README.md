## Desafio de projeto by DIO - Trilha .NET - Explorando a linguagem C#
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

## Diagrama da DIO
![image](https://github.com/brnxx/SistemaHospedagemHotel-DIO-DESAFIO/assets/49076883/0a274e98-6233-4b4a-8135-66c86cac493b)


## Observação

Durante o desenvolvimento deste projeto, optei por não utilizar o repositório fornecido pela Digital Innovation One (DIO). 
Embora o repositório da DIO seja uma excelente referência, decidi desafiar a mim mesmo e tentar desenvolver o projeto de forma independente. 
Acredito que essa abordagem me proporcionou uma oportunidade valiosa para aprender e crescer como desenvolvedor, pois me permitiu enfrentar e superar obstáculos por conta própria. 
Embora tenha sido um desafio, estou satisfeito com o resultado e acredito que essa experiência contribuiu significativamente para o meu desenvolvimento profissional.
