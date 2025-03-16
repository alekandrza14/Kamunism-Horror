using UnityEngine;
using UnityEngine.UI;

public class CusokQuest : MonoBehaviour
{
    public Text QuestText;
    public int QuestSucsses;
    public string QuestDetals = "части";
    public int QuestMax = 5;
    void Update()
    {
        QuestText.text = QuestDetals + " "+ QuestSucsses + " из "+QuestMax;
    }
}
