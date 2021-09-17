using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private bool isInteracting = false;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    [SerializeField] private Transform cameraRoot;
    public Collider playerCollider;
    // Start is called before the first frame update

    private void Awake()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider playerCollider)
    {
        isInteracting = true;
    }

    private void OnTriggerExit(Collider playerCollider)
    {
        isInteracting = false;
    }

    void Update()
    {
        
        //if (Input.GetKeyDown(KeyCode.P)) 
        //if (Input.GetKeyUp(KeyCode.P)) isInteracting = false;

        if (!isInteracting)
        {

            transform.position = new Vector3(cameraRoot.position.x + initialPosition.x, initialPosition.y, cameraRoot.position.z);
            transform.rotation = initialRotation;

        }
        else
        {
            transform.position = new Vector3(cameraRoot.position.x + initialPosition.x, initialPosition.y - 2, cameraRoot.position.z);
            print("AAA");
        }
    }


}
