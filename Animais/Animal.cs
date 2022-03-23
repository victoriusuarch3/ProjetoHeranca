namespace ProjetoHeranca.Animais
{
    public class Animal
    {
        public string Raca { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public Animal(string raca, int idade, double peso)
        {
          Raca = raca;
          Idade = idade;
          Peso = peso;
        }

        public virtual int TomarBanho()
        {
            return 20;
        }
        public virtual int Comer()
        {
            return 40;
        }

    }
}