using UnityEngine;

public class Throwables : MonoBehaviour
{
    RoundManager roundManager;

    void Start()
    {
        roundManager = FindObjectOfType<RoundManager>();
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        roundManager.EndRound();
        roundManager.playerScore.pointsAccumulated += 10;
        roundManager.playerScore.StartCoroutine(roundManager.playerScore.ScoreUpdate());
    }
}
