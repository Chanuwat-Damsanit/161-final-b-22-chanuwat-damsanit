using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Harpy");
        Cast("Harpy", 3);
    }

    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting a Fireball Spell! Punish them!");
    }
}
