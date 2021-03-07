using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score;
    public GameObject winText;
    public GameObject restartButton;
    public GameObject balls;
    public GameObject streakText1;
    public GameObject streakText2;
    int killstreak;

    public float maxX;
    public float maxY;



    private void Start()
    {
        StartSpawnBalls();
        score = 0;
        winText.SetActive(false);
        restartButton.SetActive(false);
        streakText1.SetActive(false);
        streakText2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(killstreak == 4)
        {
            StartStreakTextDisplay1();
        }

        if (killstreak == 6)
        {
            StartStreakTextDisplay2();
        }
    }

    public void ScoreUp()
    {
        score++;
        killstreak++;
        StopKillStreakReset();
        StartKillStreakReset();
        if(score >= 20)
        {
            Win();
        }
        print(killstreak);
    }

    void Win()
    {
        StopSpawnBalls();
        winText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    void SpawnBalls()
    {
        

        Vector2 randomPos = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));
        Instantiate(balls, randomPos, transform.rotation);
        


    }
   
    IEnumerator SpawnBallsEnum()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            SpawnBalls();
            yield return new WaitForSeconds(2f);
        }


    }


    public void StartSpawnBalls()
    {
        StartCoroutine("SpawnBallsEnum"); 
    }

    public void StopSpawnBalls()
    {
        StopCoroutine("SpawnBallsEnum");
    }


    IEnumerator KillStreakReset()
    {
        yield return new WaitForSeconds(2f);
        
        {
            killstreak = 0;
            
        }


    }

    public void StartKillStreakReset()
    {
        StartCoroutine("KillStreakReset");
    }

    public void StopKillStreakReset()
    {
        StopCoroutine("KillStreakReset"); 
    }

    IEnumerator StreakTextDisplay1()
    {

        streakText1.SetActive(true);
        yield return new WaitForSeconds(2f);
        streakText1.SetActive(false);
    }

    public void StartStreakTextDisplay1()
    {
        StartCoroutine("StreakTextDisplay1");
    }

    IEnumerator StreakTextDisplay2()
    {
        streakText1.SetActive(false);
        streakText2.SetActive(true);
        yield return new WaitForSeconds(2f);
        streakText2.SetActive(false);
    }

    public void StartStreakTextDisplay2()
    {
        StartCoroutine("StreakTextDisplay2");
    }
}
