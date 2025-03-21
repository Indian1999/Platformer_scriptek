using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneMage : Mage
{

    public ArcaneMage(string class_name, int health, int strength, int intellect, int agility, int damage, int mana)
        : base(class_name, health, strength, intellect, agility, damage, mana)
    {

    }

    public void castDuality(BaseClass target)
    {
        target.Health -= Damage / 2;
        Health += Damage / 2;
    }
}
