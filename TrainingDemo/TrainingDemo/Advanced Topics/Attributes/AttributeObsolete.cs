using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo.Advanced_Topics.Attributes
{
    /// <summary>
    /// The parameter message, is a string describing the reason why the item is obsolete and what to use instead.
    /// The parameter iserror, is a Boolean value.If its value is true, the compiler should treat the use of the item as an error.
    /// Default value is false (compiler generates a warning).
    /// </summary>
    public class AttributeObsolete
    {
        //Here we see the usage of obsolete
        [Obsolete("Don't use OldMethod, try NewMethod", false)]
        public static void OldMethod()
        {
            Console.WriteLine("This is a old Method.");
        }

 
        public static void NewMethod()
        {
            Console.WriteLine("This is a new method");
        }
    }
}
