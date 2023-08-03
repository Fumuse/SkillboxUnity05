using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge5_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (byte i = 1; i <= 5; ++i)
        {
            Debug.Log(i);
        }

        Debug.Log("_________________");

        for (byte i = 7; i >= 2; --i)
        {
            Debug.Log(i);
        }

        Debug.Log("_________________");

        int number = 12;
        bool isSimple = true;
        for (byte i = 2; i < number; ++i)
        {
            if (number % i != 0) continue;
            isSimple = false;
            break;
        }
        Debug.Log(isSimple ? $"{number} is simple" : $"{number} is not simple");
    }
}
