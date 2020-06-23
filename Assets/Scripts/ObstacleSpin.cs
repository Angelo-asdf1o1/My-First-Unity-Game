using System. Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpin: MonoBehaviour
{
    public float SpinSpeed = 200f;

    void Update(){
transform.Rotate(new Vector3(0f, SpinSpeed, 0f) * Time.deltaTime);

    }
}
