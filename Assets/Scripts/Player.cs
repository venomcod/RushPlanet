using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("м/c")][SerializeField] float Speed = 4f;
    [Tooltip("Ограничение по X")][SerializeField] float XClamp = 17f;
    [Tooltip("Ограниченик по Y")][SerializeField] float YClamp = 17f;
    [SerializeField] float xRotFacrtor = -0.7f;
    [SerializeField] float yRotFacrtor = -0.7f;
    [SerializeField] float zRotFacrtor = 4f;
    [SerializeField] float xMoveRot = 0f;
    [SerializeField] float yMoveRot = 0f;
    [SerializeField] float zMoveRot = 0f;

    float xMove, yMove;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }


    void MovePlayer()
    {
        xMove = Input.GetAxis("Horizontal");
        float xOffset = xMove * Speed * Time.deltaTime;
        float newXPos = transform.localPosition.x + xOffset;
        float xClampPos = Mathf.Clamp(newXPos, -XClamp, XClamp);

        yMove = Input.GetAxis("Vertical");
        float yOffset = yMove * Speed * Time.deltaTime;
        float newYPos = transform.localPosition.y + yOffset;
        float yClampPos = Mathf.Clamp(newYPos, -YClamp, YClamp);

        transform.localPosition = new Vector3(xClampPos, yClampPos, transform.localPosition.z);
    }

    void RotatePlayer()
    {
        float xRot = transform.localPosition.y * xRotFacrtor + yMove * xMoveRot;
        float yRot = transform.localPosition.x * yRotFacrtor + xMove * yMoveRot;
        float zRot = xMove * zMoveRot;
        transform.localRotation = Quaternion.Euler(xRot, yRot, zRot);
    }

}

