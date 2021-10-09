using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameController : MonoBehaviour
{
    /*SceneManager.LoadScene("GameScene");*/
    /*Time.timeScale = 0f;*/
    public Text coinText;
    public static float coinAmount;
    bool loadGame;
    bool displayLabel;
   
    // Start is called before the first frame update
    public void Start()
    {
        loadGame = true;
    }
    // Update is called once per frame
    public void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (coinAmount >= 0)
        {
            coinText.text = coinAmount.ToString();
        }
        if (player == null && loadGame == true)
        {
            gameOver();
        }
    }
    public void AddCoin()
    {
        coinAmount++;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        loadGame = true;
    }
    public void gameOver()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        loadGame = false;
    }
    public void pauseGame()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        loadGame = false;
    }
    public void resumeGame()
    {
        SceneManager.UnloadSceneAsync("Pause");
        Time.timeScale = 1;
        loadGame = true;
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
        loadGame = false;
    }


}
