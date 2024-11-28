using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign13
{
public class GameManager : MonoBehaviour
{
    void Start()
    {
        
        Player player1 = new Player();
        Player player2 = new Player();

       
        player1.InitializePlayer("Batbot", 30);
        player2.InitializePlayer("Arnoob", 90);

       
        player1.Heal(20); 
        player2.Heal(true);

    
        Player.ShowPlayerCount();
    }
}
}