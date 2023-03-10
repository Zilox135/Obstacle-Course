using UnityEngine;

public class Dropper : MonoBehaviour
{  
    MeshRenderer meshRenderer;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;        
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;        
            rb.useGravity = true;             
        }
    }
}
