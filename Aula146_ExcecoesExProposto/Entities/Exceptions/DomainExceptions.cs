/* >>> CLASSE DOMAINEXCEPTIONS <<< */
using System;

namespace Aula146_ExcecoesExProposto.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
