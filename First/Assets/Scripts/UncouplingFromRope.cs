using UnityEngine;

public class UncouplingFromRope : MonoBehaviour
{
    public GameObject linkObject;
    private HingeJoint2D _hinge;
   
    private void Start()
    {
        linkObject = GameObject.Find("5");
        _hinge = linkObject.GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        _hinge.enabled = false;
    }

}
