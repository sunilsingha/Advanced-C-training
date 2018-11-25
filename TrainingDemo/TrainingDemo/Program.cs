using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo
{
    class Program
    {     

        static void Main(string[] args)
        {
            //Attribute Test
            //AttributeDemo();

            //Delegate Test
            DelegateDemo();
        }


        static void AttributeDemo()
        {
            //Don't know what this did, but need to understand
            Advanced_Topics.Attributes.Test.StartProcess();

            //If you uncomment below method, it will show compile errors, as the method is defined Obsolete
            Advanced_Topics.Attributes.AttributeObsolete.OldMethod();

            //Custom Attribute test
            Advanced_Topics.Attributes.ExecuteRectangle.RunRectangle();
        }

        static void DelegateDemo()
        {
            Advanced_Topics.Delegates.DelegateDemo.Test();
        }
    }
}
