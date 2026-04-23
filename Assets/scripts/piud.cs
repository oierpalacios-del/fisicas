using UnityEngine;

public class piud : MonoBehaviour
{
    private float curTime;
    void Start()
    {
        curTime = 10;
    }

    void Update()
    {
        curTime -= Time.deltaTime;
        if(curTime <= 0)
        {
            Debug.Log("me mori");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroyed")
        {
            Debug.Log("Objetivo Alcanzado");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
