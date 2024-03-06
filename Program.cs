using System;
public class Animal<T>
{
    // Generic property
    public T data;

    // Constructor
    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Lion");
        Animal<string> animalHabitat = new Animal<string>("Savannah");
        Animal<bool> endangered = new Animal<bool>(false);
        Animal<bool> extinct = new Animal<bool>(false);
        Animal<int> averageLifespan = new Animal<int>(15);
    }
}