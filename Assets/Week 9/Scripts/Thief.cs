using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{

    public GameObject daggerPrefab;
    public Transform spawnPointA;
    public Transform spawnPointB;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;

    }

    protected override void Attack()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        base.Attack();
        Instantiate(daggerPrefab, spawnPointA.position, spawnPointA.rotation);
        Instantiate(daggerPrefab, spawnPointB.position, spawnPointB.rotation);
    }
}
