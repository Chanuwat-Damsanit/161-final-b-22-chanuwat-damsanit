using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting simulation started");
        Debug.Log("Casting a generic spell!");
    }
   
    public void Cast(string enemy)
    {
        Debug.Log($"Casting a spell on a: {enemy}");
    }

    public void Cast(string enemy, int level)
    {
        Debug.Log($"Casting a spell on a: {enemy} with power level: {level}");
    }
}
