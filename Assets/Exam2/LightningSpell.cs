using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Zombie");
        Cast("Zombie", 10);
        Cast("Zombie", 10, "LIGHTNING BOLT!!!!");
    }

    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting a Lightning Spell! Get Stun!");
    }

    public void Cast(string enemy, int level, string slogan)
    {
        Debug.Log($"Casting a Ultimate skill on a: {enemy} with power level: {level} and said {slogan}");
    }
}
