using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForecastDisplay : MonoBehaviour,IObserver,IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private float _pressure;


    public void UpdateData(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        DisplayData();
    }

    public void DisplayData()
    {
        Debug.Log("Temperature is: "+_temperature);
        Debug.Log("Humidity is: "+_humidity);
        Debug.Log("Pressure is: "+_pressure);
    }
}
