using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyKara : MonoBehaviour
{
    [SerializeField] GameObject scrimerWindow;
    [SerializeField] GameObject player;

    static float timer;
    public void OpenSkrimer()
    {
        scrimerWindow.SetActive(true);
        player.SetActive(false);
    }
    public void GiveMoney()
    {
        fristPersonControler.money += 100;
    }
    public static void PlaySkrimer()
    {
        MoneyKara findeddeadwindow = FindFirstObjectByType<MoneyKara>();
        findeddeadwindow.scrimerWindow.SetActive(true);
        findeddeadwindow.player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 8) if (fristPersonControler.money > 300)
            {
                PlaySkrimer();
            }
    }
    public void newGame()
    {
        SceneManager.LoadScene(0);
    }
}
