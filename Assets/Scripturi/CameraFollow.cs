using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private Vector3 offset;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            playerTransform.position.x + offset.x,
            playerTransform.position.y + offset.y + 0.85f, //questionable
            playerTransform.position.z + offset.z - 2.5f   //questionable
        );
    }
}
