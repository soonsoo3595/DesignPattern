using ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Youtuber : MonoBehaviour, ISubject
{
    [SerializeField] Button uploadBtn;

    public string channel;

    private List<IObserver> observers = new List<IObserver>();

    void Start()
    {
        uploadBtn.onClick.AddListener(NotifyObservers);
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.OnUpload(channel);
        }
    }
}
