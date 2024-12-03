using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 0.7f;
    private float weight = 3f;


    void Start()
    {
        Init("Bird");
        MakeSound();
        CalculateFoodRequirement();
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg. daily and weights {weight} kg.");
        Debug.Log($"{animalName}'s weekly food requirement: {CalculateFoodRequirement()} kg.");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} says Tweet!");
    }

    public override float CalculateFoodRequirement()
    {
        return dailyFoodConsumption * weight * 7;
    }
}
