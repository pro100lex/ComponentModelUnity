using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
public class UncouplingRope : MonoBehaviour
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

    private void OnMouseDown()
    {
        _joint.enabled = false;
    }

}
