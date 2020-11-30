using Project2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2.Abstraction
{
    public interface ICommandReader
    {
        public Command Read();
    }
}
