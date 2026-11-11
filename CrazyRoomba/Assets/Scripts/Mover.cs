using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  
    void Update()
    {
        MoveRoomba();
    }


    void MoveRoomba(float moveSpeed = 10f)
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * moveSpeed, 0f, zValue * moveSpeed);
    }

}
