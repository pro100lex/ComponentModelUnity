using System;
using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
public class AttachRope : MonoBehaviour
{
    private HingeJoint2D _joint;

    private void Awake()
    {
        _joint = GetComponent<HingeJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out EndOfRope endOfRope))
        {
            _joint.connectedBody = other.gameObject.GetComponent<Rigidbody2D>();
            _joint.enabled = true;
        }
    }
}