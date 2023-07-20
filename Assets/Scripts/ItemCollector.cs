using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    int coinToWin = 7;
    float timeRemaining = 20f;

    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI timerText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
            timerText.text = "Coins missing: " + (coinToWin - coins);
        }
    }

    public void Update()
    {
        if (coins == coinToWin)
        {
            GameWin();
        }

        // TIMER
        timeRemaining -= Time.deltaTime;
        timeRemaining = Mathf.Max(0f, timeRemaining);

        string seconds = ((int)timeRemaining).ToString("00");
        string milliseconds = ((timeRemaining * 1000) % 1000).ToString("000");

        timerText.text = "Time: " + seconds + ":" + milliseconds;

        if (timeRemaining <= 0f)
        {
            GameOver();
        }
    }


    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }

    public void GameWin()
    {
        SceneManager.LoadScene(2);
    }
}