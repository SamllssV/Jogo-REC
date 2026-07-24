using UnityEngine;

public class RoundManager : MonoBehaviour
{
    SpawnThrowables spawnThrowables;

    void Start()
    {
        spawnThrowables = FindObjectOfType<SpawnThrowables>();
        StartRound();
    }

    public void StartRound()
    {
        int numberOfThrowables = Random.Range(1, 6);

        for (int i = 0; i < numberOfThrowables; i++)
        {
            spawnThrowables.StartSpawn();
        }
    }

}
