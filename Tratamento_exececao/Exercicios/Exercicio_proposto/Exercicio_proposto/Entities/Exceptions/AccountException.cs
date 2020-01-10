using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_proposto.Entities.Exceptions {
    class AccountException : ApplicationException {
        public AccountException(string message) : base(message) {

        }
    }
}
