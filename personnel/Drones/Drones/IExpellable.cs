using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public enum EvacuationState
    {
        Free,   //No limits applied
        Evacuating, //Limits known, moving out of the zone
        Evacuated   //Limits known, out of the zone.
    }
    public interface IExpellable
    {
        public bool Evacuate(Rectangle zone);
        public void FreeFlight();
        public EvacuationState GetEvacuationState();
    }
}
