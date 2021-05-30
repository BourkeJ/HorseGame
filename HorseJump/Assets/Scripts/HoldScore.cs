using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoldScore : MonoBehaviour
{
    //public float scoreHolder = 0;
    [SerializeField] private Text _scoreText = null;
    [SerializeField] private Text _speedText = null;
    [SerializeField] private float _time = 0f;
    [SerializeField] private ConveyorMovement _conveyorMovement= null;
    
    private float _currentSpeed = 0f;

    [HideInInspector] public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(won == false)
        {
            _time += Time.deltaTime;
        }
        _scoreText.text = _time.ToString();


        _currentSpeed = -100 *_conveyorMovement.velocity.x;
        _speedText.text = _currentSpeed.ToString();

    }
}
