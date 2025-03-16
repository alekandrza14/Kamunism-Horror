using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] GameObject grabMoney;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<fristPersonControler>())
        {
            Instantiate(grabMoney,transform.position,Quaternion.identity);
            fristPersonControler.money++;
            Destroy(gameObject);
        }
    }
}
