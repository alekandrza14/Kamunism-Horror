using UnityEngine;
using UnityEngine.SceneManagement;

public class opustitobject : MonoBehaviour
{
    [SerializeField] GameObject grabQuest; [SerializeField] int scene;
    private void OnTriggerEnter(Collider other)
    {
        CusokQuest quest = FindFirstObjectByType<CusokQuest>();

        if (other.GetComponent<Гром>())
        {

            quest.QuestSucsses += 1;
            Instantiate(grabQuest, transform.position, Quaternion.identity);
            fristPersonControler.money += 10;
            Destroy(other.gameObject);
        }
        if (quest.QuestSucsses == quest.QuestMax)
        {
            if (other.GetComponent<fristPersonControler>())
            {

                SceneManager.LoadScene(scene);

            }
        }
    }
}
