using UnityEngine;
[ExecuteAlways]
public class DeltaruneFontan : MonoBehaviour
{
    
    void Update()
    {
        transform.localScale = new Vector3(Random.Range(4,12),1, Random.Range(4, 12));
    }
}
