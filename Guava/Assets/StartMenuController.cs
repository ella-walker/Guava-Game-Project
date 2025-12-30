using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuControllor : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("open_page");
    }
}