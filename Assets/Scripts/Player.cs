using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("м/c")][SerializeField] float xSpeed = 4f;
    [Tooltip("м/c")][SerializeField] float ySpeed = 4f;
    [Tooltip("Ограничение по X")][SerializeField] float XClamp = 17f;
    [Tooltip("Ограниченик по Y")][SerializeField] float YClamp = 17f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float xOffset = xMove * xSpeed * Time.deltaTime;
        float newXPos = transform.localPosition.x + xOffset;
        float xClampPos = Mathf.Clamp(newXPos, -XClamp, XClamp);

        float yMove = Input.GetAxis("Vertical");
        float yOffset = yMove * ySpeed * Time.deltaTime;
        float newYPos = transform.localPosition.y + yOffset;
        float yClampPos = Mathf.Clamp(newYPos, -YClamp, YClamp);

        transform.localPosition = new Vector3(xClampPos, yClampPos, transform.localPosition.z);
    }
}

