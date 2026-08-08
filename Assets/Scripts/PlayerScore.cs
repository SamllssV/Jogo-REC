using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI roundText;
    public int roundNumber;
    public int pointsAccumulated;
    public int pointsBase;
    RoundManager roundManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        roundManager = FindObjectOfType<RoundManager>();
        pointsBase = 0;
        pointsText.text = "Points: " + pointsBase;
        roundText.text = "Round: " + roundNumber;
    }
    // Update is called once per frame
    public IEnumerator ScoreUpdate()
    {
        while(pointsBase < pointsAccumulated)
        {
            pointsBase++;
            pointsText.text = "Points: " + pointsBase;
            yield return new WaitForSeconds(0.01f);
        }

    }
}
