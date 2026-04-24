using UnityEngine;

public class piud : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 10);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroyed")
        {
            other.gameObject.GetComponent<Cube>().changeHealth();
        }
    }
}
