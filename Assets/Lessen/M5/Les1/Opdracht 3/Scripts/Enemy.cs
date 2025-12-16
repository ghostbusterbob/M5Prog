using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {
       
        transform.Translate(Vector3.forward * Time.deltaTime * 2f);
    }
}
