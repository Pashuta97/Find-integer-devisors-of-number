using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Find_integer_devisors_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var _number = Int64.Parse(Console.ReadLine());
            var _integerDevisors = new List<Int64>();
            for (int i = 1; i <= Math.Sqrt(_number);)
            {
                if(_number % i == 0)
                {
                    if (!_integerDevisors.Contains(i)) _integerDevisors.Add(i);
                    if (!_integerDevisors.Contains(_number / i)) _integerDevisors.Add(_number / i);
                }
                i++;
            }

            _integerDevisors.Sort();

            foreach(var number in _integerDevisors)
            {
                Console.Write(number.ToString() + ", ");
            }
            
            Console.ReadKey();
        }
    }
}
