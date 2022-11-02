using Dal;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest
{
    [TestFixture]
    public class Dalclass_Test
    {
       operations op = new operations();
        
        [TestCase("bhuvana@gmail.com", "bhuvana@2003", ExpectedResult = true)]
        [TestCase("abc@gmail.com", "abc@2003", ExpectedResult = true)]
        [TestCase("xyz@gmail.com", "xyz@2003", ExpectedResult = true)]
        public bool Validate(string email, string password)
        {
            return op.ValidateUser(email, password);
        }
        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = true)]
        public void InsertCkeck(int id)
        {
           custloginfo c = new custloginfo();
            c.userid = id;
             op.insert(c);
        }
    }
}
