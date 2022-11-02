using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class operations
    {
        customerdbEntities userContext = null;
        public operations()
        {
            userContext = new customerdbEntities();
        }
        public bool ValidateUser(string email, string pass)
        {
            bool ans = false;
            var found1 = userContext.userinfoes.ToList();
            var found = found1.Find(x => x.email == email);
            if (found != null)
            {
                if (found.passward== pass)
                {
                    ans = true;
                }
            }
            return ans;
        }
        public void insert(custloginfo c)
        {
            userContext.custloginfoes.Add(c);
            userContext.SaveChanges();
        }
    }
}
