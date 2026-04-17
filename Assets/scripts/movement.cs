using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump_speed;
    Rigidbody rb;
    bool canJump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            canJump = true;
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&canJump)
        {
            rb.AddForce(transform.up * jump_speed);
            canJump = false;
        }
    }
}
