using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{

    public GameObject test;

    public float scaleRate = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Build());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Build()
    {
        //test.transform.localScale = Vector3.one;
        test.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, scaleRate);

        scaleRate += Time.deltaTime;

        yield return null;
    }

}
