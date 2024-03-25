using ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour, IObserver
{
    public Youtuber youtuber;
    public string userName;

    void OnEnable()
    {
        youtuber.RegisterObserver(this);
    }
    
    void OnDisable() 
    {
        youtuber.RemoveObserver(this);
    }

    public void OnUpload(string channel)
    {
        Debug.Log("[" + userName + "]님 " + channel + "에서 새 영상을 업로드했습니다");
    }
}
