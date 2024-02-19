using SistemaHospedagemHotel.Hotel;

class Program
{
    static void Main(string[] args)
    {



                // Hospedes
                List<Pessoa> hospedes = new List<Pessoa>();

                Pessoa p1 = new Pessoa(nome: "Bruno", sobrenome: "Monteiro");
                Pessoa p2 = new Pessoa(nome: "Júlia", sobrenome: "Sobral");

                hospedes.Add(p1);
                hospedes.Add(p2);

                // Suite

                Suite s1 = new Suite("Master", 2, 152);

                // Reserva
                Reserva r1 = new Reserva(diasReservados: 10);
                r1.CadastrarSuite(s1);
                r1.CadastrarHospedes(hospedes);


                Console.WriteLine($"Hospedes: {r1.ObterQuantidadeHospedes()}");
                Console.WriteLine($"VALOR DA RESERVA: {r1.CalcularValorDiaria()}");
        
    }

}

