using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string newName)
    {
        animalName = newName;
        DisplayName();
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound()
    {
        Debug.Log("The Animal makes a sound.");
    }

    public void DisplayName()
    {
        Debug.Log($"This is a {animalName}.");
    }
/*

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
