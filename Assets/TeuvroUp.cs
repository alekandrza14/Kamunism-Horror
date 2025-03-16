using UnityEngine;
using UnityEngine.UI;

public class TeuvroUp : MonoBehaviour
{
    public Text moneyCounter;
    void Update()
    {
        fristPersonControler.money++;
        moneyCounter.text = "Тевро : " + fristPersonControler.money;
    }
}
