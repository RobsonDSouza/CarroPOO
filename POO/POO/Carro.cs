
using System;

namespace POO
{
    public class Carro
    {
        //PascalCase: Nomes de classes, métodos e propriedades
        //camelCase: Nomes de variáveis privadas
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public int CapacidadeDoTanque { get; set; }
        public double PercentualDeCombustivel { get; set; }
        public bool Ligado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }

        private Pneu pneuDianteiroEsquerdo;
        public Pneu PneuDianteiroEsquerdo
        {
            get
            {
                return pneuDianteiroEsquerdo;
            }
            set
            {
                if (VelocidadeAtual > 0)
                    throw new Exception("Vai trocar o pneu com carro andando? Pare o carro!");

                if (Ligado)
                    throw new Exception("Seu trouxa, desligue o carro para trocar o pneu.");

                pneuDianteiroEsquerdo = value;
            }
        }
        private Pneu pneuDianteiroDireito;
        public Pneu PneuDianteiroDireito
        {
            get
            {
                return pneuDianteiroDireito;
            }
            set
            {
                if (Ligado)
                {
                    Console.WriteLine("Seu trouxa, desligue o carro.");
                    return;
                }

                pneuDianteiroDireito = value;
            }
        }
        private Pneu pneuTraseiroDireito;
        public Pneu PneuTraseiroDireito
        {
            get
            {
                return pneuTraseiroDireito;
            }
            set
            {
                if (Ligado)
                {
                    Console.WriteLine("Seu trouxa, desligue o carro.");
                    return;
                }

                pneuTraseiroDireito = value;
            }
        }
        private Pneu pneuTraseiroEsquerdo;
        public Pneu PneuTraseiroEsquerdo
        {
            get
            {
                return pneuTraseiroEsquerdo;
            }
            set
            {
                if (Ligado)
                {
                    Console.WriteLine("Seu trouxa, desligue o carro.");
                    return;
                }

                pneuTraseiroEsquerdo = value;
            }
        }
        public Pneu PneuDeEstepe
        {
            get;
            set;
        }
        public void Exibir()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Capacidade Do Tanque: : " + CapacidadeDoTanque);
            Console.WriteLine("Percentual De Combustível : " + PercentualDeCombustivel + "%");
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);

            Console.WriteLine("\nPneu Dianteiro Esquerdo:");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneu Dianteiro Direito:");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneu Traseiro Esquerdo:");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneu Traseiro Direito:");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneu Estepe:");
            PneuDeEstepe.Exibir();
        }
        public Carro(string _marca, string _modelo, string _cor, int _ano, string _placa, int _capacidadeDoTanque, double _percentualDeCombustivel, int _velocidadeMaxima)
        {
            Marca = _marca;
            Modelo = _modelo;
            Cor = _cor;
            Ano = _ano;
            Placa = _placa;
            PneuDianteiroEsquerdo = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            PneuDianteiroDireito = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            PneuTraseiroDireito = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            PneuTraseiroEsquerdo = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            PneuDeEstepe = new Pneu(13, "Michelin", 33, 38, 20, 70, 300, true);
            CapacidadeDoTanque = _capacidadeDoTanque;
            PercentualDeCombustivel = _percentualDeCombustivel;
            Ligado = false;
            VelocidadeAtual = 0;
            VelocidadeMaxima = _velocidadeMaxima;
        }
        public void Ligar()
        {
            if (PercentualDeCombustivel > 0)
            {
                Ligado = true;
                PercentualDeCombustivel = PercentualDeCombustivel - 1;
            }
        }
        public void Desligar()
        {
            Ligado = false;
            Parar();
        }
        public void Acelerar(int _impulso)
        {
            if (!Ligado)
            {
                Console.WriteLine("O carro está desligado!");
                return;
            }
            if (CarroEstaOperacional())
            {
                PercentualDeCombustivel -= 5;
                VelocidadeAtual += _impulso;
                PneuDianteiroDireito.Acelerar(_impulso);
                PneuDianteiroEsquerdo.Acelerar(_impulso);
                PneuTraseiroDireito.Acelerar(_impulso);
                PneuTraseiroEsquerdo.Acelerar(_impulso);
                CarroEstaOperacional();
            }
        }
        public void Frear(int _impulso)
        {
            VelocidadeAtual -= _impulso;
            PneuDianteiroDireito.Frear(_impulso);
            PneuDianteiroEsquerdo.Frear(_impulso);
            PneuTraseiroDireito.Frear(_impulso);
            PneuTraseiroEsquerdo.Frear(_impulso);


            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;
        }
        private void Parar()
        {
            Frear(VelocidadeAtual);
        }
        private bool CarroEstaOperacional()
        {
            if (PercentualDeCombustivel == 0)
            {
                Console.WriteLine("O carro está sem combustível!");
                Desligar();
                return false;
            }
            if (PneuDianteiroDireito.Estourado || PneuDianteiroDireito.Furado)
            {
                Console.WriteLine("Problema com o pneu dianteiro direito.");
                //TODO: Fazer um método para validar se o pneu está operacional
                Parar();
                return false;
            }
            if (PneuDianteiroEsquerdo.Estourado || PneuDianteiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o pneu dianteiro esquerdo.");
                //TODO: Fazer um método para validar se o pneu está operacional
                Parar();
                return false;
            }
            if (PneuTraseiroDireito.Estourado || PneuTraseiroDireito.Furado)
            {
                Console.WriteLine("Problema com o pneu traseiro direito.");
                //TODO: Fazer um método para validar se o pneu está operacional
                Parar();
                return false;
            }
            if (PneuTraseiroEsquerdo.Estourado || PneuTraseiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o pneu traseiro esquerdo.");
                //TODO: Fazer um método para validar se o pneu está operacional
                Parar();
                return false;
            }
            return true;
        }

    }

}
