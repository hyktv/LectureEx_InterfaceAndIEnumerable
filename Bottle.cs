using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_InterfaceAndIEnumerable
{
    public class Bottle : IOpen, IClose
    {
        public double MinRotation { get; } = 0;
        public double MaxRotation { get; } = 120;

        public void Open()
        {
            Console.WriteLine("Bottle is opening to {0} degrees", MaxRotation);
        }

        public void Close()
        {
            Console.WriteLine("Bottle is closing");
        }
    }
}
