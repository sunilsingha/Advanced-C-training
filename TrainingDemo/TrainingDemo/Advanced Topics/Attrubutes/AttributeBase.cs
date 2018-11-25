#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo.Advanced_Topics.Attrubutes
{
    /// <summary>
    /// This class is used a 
    /// base to implement conditional and custom attrivute
    /// An attribute is a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes, methods, structures, enumerators, assemblies etc. in your program. 
    /// You can add declarative information to a program by using an attribute. A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.
    /// Attributes are used for adding metadata, such as compiler instruction and other information such as comments, description, methods and classes to a program.
    /// The.Net Framework provides two types of attributes: the pre-defined attributes and custom built attributes.
    /// </summary>
    public class AttributeBase
    {
        [Conditional("DEBUG")]

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class Test
    {
        static void function1()
        {
            AttributeBase.Message("In Function 1.");
            function2();
        }

        static void function2()
        {
            AttributeBase.Message("In Function 2.");
        }

        public static void StartProcess()
        {
            AttributeBase.Message("In Main function.");
            function1();
            Console.ReadKey();
        }
    }
}
