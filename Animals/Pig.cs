namespace Animals;

[My("pig from animal")]
public class Pig : Animal
{
    public Pig() : base() {}

    public Pig(string country, string HideFromOther, string name, string whatanimal) :
        base(country, HideFromOther, name, whatanimal) {}
    
    public void Deconstruct(out string country, out string HideFromOther, out string name, out string whatanimal)
    {
        country = Country;
        HideFromOther = HideFromOtherAnimals;
        name = Name;
        whatanimal = WhatAnimal;
    }
    
    eClassificationAnimal GetClassificationAnimal() => classification;

    eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Everything; 
    }

    void SayHello() { Console.WriteLine("Hello from pig!"); }
}