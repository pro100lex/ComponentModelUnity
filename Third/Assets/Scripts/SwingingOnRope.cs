using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SwingingOnRope : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    [SerializeField] private float _speed;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        var translation = Input.GetAxis("Horizontal");
        _rigidBody.AddForce(new Vector2(translation * _speed, 0));
    }
}
