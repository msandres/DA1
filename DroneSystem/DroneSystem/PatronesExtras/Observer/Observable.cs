using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.PatronesExtras.Observer
{
    public abstract class Observable
    {
        public IList<IObserver> Observers;
        public abstract void Attach(IObserver observer);
        public abstract void Detach(IObserver observer);
        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Actualizar();
            }
        }
    }
}
