using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
public void StartGame()
{
 print("開始遊戲");
 SceneManager.LoadScene("Lv.1");
}
public void QuitGame()
{
 print("結束遊戲");
 Application.Quit();
}
}
