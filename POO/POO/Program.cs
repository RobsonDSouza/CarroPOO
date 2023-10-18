namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu meuPneu = new Pneu(17, "Michelin", 33, 38, 25, 240, 500);
            Pneu troca;

            Carro meuCarro = new Carro("Honda", "Civic", "Preto", 2023, "CPR2250", 50, 100, 240);
    
            meuCarro.Ligar();
            meuCarro.Acelerar(5);
            meuCarro.Acelerar(15);
            meuCarro.Acelerar(6);
            meuCarro.Desligar();
            meuCarro.PneuDianteiroEsquerdo = meuPneu;
            meuCarro.Ligar();
            meuCarro.Acelerar(7);
            meuCarro.Acelerar(7);
            meuCarro.Frear(3);
            meuCarro.Acelerar(6);
            meuCarro.Frear(4);
            meuCarro.Desligar();
            troca = meuCarro.PneuDianteiroDireito;
            meuCarro.PneuDianteiroDireito = meuCarro.PneuDeEstepe;
            meuCarro.PneuDeEstepe = troca;
            meuCarro.Ligar();
            meuCarro.Acelerar(7);
            meuCarro.Acelerar(7);
            meuCarro.Frear(3);
            meuCarro.Acelerar(6);
            meuCarro.Frear(4);
            meuCarro.Desligar();

            troca = meuCarro.PneuTraseiroDireito;
            meuCarro.PneuTraseiroDireito = meuCarro.PneuDeEstepe;
            meuCarro.PneuDeEstepe = troca;
            meuCarro.Ligar();
            meuCarro.Acelerar(7);
            meuCarro.Acelerar(7);
            meuCarro.Frear(3);
            meuCarro.Acelerar(6);
            meuCarro.Frear(4);
            meuCarro.Frear(4);
            meuCarro.Acelerar(10);
            meuCarro.Exibir();

        }
    }
}