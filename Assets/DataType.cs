using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    int integerNumber;

    private void Start()
    {














        Debug.Log("C:Users\\Username\\Documents");



        int number = 23; // 0����51�܂ł̔C�ӂ̐�

        string[] suits = { "�n�[�g", "�_�C��", "�N���u", "�X�y�[�h" };
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        string suit = suits[number / 13];
        string rank = ranks[number % 13];

        Debug.Log($"{suit}��{rank}");


        int x = 5;
        int y = 0;
        if (x > y)
        {
            Debug.Log("x��y���傫��");
        }

        string name1 = "john";
        string name2 = "john";
        if (name1 == name2)
        {
            Debug.Log("��̖��O�͓����ł�");
        }

        int age = 0;
        if (age >= 20)
        {
            Debug.Log("���l�ł�");
        }
        else
        {
            Debug.Log("�����N�ł�");
        }



        int a = 10;
        int b = 4;

        if (a >= 10 && a != 15 && b <= 5)
        {
            // �����𖞂�������
        }


        bool isRaining = true;
        bool hasUmbrella = true;
        // �J���~���Ă��Ȃ��A�܂��͉J���~���Ă邪�P�������Ă���ꍇ
        if (!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("�Ƃ��o��B");
        }




        int n = 10; // �C�ӂ�n

        while (n > 0)
        {
            if (n % 2 == 0)  // n �������̏ꍇ
            {
                n /= 2;
            }
            else  // n ����̏ꍇ
            {
                n -= 1;
            }

            Debug.Log(n);// 5,4,2,1,0
        }




        int[] numbers = {5, 8, 12, 7, 3};
        Debug.Log(numbers[3]);


        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
        Debug.Log(fruits[3]);

        //int[] scores = { 78, 85, 90, 72, 88, 60 };
        //int sum = 0;
        //foreach (int score in scores)
        //{
        //    sum += score;
        //}
        //Debug.Log(sum);

        int[] scores = { 50, 80, 60, 80, 90 };
        
        foreach (var score in scores)
        {
            Debug.Log(score);// 50,80,60,80,90
        }



        float number1 = 12.34f;
        int number2;
        // �ȉ��̍s�Ɍ^�L���X�g���s���Anumber1��int�^�ɃL���X�g���āAnumber2�ɑ�����Ă��������B
        number2 = (int)number1;
        Debug.Log(number2); // 12


    }

    private int distance = 10;

    private void Update()
    {
        do
        {
            distance -= 1;
            Debug.Log(distance);

            if (distance == 0)
            {
                Debug.Log("�ړI�n�ɓ������܂���!");
                gameObject.SetActive(false);
            }

        } while (distance > 0);
    }



}

public class Person
{
    private string name;

    public string GetName
    {
        get { return name; }
    }

    public string SetName
    {
        set
        {
            // !string.IsNullOrEmpty(value)�ł��ł�
            if (value == string.Empty || value != null)
            {
                name = value;
            }
        }
    }
}


public class Rectangle
{
    private float width;
    private float height;
    public float SetWidth
    {
        set { width = value; }
    }

    public float SetHeight
    {
        set { height = value; }
    }

    public float GetArea
    {
        get
        {
            return width * height;
        }
    }
}





