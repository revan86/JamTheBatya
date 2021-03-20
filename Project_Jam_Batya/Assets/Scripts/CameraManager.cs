using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform startPosition;
    [SerializeField]
    private Transform endPosition;
    [SerializeField]
    private float stepMoveCamera = 1;
    private float speedMove;
    


    void Start()
    {
        transform.position = new Vector3(startPosition.transform.position.x, startPosition.transform.position.y, -10);

    }

    void Update()
    {
        speedMove = stepMoveCamera * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, endPosition.position, speedMove);
        transform.position = new Vector3(transform.position.x, transform.position.y,-10);
    }
}
