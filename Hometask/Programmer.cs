using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hometask
{
    public class Programmer : Employee
    {
        public Programmer(string firstName, string lastName, int age)
            :base(firstName, lastName, age)
        {

        }

        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
}
