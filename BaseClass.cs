using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    static int classCount = 0;
    private string class_name;
    private int health;
    private int strength;
    private int intellect;
    private int agility;
    private int damage;
    public string Name { get { return class_name; } set { class_name = value; } }
    public int Health { get { return health; } set { health = value; } }
    public int Strength { get { return strength; } set {  strength = value; } }
    public int Intellect { get { return intellect; } set {  intellect = value; } }
    public int Agility { get {  return agility; } set {  agility = value; } }
    public int Damage { get { return damage; } set { damage = value; } }

    public BaseClass()
    {
        classCount += 1;
        Name = "undefined";
        Health = 100;
        Strength = 10;
        Intellect = 10;
        Agility = 10;
        Damage = 5;
    }

    public BaseClass(string class_name, int health, int strength, int intellect, int agility, int damage)
    {
        classCount += 1;
        Health = health;
        Strength = strength;
        Intellect = intellect;
        Agility = agility;
        Damage = damage;
        Name = class_name;
    }
}
