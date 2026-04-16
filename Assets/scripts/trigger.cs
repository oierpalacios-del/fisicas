using UnityEngine;

public class trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entro");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salgo");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Mantengo");
    }
}
