using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private GameObject infoMSG;
    [SerializeField] private GameObject playerObj;

    private PlayerMove playerMove;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownTimer());
        playerMove = playerObj.GetComponent<PlayerMove>();
    }

    IEnumerator CountdownTimer()
    {
        countdownText.SetText("3");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("2");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("1");
        yield return new WaitForSeconds(1f);
        countdownText.SetText("Go!");

        infoMSG.gameObject.SetActive(true);
        playerObj.GetComponent<PlayerMove>().enabled = true;

        yield return new WaitForSeconds(1f);
        countdownText.SetText("");

        yield return null;
    }

}
