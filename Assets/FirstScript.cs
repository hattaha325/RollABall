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
        DateTime now = DateTime.Now; // ���̎��Ԃ��擾����
        Debug.Log(now); // ���̎��Ԃ��Q�[���ɕ\������
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
            Debug.Log("Cherry���܂܂�Ă���");
        }
        else
        {
            Debug.Log("Cherry���܂܂�Ă��Ȃ�");
        }
    }

}