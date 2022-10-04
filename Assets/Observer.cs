using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    public void UpdateData(float temperature, float humidity, float pressure)
    {
        
    }
}
