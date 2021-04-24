using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBankWithdraw.Entities.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException (string message) : base(message)
        {

        }

    }
}
