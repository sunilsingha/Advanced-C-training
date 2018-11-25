using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo.Advanced_Topics.Delegates
{
    delegate int NumberChanger(int n);
    public class DelegateDemo
    {
        static int num = 10;

        static int AddNum(int n)
        {
            num += n;
            return num;
        }

        static int MulNum(int n)
        {
            num *= n;
            return num;
        }

        static int getNum()
        {
            return num;
        }

        public static void Test()
        {
            //create delegate instances;
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MulNum);

            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);

            Console.WriteLine($"value of num: {getNum()}");
            Console.ReadKey();
        }
    }
}
