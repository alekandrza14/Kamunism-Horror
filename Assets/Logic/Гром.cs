using UnityEngine;

public class Гром : MonoBehaviour
{
    Rigidbody phy;
    float force;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = Instantiate(Resources.Load<GameObject>("audioPresets/Грох"), transform.position, Quaternion.identity);
        obj.GetComponent<AudioSource>().volume = force/2;
        obj.GetComponent<AudioSource>().Play();
        if (force >= 7)
        {

            deadWindow.PlaySkrimer();
        }
        if (force >= 5)
        {
            GameObject obj1 = Instantiate(Resources.Load<GameObject>("audioPresets/Маты"), transform.position, Quaternion.identity);
            obj1.GetComponent<AudioSource>().Play();
        }
        Debug.Log("Force : " + force);
    }

    void Start()
    {
        phy = GetComponent<Rigidbody>();
    }
    void Update()
    {
        force = Vector3.Distance(phy.linearVelocity, Vector3.zero);
    }
}
