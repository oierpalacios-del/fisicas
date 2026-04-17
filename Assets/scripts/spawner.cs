using UnityEngine;

public class spawner : MonoBehaviour
{
    public Object prefab;
    void Start()
    {
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
