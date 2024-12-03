using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 0.9f;
    private int activityLevel = 5;
    
    void Start()
    {
        Init("Dog");
        MakeSound();
        CalculateFoodRequirement();
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg. daily with activity level {activityLevel}");
        Debug.Log($"{animalName}'s weekly food requirement: {CalculateFoodRequirement()} kg.");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} says Woof!");
    }
    public override float CalculateFoodRequirement()
    {
        return dailyFoodConsumption * activityLevel * 7; 
    }
}
