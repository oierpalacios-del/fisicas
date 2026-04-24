using UnityEngine;

public class Cube : MonoBehaviour
{
    int health = 3;
    public void cambioColor()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
    }
    public void changeHealth()
    {
        health--;
        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
    public void backToNormal()
    {
        transform.GetComponent<MeshRenderer>().material.color= Color.red;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
