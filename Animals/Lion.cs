namespace Animals;

[My("lion from animal")]
public class Lion : Animal
{
    public Lion() : base() {}

    public Lion(string country, string HideFromOther, string name, string whatanimal) :
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
        return eFavoriteFood.Meat; 
    }

    void SayHello() { Console.WriteLine("Hello from lion!"); }
}