using ProjetoHeranca.Animais;
namespace ProjetoHeranca{

    class Program{
        public static void Main(string[] args){
            Animal[] animais = new Animal[3];
            animais[0] = new Cachorro("Pitbull", 3, 15);
            animais[1] = new Hamster("padrão", 7, 1);
            animais[2] = new Gato("garfield", 9, 10);
            Pedido pedido = new Pedido("Víctor", "(73) 9 88*****8", animais);
            Console.WriteLine(pedido.CalcularValor());

        }

    }

}