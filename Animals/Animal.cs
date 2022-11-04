namespace Animals;

[My("animal(abstract)")]
abstract public class Animal
{
    public eClassificationAnimal classification;
    public string Country;
    public string HideFromOtherAnimals;
    public string Name;
    public string WhatAnimal;

    public Animal() {}

    public Animal(string country, string HideFromOther, string name, string whatanimal) =>
        (Country, HideFromOtherAnimals, Name, WhatAnimal) = (country, HideFromOther, name, whatanimal);
    
    public void Deconstruct(out string country, out string HideFromOther, out string name, out string whatanimal)
    {
        country = Country;
        HideFromOther = HideFromOtherAnimals;
        name = Name;
        whatanimal = WhatAnimal;
    }

    eClassificationAnimal GetClassificationAnimal() => classification;

    void GetFavoriteFood() {}

    void SayHello() {}
}

public enum eClassificationAnimal
{
    Hervivores,
    Carnivores,
    Omnivores
}

public enum eFavoriteFood
{
    Meat,
    Plants,
    Everything
}