using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour
{
    int[] array = { 8, 2, 6, 9, 3, 4 };
    List<int> listArr = new List<int> { 8, 2, 6, 9, 3, 4 };

    void Start()
    {
        List<int> result = InsertionSort(listArr);

        for (int i = 0; i < result.Count; i++) {
            Debug.Log("Sort Result: " + result[i]);
        }

    }

    int[] BuubleSort(int[] array) {
        int n = array.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Debug.Log(array[j] + " " + array[j + 1]);

                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        Debug.Log(array);
        return array;
     }

    List<int> InsertionSort(List<int> list) {
        int n = list.Count;

        for (int i = 1; i < n; i++)
        {
            int key = list[i];
            int j = i - 1;

            while(j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j = j - 1;
            }
            list[j + 1] = key;
        }

        return list;
      }
    // Update is called once per frame
    void Update()
    {
        
    }
}
