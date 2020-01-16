using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public double Balance { get; set; }
        public double BalanceIncrement { get; set; }
        public double BalanceDecrement { get; set; }
    }
}
