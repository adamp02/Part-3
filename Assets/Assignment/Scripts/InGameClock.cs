using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameClock : MonoBehaviour
{

    // based on a modified version of the 'SliderClock' code from Week 10

    public Slider slider;
    float timer;
    float prevTimer = 0f;
    public float speed = 1f;

    [SerializeField] private TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextTimer());
    }

    // Update is called once per frame
    void Update()
    {
        

        timer += Time.deltaTime * speed;
        timer = timer % 60;

        if (timer > prevTimer)
        {
            slider.value = timer;
        }

        prevTimer = timer;

     

    }

    IEnumerator TextTimer()
    {
        countdownText.SetText("15");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("14");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("13");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("12");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("11");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("10");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("9");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("8");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("7");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("6");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("5");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("4");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("3");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("2");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("1");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("Game Over!");

        yield return null;
    }

}
