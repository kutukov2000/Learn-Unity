using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject);

            ApplePicker ap = Camera.main.GetComponent<ApplePicker>();
            ap.AppleDestroyed();
        }
    }
}
