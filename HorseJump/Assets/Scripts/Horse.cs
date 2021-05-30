using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
    [SerializeField] private ConveyorMovement _conveyorMovement = null;
    [SerializeField] private Vector3 _horseJump = Vector3.zero;

    public Vector3 _conveyorNewSpeed = Vector3.zero;
    [SerializeField] private Vector3 _horseNewJump = Vector3.zero;

    private Rigidbody _rigidbody = null;
    private Transform _transform = null;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    void OnMouseDown()
    {
        if(_transform.position.y >= -1f && _transform.position.y <= -0.7f)
        {
            _rigidbody.velocity += _horseJump;
        }
    }

    void Update()
    {
        if(_transform.position.y > 0.5f)
        {
            _rigidbody.velocity -= _horseJump * Time.deltaTime;
        }
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Carrot")
        {
            _conveyorMovement.velocity += _conveyorNewSpeed;
            _horseJump += _horseNewJump;
            print("yas");
        }else if(col.tag == "Fence")
        {
            _conveyorMovement.velocity -= _conveyorNewSpeed;
            _horseJump -= _horseNewJump;
            print("ouch");
        }
    }
}
