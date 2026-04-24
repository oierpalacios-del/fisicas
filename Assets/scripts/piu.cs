using UnityEngine;

public class piu : MonoBehaviour
{
    GameObject objeto;
    public GameObject[] objetos;
    [SerializeField] GameObject prefab;
    private void Start()
    {
        foreach(GameObject obj in objetos)
        {
            obj.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
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
            objeto = hit.collider.gameObject;
            objeto.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("Did hit " + hit.collider.gameObject.name);
        }
        else
        {
            objeto.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Did not hit");
        }
    }
}
