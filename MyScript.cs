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
    public int l�bak_sz�ma = 4;
    public string t�pl�l�k = "";
    public int s�ly = 15;
    public int m�ret = 54;

    public Animal(int l�bak, string kaja, int t�meg)
    {
        l�bak_sz�ma = l�bak;
        t�pl�l�k = kaja;
        s�ly = t�meg;
    }

    public void setM�ret(int value)
    {
        m�ret = value;
    }
}

class Dog : Animal
{
    public int hanger� = 10;
    public Dog(int l�bak, string kaja, int t�meg, int hang) : base(l�bak, kaja, t�meg) 
    {
        hanger� = hang;
    }
}
class Turtle : Animal
{
    public int p�nc�l_ereje = 10;
    public Turtle(int l�bak, string kaja, int t�meg, int p�nc�l) : base(l�bak, kaja, t�meg)
    {
        p�nc�l_ereje = p�nc�l;
    }
}

class Prgram
{

    Animal buksi = new Animal(4, "borj�", 9);
    Dog zs�mle = new Dog(4, "marha", 15, 20);
    Turtle teki = new Turtle(4, "sal�ta", 1, 230);

}






















