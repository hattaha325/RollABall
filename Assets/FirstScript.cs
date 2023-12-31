using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayExample : MonoBehaviour
{
    private void Awake()
    {
        ShowTime();
    }


    void ShowTime()
    {
        DateTime now = DateTime.Now; // 今の時間を取得する
        Debug.Log(now); // 今の時間をゲームに表示する
    }


    private void Start()
    {
        // �@
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
        // �A
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
        colors.Remove("Green");
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }
        // �B
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig" };
        if (fruits.Contains("Cherry"))
        {
            Debug.Log("Cherryが含まれている");
        }
        else
        {
            Debug.Log("Cherryが含まれていない");
        }
    }

}