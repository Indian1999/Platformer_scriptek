using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript
{
    ArcaneMage gandalf = new ArcaneMage("Gandalf", 1000, 10, 700, 30, 100, 2000);
    DarkMage saruman = new DarkMage("Saruman", 500, 23, 800, 10, 200, 5000);
    Archer legolas = new Archer("Legolas", 200, 10, 10, 300, 10, 200);
}














class Animal
{
    public int lábak_száma = 4;
    public string táplálék = "";
    public int súly = 15;
    public int méret = 54;

    public Animal(int lábak, string kaja, int tömeg)
    {
        lábak_száma = lábak;
        táplálék = kaja;
        súly = tömeg;
    }

    public void setMéret(int value)
    {
        méret = value;
    }
}

class Dog : Animal
{
    public int hangerõ = 10;
    public Dog(int lábak, string kaja, int tömeg, int hang) : base(lábak, kaja, tömeg) 
    {
        hangerõ = hang;
    }
}
class Turtle : Animal
{
    public int páncél_ereje = 10;
    public Turtle(int lábak, string kaja, int tömeg, int páncél) : base(lábak, kaja, tömeg)
    {
        páncél_ereje = páncél;
    }
}

class Prgram
{

    Animal buksi = new Animal(4, "borjú", 9);
    Dog zsömle = new Dog(4, "marha", 15, 20);
    Turtle teki = new Turtle(4, "saláta", 1, 230);

}






















