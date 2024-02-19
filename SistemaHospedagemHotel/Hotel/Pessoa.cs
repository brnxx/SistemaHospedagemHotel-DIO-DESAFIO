using System.Security.Cryptography.X509Certificates;

namespace SistemaHospedagemHotel.Hotel
{
    internal class Pessoa
    {

        private string _nome;
        private string _sobrenome;

        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome.ToUpper();

            set
            {

                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            }
        }

        public void ApresentarPessoa()
        {
            Console.WriteLine($"Nome e sobrenome: {Nome} {Sobrenome}");
        }

    }
}

