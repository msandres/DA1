using DroneSystem.IPersistenciaPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneSystem.PatronesExtras.Observer
{
    public abstract class Observable: OPersistente
    {
        public IList<IObserver> Observers;
        public abstract void AgregarOb(IObserver observer);
        public abstract void RemoverOb(IObserver observer);
        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Actualizar();
            }
        }
    }
}
