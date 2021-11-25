using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Quitted Game");
        Application.Quit();
    }
}