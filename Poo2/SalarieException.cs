using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo3
{
    [Serializable()]
    public class SalarieException : ApplicationException
    {
        private string _IdMessage = string.Empty;

        public string IdMessage { get => _IdMessage; set => _IdMessage = value; }

        
    }
}
