using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : IDispatchable
    {
        public List<Box> AllBoxes { get; set;  }

        public Dispatch()
        {
            AllBoxes = new List<Box>();
        }

        public void AddBox(Box box)
        {
            AllBoxes.Add(box);

            Console.WriteLine("Une box à été ajoutée ! " + box.BoxNumber.ToString());
        }

        public void RemoveBox(Box box)
        {
            AllBoxes.Remove(box);
        }
    }
}
