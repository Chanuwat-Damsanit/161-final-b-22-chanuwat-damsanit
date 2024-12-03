using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Golem");
        Cast("Golem", 7);
    }

    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting a Ice Spell! Get Freeze!");
    }
}
