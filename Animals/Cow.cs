namespace Animals;

[My("cow from animal")]
public class Cow : Animal
{
    public Cow() : base() {}

    public Cow(string country, string HideFromOther, string name, string whatanimal) :
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
        return eFavoriteFood.Plants; 
    }

    void SayHello() { Console.WriteLine("Hello from cow!"); }
}