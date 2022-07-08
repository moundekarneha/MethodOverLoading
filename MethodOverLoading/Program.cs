using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class child :Program
    {
        public void show()
        {

            Console.WriteLine("I am child show");
        }
        //method overriding - child class method override
        public override void parendtmethod()
        {
            Console.WriteLine("child override method");
        }

        //new - is used in method hiding
        public new void methodHide()
        {
            Console.WriteLine("child method hide");
        }

        //calling parents methods - using parent class obj
        public void parentMethodByObj()
        {
            Program p = new Program();
            p.Test1();
        }

        //calling parents methods - using base keyword
        public void parentMethodByBase()
        {
            base.Test1();
        }

    }
    internal class Program
    {

        //method hiding 
        public void methodHide()
        {
            Console.WriteLine("parent  method hide");
        }
        //method overriding - parent class method virtual
        public virtual void parendtmethod()
        {
            Console.WriteLine("parent override method");
        }

        public void show(string s = "parent")
        {

            Console.WriteLine("I am "+s+ " show");
        }
        //method overloading - polymorphism 
        public void Test1()
        {
            Console.WriteLine("Test1");
        }
        public void Test1(int i)
        {
            Console.WriteLine("Test1 - with int i value = "+i);
        }
        public void Test1(string s)
        {
            Console.WriteLine("Test1 - with string s value = "+s);
        }
        public void Test1(int i, string s)
        {
            Console.WriteLine("Test1 - with int i value = "+i+" and string s value = "+s);
        }

        public void Test1(string s, int i)
        {
            Console.WriteLine("Test1 - with string s value = " + s + " and int i value = " + i);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           
            p.Test1();
            p.Test1(10);
            p.Test1("This is neha");
            p.Test1("this is ", 1);
            p.Test1(12,"wow");
            p.show();

            child c = new child();
            Program pobj = c;
            pobj.parendtmethod();
            c.show(); //child show
            c.show("hello"); //parent show
            c.parendtmethod();
            c.methodHide();
            c.parentMethodByObj();
            c.parentMethodByBase();

            Console.ReadLine();
        }
    }
}
