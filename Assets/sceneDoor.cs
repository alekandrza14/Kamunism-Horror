using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneDoor : MonoBehaviour
{
    [SerializeField] int scene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<fristPersonControler>())
        {
            SceneManager.LoadScene(scene);
        }
    }
}
