using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemeperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temeperature...
        else if (coffeeTemperature < coldLperature)
        {
            //
        }
    }
        
    }
}
