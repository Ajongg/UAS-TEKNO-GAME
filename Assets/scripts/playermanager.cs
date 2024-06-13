using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermanager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameoverpanel;
    public static bool isGameStarted;
    public GameObject StartText;
    public static int numberCoins;
    public Text CoinsText;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver) 
        {
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
        }
        CoinsText.text = "Coins: " + numberCoins;
        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(StartText);
        }
    }

}
