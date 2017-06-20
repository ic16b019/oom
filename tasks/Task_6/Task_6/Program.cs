using System;
using System.Collections.Generic;
using System.Windows;
using System.Reactive;
using System.Windows.Forms;



using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Klasse
    {
        public string Name { get; set; }
        public Klasse(string name)
        {
            Name = name;
        }

        static void Main(string[] args)
        {
            //pull
            var x = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var e = x.GetEnumerator();
            while (e.MoveNext())
                Console.WriteLine("Zahl aus Liste {0}", e.Current);


            //push
            //var W = new Form()
            //{ Text = "Task_6", Width = 800, Height = 600 };
            //W.MouseMove += (sender, eventArg) => WriteLine($"[MouseMove event] ({eventArgs.X},{eventArgs.Y})"); 

        }
    }
}
