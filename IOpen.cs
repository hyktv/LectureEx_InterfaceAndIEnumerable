using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_InterfaceAndIEnumerable
{
    public interface IOpen
    {
        double MinRotation { get; }
        double MaxRotation { get; }
        void Open();
    }
}
