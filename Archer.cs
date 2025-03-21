using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : BaseClass
{
    private int ammo;
    public int Ammo { get { return ammo; } set { ammo = value; } }

    public Archer(string class_name, int health, int strength, int intellect, int agility, int damage, int ammo)
        : base(class_name, health, strength, intellect, agility, damage)
    {
        Ammo = ammo;
    }
}
