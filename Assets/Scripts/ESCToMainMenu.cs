using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
