using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    float rotationSpeed;
    [SerializeField] private Transform rotateAround;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = (transform.position - rotateAround.position).sqrMagnitude * 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotateAround.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        transform.up = rotateAround.position - transform.position;
    }
}
