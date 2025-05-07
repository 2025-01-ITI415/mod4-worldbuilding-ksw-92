using UnityEngine;

public class AppleCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // You can add sound, score, or animation here
            Destroy(gameObject);
        }
    }
}
