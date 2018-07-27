using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class PlatinumCreditCard: CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType => _cardType;
        public override int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
        public override int AnnualCharge { get => _annualCharge; set => _annualCharge = value; }

    }
}
