using ControlWork.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork.Shared.Utils
{
    public static class CustomerIdGenerate
    {

        public static string GenerateUniqueId(string firstName, string lastName)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                sb.Append(firstName[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                sb.Append(lastName[i]);
            }
            return sb.ToString().ToUpper();
        }
    }
}
