using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private const string HighScoreKey = "HighScore";
    static public int Score = 10;
    void Awake()
    {
        if (PlayerPrefs.HasKey(HighScoreKey))
        {
            Score = PlayerPrefs.GetInt(HighScoreKey);
        }
        PlayerPrefs.SetInt(HighScoreKey, Score);
    }
    void Update()
    {
        Text gt = GetComponent<Text>();
        gt.text = "Кращий результат: " + Score;

        if (Score > PlayerPrefs.GetInt(HighScoreKey))
        {
            PlayerPrefs.SetInt(HighScoreKey, Score);
        }
    }
}
