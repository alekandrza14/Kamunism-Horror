using UnityEngine;
using UnityEngine.SceneManagement;

public class deadWindow : MonoBehaviour
{
    [SerializeField] GameObject scrimerWindow;
    [SerializeField] GameObject player;
    public void OpenSkrimer()
    {
        scrimerWindow.SetActive(true);
        player.SetActive(false);
    }
    public static void PlaySkrimer()
    {
        deadWindow findeddeadwindow = FindFirstObjectByType<deadWindow>();
        findeddeadwindow.scrimerWindow.SetActive(true);
        findeddeadwindow.player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
  
    public void newGame()
    {
        SceneManager.LoadScene(0);
    }
}
