using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyCard
{
    public abstract class Card
    {

        public string Number { get; set; }
        public string CardName { get; set; }
        public decimal Money { get; set; }
        public virtual decimal Bonus { get; set; }

        public Card(string number,string cardname, decimal money)
        {
            Number = number;
            CardName = cardname;
            Money = money;

        }

        public abstract bool Pay(decimal cost);

        public decimal Add(decimal amount)
        {
            Money += amount;
            return Money;
        }

        public decimal AddWithBonus(decimal amount)
        {
            Money += amount + Bonus;
            return Money;
        }


        public class Uzcard : Card
        {
            public Uzcard(string number, string cardname, decimal money) :  base(number, cardname, money)
            {
                Bonus = 5;
            }


        }

    }
}
