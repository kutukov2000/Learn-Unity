using System;
using UnityEngine;
public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAnfRightEdge = 25f;
    public float chanceToChangeDirections = 0.05f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAnfRightEdge)
        {
            speed = Math.Abs(speed);
        }
        else if (pos.x > leftAnfRightEdge)
        {
            speed = -Math.Abs(speed);
        }
    }

    void FixedUpdate()
    {
        if (UnityEngine.Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
