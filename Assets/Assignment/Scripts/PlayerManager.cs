using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private GameObject circleTimer;
    [SerializeField] private GameObject playerObj;
    //[SerializeField] private Spawner spawner;

    private PlayerMove playerMove;

    // Start is called before the first frame update
    void Start()
    {
        //circleTimer.gameObject.SetActive(false);
        StartCoroutine(CountdownTimer());
        playerMove = playerObj.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
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

        circleTimer.gameObject.SetActive(true);
       //playerMove.gameObject.SetActive(true);

        playerObj.GetComponent<PlayerMove>().enabled = true;

        //spawner.enabled = true;
        //gameStarted = true;
        yield return new WaitForSeconds(1f);
        countdownText.SetText("");

        yield return null;
    }

}
