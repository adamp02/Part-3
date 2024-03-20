using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{

    public GameObject daggerPrefab;
    public Transform spawnPointA;
    public Transform spawnPointB;
    public float dashSpeed = 7;
    Coroutine dashing;


    protected override void Attack()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (dashing != null )
        {
            StopCoroutine(dashing);
            StopAllCoroutines();
        }
        dashing = StartCoroutine(Dash());



    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;

    }


    IEnumerator Dash()
    {
        speed += dashSpeed;
        while(speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPointA.position, spawnPointA.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPointB.position, spawnPointB.rotation);
        

        //yield return null;
    }


}
