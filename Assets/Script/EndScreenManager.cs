using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void ReturnButton() 
    {
        SceneManager.LoadScene(0);
        StatsManager.Instance.Timer = 0f;
    }
}