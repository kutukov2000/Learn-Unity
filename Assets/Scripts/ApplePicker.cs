using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBuskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBuskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    public void AppleDestroyed()
    {
        GameObject[] list = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject apple in list)
        {
            Destroy(apple);
        }
        int lastBasketIndex = basketList.Count - 1;
        GameObject lastBasket = basketList[lastBasketIndex];
        basketList.RemoveAt(lastBasketIndex);
        Destroy(lastBasket);

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("Scene0");
        }
    }
}
