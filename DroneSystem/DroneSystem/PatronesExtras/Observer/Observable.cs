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
        public abstract void Agregar(IObserver observer);
        public abstract void Remover(IObserver observer);
        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Actualizar();
            }
        }
    }
}
