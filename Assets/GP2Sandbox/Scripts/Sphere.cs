using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(4f * Time.deltaTime * h * Vector3.right);
    }
}
