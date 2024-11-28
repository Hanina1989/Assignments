using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assign10
{
public class Multitable : MonoBehaviour
{

public int Multiply(int num1 , int num2)
    {
        return num1 * num2;
    }


    // Start is called before the first frame update
    void Start()
    {
       
     for (int i = 1; i <= 10; i++)
        {
            int result = (5* i);

           
            Debug.Log("5 x " + i + " = " + result);
        }   

    }

}
}