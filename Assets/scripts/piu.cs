using UnityEngine;

public class piu : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    GameObject target;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject instance = Instantiate(prefab);
            instance.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            instance.GetComponent<Rigidbody>().AddForce(transform.forward*5000,ForceMode.Force);
        }
    }
    private void FixedUpdate()
    {
        int layerMask = 1<<6;
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            if(target != null)
            {
                target.GetComponent<Cube>().backToNormal();
            }
            hit.collider.gameObject.GetComponent<Cube>().cambioColor();
            target = hit.collider.gameObject;
            Debug.Log("Did hit " + hit.collider.gameObject.name);
        }
        else
        {
            Debug.Log("Did not hit");
        }
    }
}
