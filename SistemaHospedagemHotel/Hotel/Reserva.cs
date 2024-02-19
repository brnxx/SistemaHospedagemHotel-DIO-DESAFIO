namespace SistemaHospedagemHotel.Hotel
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
;        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }

            else
            {
                throw new Exception("A capacidade máxima da suite foi atingida.");
            }
        }

        public int ObterQuantidadeHospedes()
        {

            return Hospedes.Count;

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados <= 10)
            {
                return Suite.ValorDiaria * DiasReservados * 0.90m;
            }
            else
            {
                return Suite.ValorDiaria * DiasReservados;
            }
        }

    }
}
