using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFizika : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] MeshRenderer meshRenderer;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            rigidbody.AddForce(Vector3.up * 100, ForceMode.Force);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            rigidbody.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            rigidbody.AddTorque(Vector3.up * 10, ForceMode.VelocityChange);
        }
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The Collider involved in this collision</param>
    void OnTriggerEnter(Collider other)
    {
        meshRenderer.material.color = Color.red;
    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        meshRenderer.material.color = Color.white;
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider
    /// </summary>
    /// <param name="other">The Collision data associated with this collision</param>
    private void OnCollisionEnter(Collision other)
    {
        meshRenderer.material.color = Color.blue;
    }


}
