using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : BaseClass
{
    private int mana;
    public int Mana { get { return mana; } set {  mana = value; } }

    public Mage(string class_name, int health, int strength,int intellect, int agility, int damage, int mana) 
        : base(class_name, health, strength, intellect, agility, damage)
    {
        Mana = mana;
    }
}
