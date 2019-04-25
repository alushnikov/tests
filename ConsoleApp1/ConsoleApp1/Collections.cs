using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Collections
    {            
        public List<int> TestMethodPublicBad1(Dictionary<string, string> test)
        {
            return null;
        }

        public List<int> TestMethodPublicBad2(Dictionary<string, string> test, ReadOnlyCollection<int> test2, IReadOnlyList<int> test3)
        {
            return null;
        }

        public List<int> TestMethodPublicBad3(
            Dictionary<string, string> test, 
            ReadOnlyCollection<int> test2, 
            IReadOnlyList<int> test3)
        {
            return null;
        }

        public IList<int> TestMethodPublicOk(IDictionary<string, string> test)
        {
            return new List<int>();
        }

        protected List<int> TestMethodProtectedBad(Dictionary<string, string> test)
        {
            return null;
        }

        protected IList<int> TestMethodProtectedOk(IDictionary<string, string> test)
        {
            return new List<int>();
        }




        public void TestAccessingElement()
        {
            string[] x = new[] {"", "", ""};
            Console.WriteLine(x[3]);
            Console.WriteLine($"Value {x[3]}");
            SomeRandomClass.Call(x[4]);
        }



        public void TestEnumerableCount()
        {
            var x = new List<int>();
            if (x.Count() > 0)
            {

            }
        }



        public void TestForLoop()
        {
            var list = new List<int>();
            var isItemValid = false;

            foreach (var item in list)
            {
                isItemValid = ValidateItem(item);
            }
        }



        public List<int> TestExternalSettableCollection { get; set; }
        public List<int> TestExternalSettableCollection1 { get; private set; }
        public List<int> TestExternalSettableCollection2 { get; }



        public void ToListForLoop()
        {
            var list = new List<int>();
            // avoid
            foreach (var item in list.ToArray())
            {
                DoSomething();
            }


            // avoid
            foreach (var item in list.ToList())
            {
                DoSomething();
            }
        }

    }
}
