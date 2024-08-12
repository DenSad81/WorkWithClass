using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
    {
        static void Main(string[] args)
        {
            Hero mario = new Hero('$');
            Hero pacman = new Hero('@');
            Hero sonic = new Hero('*', 150);
            Hero enemy = new Hero('#', 50, 30);

            mario.ShowDataClass();
            pacman.ShowDataClass();
            sonic.ShowDataClass();
            enemy.ShowDataClass();
        }
    }

    class Hero
    {
        private char _sign;
        private int _health;
        private int _damage;

        public Hero(char sign, int health = 100, int damage = 10)
        {
            _sign = sign;
            _health = health;
            _damage = damage;
        }

        public void ShowDataClass()
        {
            Console.WriteLine(_sign + " have life: " + _health);
            Console.WriteLine(_sign + " have damage: " + _damage);
            Console.WriteLine();
        }
    }