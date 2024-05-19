using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    void Start()
    {
        GameObject gameObject = GameObject.Find("ScoreCounter");
        scoreGT = gameObject.GetComponent<Text>();
        scoreGT.text = "0";
    }
    void Update()
    {
        Vector3 mousePos2d = Input.mousePosition;

        mousePos2d.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2d);

        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject gameObject = collision.gameObject;
        if (gameObject.tag == "Apple")
        {
            Destroy(gameObject);

            int score = int.Parse(scoreGT.text);
            score++;
            scoreGT.text = score.ToString();

            if (score > HighScore.Score)
            {
                HighScore.Score = score;
            }
        }
    }
}
