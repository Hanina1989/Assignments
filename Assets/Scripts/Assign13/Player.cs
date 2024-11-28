using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    namespace Assign13
    {
    public class Player
    {
    
    public string playerName;
    public int health;
    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;  
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(playerName + " healed by " + amount + " points. New health: " + health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;  
            Debug.Log(playerName + " fully restored with" + health);
        }
        else
        {
            Debug.Log("Khsraan" + health);
        }
    }

     public static void ShowPlayerCount()
    {
        Debug.Log("Total number of players: " + playerCount);
    }

   }
   }