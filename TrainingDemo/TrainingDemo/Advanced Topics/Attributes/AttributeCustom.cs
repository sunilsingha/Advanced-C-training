using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo.Advanced_Topics.Attributes
{
    /// <summary>
    /// A custom attribute BugFix to be assigned to a class and its members
    /// </summary>
    [AttributeUsage(AttributeTargets.Class
        |AttributeTargets.Constructor
        |AttributeTargets.Field
        |AttributeTargets.Method
        |AttributeTargets.Property,
        AllowMultiple =true)]
    public class AttributeCustomBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        private string message;

        public AttributeCustomBugInfo(int bg, string dev, string lstReview)
        {
            bugNo = bg;
            developer = dev;
            lastReview = lstReview;
        }

        public int BugNo
        {
            get { return bugNo; }            
        }        

        public string Developer
        {
            get { return developer; }
        }        

        public string LastReview
        {
            get { return lastReview; }
        }
        
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        
    }

    [AttributeCustomBugInfo(45,"Tom", "12/12/12", Message ="Return Type mismatch")]
    public class Rectange
    {
        //member variables
        protected double length;
        protected double width;

        public Rectange(double l, double w)
        {
            this.length = l;
            this.width = w;
        }

        [AttributeCustomBugInfo(55,"Tom", "13/13/13",Message ="Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [AttributeCustomBugInfo(56,"Tom","14/14/14",Message ="some return type")]
        public void Display()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.ReadKey();
        }
    }

    public class ExecuteRectangle {
        public static void RunRectangle()
        {
            Rectange rectange = new Rectange(13, 13);
            rectange.Display();

            Type type = typeof(Rectange);

            //Iterating through Rectangle class attributes 
            foreach (object attributes in type.GetCustomAttributes(false))
            {
                //casting the object to AttributesCustomBugInfo class
                AttributeCustomBugInfo attributeCustomBugInfo = (AttributeCustomBugInfo)attributes;
                if (null != attributeCustomBugInfo)
                {
                    Console.WriteLine($"Bug no: {attributeCustomBugInfo.BugNo}");
                    Console.WriteLine($"Last Review: {attributeCustomBugInfo.LastReview}");
                    Console.WriteLine($"Developer: {attributeCustomBugInfo.Developer}");
                    Console.WriteLine($"Remarks: {attributeCustomBugInfo.Message}");
                }
            }

            //Iterating through the metod attributes
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (System.Attribute a in m.GetCustomAttributes(true))
                {
                    try
                    {
                        AttributeCustomBugInfo attributeCustomBugInfo = (AttributeCustomBugInfo)a;
                        if (null != attributeCustomBugInfo)
                        {
                            Console.WriteLine($"Bug no: {attributeCustomBugInfo.BugNo}");
                            Console.WriteLine($"Last Review: {attributeCustomBugInfo.LastReview}");
                            Console.WriteLine($"Developer: {attributeCustomBugInfo.Developer}");
                            Console.WriteLine($"Remarks: {attributeCustomBugInfo.Message}");
                        }
                    }
                    catch
                    { }
                }
            }
            Console.ReadKey();
        }
    }

}
