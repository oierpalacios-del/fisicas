using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(gameObject.transform.position.x + 1 * speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(gameObject.transform.position.x - 1 * speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1 * speed * Time.deltaTime);
        }
    }
}
