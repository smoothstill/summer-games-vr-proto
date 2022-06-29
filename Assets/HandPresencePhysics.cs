using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPresencePhysics : MonoBehaviour
{

    public Transform target;
    private Rigidbody rb;
    public Renderer nonPhysicalHand;
    public float showNonPhysicalHandDistance = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > showNonPhysicalHandDistance)
        {
            nonPhysicalHand.enabled = true;
        }
        else
            nonPhysicalHand.enabled = false;
    }

    void FixedUpdate()
    {
        // position
        rb.velocity = (target.position - transform.position) / Time.fixedDeltaTime;

        // rotation
        Quaternion rotationDifference = target.rotation * Quaternion.Inverse(transform.rotation);
        rotationDifference.ToAngleAxis(out float angleInDegree, out Vector3 rotationAxis);

        Vector3 rotationDifferenceInDegrees = angleInDegree * rotationAxis;

        rb.angularVelocity = rotationDifferenceInDegrees * Mathf.Deg2Rad / Time.fixedDeltaTime;
    }
}
