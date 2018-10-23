using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Reflection.Emit;


public class GameController : MonoBehaviour
{

    bool isEndGame;
    bool isStartFirstTime = true;
    int GamePoint = 0;
    public Text txtPoint;
    public GameObject pnlEndGame;
    public Text txtEndPoint;
    public Button btnRestart;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        isStartFirstTime = true;
        pnlEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStartFirstTime)
            {
                // Time.timeScale = 1;
                // isEndGame = false;
                StartGame();
                // load man choi (chua chay duoc)
                // SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }
    public void GetPoint()
    {
        GamePoint++;
        txtPoint.text = "Point: " + GamePoint.ToString();
    }
    void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        StartGame();
    }
    public void EndGame()
    {
        isEndGame = true;
        isStartFirstTime = false;
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtEndPoint.text = "Your Point\n" + GamePoint.ToString();
    }
}