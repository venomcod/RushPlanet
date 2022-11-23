using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField] InputAction controlMove;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        controlMove.Enable();
    }

    void OnDisable()
    {
        controlMove.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = controlMove.ReadValue<Vector2>().x;
        float verticalMove = controlMove.ReadValue<Vector2>().y;
        Debug.Log(horizontalMove);
        Debug.Log(verticalMove);
    }
}
