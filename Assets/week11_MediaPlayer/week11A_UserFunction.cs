using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week11A_UserFunction : MonoBehaviour
{
    int[] myArray = new int[3];
    public List<GameObject> MyGameObjects = new List<GameObject>();
    int globalVar = 0;

    void Start()
    {
        //SayHello();
        //int result = MyFunction();
        //print(result);


        //print(Plus() * 0.1);

        //int someVar = Plus();
        //print(someVar);

        //print(Plus(123, 456));

        //myArray = new int[3];
        myArray[0] = 12;
        myArray[1] = 34;
        myArray[2] = 24;
        for(int i = 0; i < myArray.Length; i++)
        {
            print(myArray[i]);
        }
        //MyGameObjects = new List<GameObject>();
        //print(MyGameObjects.Count);
        print(MyGameObjects.Count);
        //print(MyGameObjects[0].name);
        //print(MyGameObjects[1].name);
        //print(MyGameObjects[2].name);
        for (int i = 0; i < MyGameObjects.Count; i++)
        {
            print(MyGameObjects[i].name);
        }

        SayHello();
        SayHello("say hello");
        string s = "say hello";
        SayHello(s);
        string s1 = "say";
        string s2 = " hello";
        SayHello(s1 + s2);
    }

    void Update()
    {
        
        //print(result);
        //globalVar++;
        //print(globalVar);
    }

    void SayHello()
    {
        print("say hello");
    }

    void SayHello(string s)
    {
        print(s);
    }

    int MyFunction()
    {
        int i = 10;
        return i;
    }

    int Plus()
    {
        int a = 10;
        int b = 100;
        int c = a + b;
        return c;
    }

    int Plus(int a, int b)
    {
        int c = a + b;
        return c;
    }
}
