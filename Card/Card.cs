using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public abstract class Card
    {
        public string Number { get; set; }
        public string HolderName { get; set; }
        public decimal Money { get; set; }
        public virtual decimal Bonus { get; set; }

        public Card(string number, string holderName, decimal money)
        {
            Number = number;
            HolderName = holderName;
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
    }

    public class Uzcard : Card
    {
        public Uzcard(string number, string holderName, decimal money) : base(number, holderName, money)
        {
            Bonus = 5;
        }

        public override decimal Bonus { get; set; }

        public override bool Pay(decimal cost)
        {
            if ((Money - cost) < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }
    }

    public class Humo : Card
    {
        public Humo(string number, string holderName, decimal money) : base(number, holderName, money) { }

        public override bool Pay(decimal cost)
        {
            Money -= cost;
            return true;
        }

        public bool PayWireless(decimal cost)
        {
            if (cost > 50000 || (Money - cost) < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }
    }

}
