using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player 
{

    public int health, mana;
    public int ID;
    public bool myTurn;
    public Player(int health,int mana, int ID)
    {
        this.health = health;
        this.ID = ID;
        this.mana = mana;
    }

   
}
