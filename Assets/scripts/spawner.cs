using UnityEngine;

public class spawner : MonoBehaviour
{
    public Object prefab;
    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 pos = transform.position;
            pos.x = pos.x * i;
            for(int j = 0; j<100; j++)
            {
                pos.z = transform.position.z;
                pos.z = pos.z * j;
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
