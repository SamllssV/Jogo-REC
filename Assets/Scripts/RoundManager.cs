using UnityEngine;
using System.Collections;

public class RoundManager : MonoBehaviour
{
    SpawnThrowables spawnThrowables;
    public int numberOfThrowables;
    private int throwablesToSpawn;
    public float baseSpeed = 1f;
    public float speedIncrease = 0.001f;
    public PlayerScore playerScore;

    void Start()
    {
        spawnThrowables = FindObjectOfType<SpawnThrowables>();
        playerScore = FindObjectOfType<PlayerScore>();
        StartCoroutine(StartRound());
    }

    public IEnumerator StartRound()
    {
        throwablesToSpawn = Random.Range(1, 6);
        numberOfThrowables = throwablesToSpawn;

        for (int i = 0; i < throwablesToSpawn; i++)
        {
            yield return new WaitForSeconds(baseSpeed);
            spawnThrowables.StartSpawn();
        }
        
    }

    public void EndRound()
    {
        numberOfThrowables--;

        if(numberOfThrowables == 0)
        {
            StartCoroutine(StartRound());
            playerScore.roundNumber++;
            playerScore.pointsAccumulated += 10;
            playerScore.StartCoroutine(playerScore.ScoreUpdate());
            SpeedIncrease();
        }

    }

    void SpeedIncrease()
    {
        baseSpeed -= speedIncrease;
        Debug.Log("Speed increased to: " + baseSpeed);
    }

}
