using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{
   
    void Start()
    {
      Random.Range(1,21);
      Debug.Log(Random.Range(1,21)); 

      int counter =1;
      while(counter<20)
      {
       int randomNumber = Random.Range(1,21);
       
       Debug.Log(Random.Range(1,21));
       counter++;

       if (randomNumber==5)
       break;

      if (randomNumber==15)continue;

      }
    }

   
}
