using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CenterOfMass : MonoBehaviour
{

    public Vector3 CenterOfMass2 = new Vector3(0.0f, 0.0f, 0.0f);
    public float radius = 1.0f;
    bool Awake;
    protected Rigidbody r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        r.centerOfMass = CenterOfMass2;
        r.WakeUp();
        Awake = !r.IsSleeping();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, radius);
    }
}
