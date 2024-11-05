using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public interface IObserver
    {
        void OnUpload(string channel);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}

namespace StatePattern
{
    public interface IState
    {
        void Study();
    }
}

namespace FlyweightPattern
{
    public interface IMonster
    {
        void Attack(int x, int y);
    }
}