using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exersice2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
  string[]words={"cat","dog","car","pizza","hat","fish","tree","monkey","ball","bird"};
    //   Debug.Log(words[0]);
    //   Debug.Log(words.Length);
    //  Debug.Log(words[4]+ " " +words[0]+" " +words[5]+" " +words[3]+" " +words[1]+" "  +words[8]+" " +words[2]);
    // }
        string sentence = "";

        int counter = 0;


        while (counter < 7)
        {
           
            int randomSentences = Random.Range(0, words.Length);
            sentence += words[randomSentences] + " ";

            counter++;
        }

        Debug.Log(sentence);
        
    }
}
