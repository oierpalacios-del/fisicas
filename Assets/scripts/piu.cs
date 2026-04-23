using UnityEngine;

public class piu : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(transform.position, transform.forward,Color.green);
            GameObject instance = Instantiate(prefab);
            instance.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            instance.GetComponent<Rigidbody>().AddForce(transform.forward*5000,ForceMode.Force);
        }
    }
}
