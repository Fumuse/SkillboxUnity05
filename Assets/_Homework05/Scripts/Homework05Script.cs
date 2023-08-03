using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;
using Unity.VisualScripting;

public class Homework05Script : MonoBehaviour
{
    private Random random = new();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SumEvenNumbers = " + SumEvenNumbers(7, 21));

        int[] array = GenerateNumbersArray(10);
        Debug.Log("GENERATED ARRAY = " + String.Join(", ", array));

        Debug.Log("SumEvenNumbersInArray = " + SumEvenNumbersInArray(array));

        Debug.Log("SearchNumberInArray, number 70, array key = " + SearchNumberInArray(array, 70));
        Debug.Log("SearchNumberInArray, number 32, array key = " + SearchNumberInArray(array, 32));
        Debug.Log("SearchNumberInArray, number 11, array key = " + SearchNumberInArray(array, 11));

        array = GenerateNumbersArray(10);
        Debug.Log("GENERATED ARRAY = " + String.Join(", ", array));
        Debug.Log("SORTED ARRAY = " + String.Join(", ", ArraySort(array)));
    }

    /// <summary>
    /// Сумма чётных чисел между двумя числами
    /// </summary>
    /// <param name="startNumber"></param>
    /// <param name="endNumber"></param>
    /// <returns></returns>
    protected int SumEvenNumbers (int startNumber, int endNumber)
    {
        int sum = 0;
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    /// <summary>
    /// Сумма чётных чисел между значениями числового массива
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    protected int SumEvenNumbersInArray(int[] array)
    {
        int sum = 0;
        foreach (int i in array)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    /// <summary>
    /// Поиск ключа в числовом массиве по его значению
    /// </summary>
    /// <param name="array"></param>
    /// <param name="number"></param>
    /// <returns></returns>
    protected int SearchNumberInArray (int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number) return i;
        }
        return -1;
    }

    /// <summary>
    /// Сортировка числового массива от меньшего к большему
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    protected int[] ArraySort (int[] array)
    {
        //Array.Sort(array); //Ы
        //return array;

        int tempKey = 0;
        int minNumber;

        for (int i = 0; i < array.Length - 1; i++)
        {
            minNumber = array[i];
            for (int n = i + 1; n < array.Length; n++)
            {
                if (minNumber > array[n])
                {
                    minNumber = array[n];
                    tempKey = n;
                }
            }

            array[tempKey] = array[i];
            array[i] = minNumber;
        }
        return array;
    }

    protected int[] GenerateNumbersArray(int lenght)
    {
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            array[i] = random.Next(1, 100 + 1);
        }
        return array;
    }
}
