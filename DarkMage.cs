using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMage : Mage
{
    public DarkMage(string class_name, int health, int strength, int intellect, int agility, int damage, int mana)
        : base(class_name, health, strength, intellect, agility, damage, mana)
    {

    }

    public void castArmageddonAttack(BaseClass target)
    {
        target.Health -= Damage;
    }
}
