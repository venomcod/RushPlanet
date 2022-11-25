using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("�/c")][SerializeField] float Speed = 4f;
    [Tooltip("����������� �� X")][SerializeField] float XClamp = 17f;
    [Tooltip("����������� �� Y")][SerializeField] float YClamp = 17f;

    // Start is called before the first frame update
    void Start()
    {
        RotatePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        float xMove = Input.GetAxis("Horizontal");
        float xOffset = xMove * Speed * Time.deltaTime;
        float newXPos = transform.localPosition.x + xOffset;
        float xClampPos = Mathf.Clamp(newXPos, -XClamp, XClamp);

        float yMove = Input.GetAxis("Vertical");
        float yOffset = yMove * Speed * Time.deltaTime;
        float newYPos = transform.localPosition.y + yOffset;
        float yClampPos = Mathf.Clamp(newYPos, -YClamp, YClamp);

        transform.localPosition = new Vector3(xClampPos, yClampPos, transform.localPosition.z);
    }

    void RotatePlayer()
    {
        transform.localRotation = Quaternion.Euler(-30, 30, 0);
    }

}

