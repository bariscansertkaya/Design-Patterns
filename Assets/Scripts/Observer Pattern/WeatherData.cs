using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WeatherData : MonoBehaviour,ISubject
{
    private float Temperature { get; set; }
    private float Humidity { get; set; }
    private float Pressure { get; set; }

    private ArrayList _observers = new ArrayList();

    private void Awake()
    {
        AddObserver(gameObject.AddComponent<ForecastDisplay>());
    }


    private void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    
    private void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.UpdateData(Temperature,Humidity,Pressure);
        }
    }

    public void GetRandomData()
    {
        Temperature = Random.Range(1, 40);
        Humidity = Random.Range(1, 40);
        Pressure = Random.Range(1, 40);
        NotifyObservers();
    }




}
