using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card 
{
    public int health, damage, manaCost, ownerID;
    //public Sprite illustration;
    public Card()
    {

    }
     
    public Card(Card card)
    {
        health = card.health;
        damage = card.damage;
        manaCost = card.manaCost;
        ownerID = card.ownerID;
    }
}
