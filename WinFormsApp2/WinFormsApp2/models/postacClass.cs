using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.models
{
    public class Postac
    {
        public string Imie { get; set; }
        public int Gold { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Postac(string imie, int gold, int hp, int attack, int defense)
        {
            Imie = imie;
            Gold = gold;
            HP = hp;
            Attack = attack;
            Defense = defense;
        }

        public void PokazInformacje()
        {
            Console.WriteLine("Imię: " + Imie);
            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("Defense: " + Defense);
        }
    }
}
