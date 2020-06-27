using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_CNC
{
    public class Element
    {
        public string Command { get; set; }
        public decimal Number { get; set; }


        public Element(string command, decimal number)
        {
            Command = command;
            Number = number;
        }
    }
}
