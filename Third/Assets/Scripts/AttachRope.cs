using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class AttachRope : MonoBehaviour
{
    private HingeJoint2D _joint;
    
    private void Awake()
    {
        _joint = GetComponent<HingeJoint2D>();
    }
    
    private void Start()
    {
        
    }
    
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            _joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
            _joint.enabled = true;
        }
    }
}
