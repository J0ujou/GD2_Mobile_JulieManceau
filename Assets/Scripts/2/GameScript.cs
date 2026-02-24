using TMPro;
using UnityEngine;

public class GameScript : MonoBehaviour
{
   [SerializeField] private CharaBehaviour _charaBehaviour;
   [SerializeField] TMP_Text _scoreText;

    private int playerScore = 0;
    private float scoreTimer = 0f;

    private void Update()
    {
        scoreTimer += Time.deltaTime;
        
        //ajouter 1 point tte les secondes
        if (scoreTimer >= 1f)
        {
            playerScore += 1;
            scoreTimer = 0f;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        _scoreText.text = $"Score : {playerScore.ToString()}";
    }
}
