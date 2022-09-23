using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    [SerializeField] private PlayerMovementScript player;

    private Transform playerTransform;
    public Vector3 offset;
   
    // Update is called once per frame

    private void Start()
    {
        //Get player transform
        playerTransform = player.GetComponent<PlayerMovementScript>().transform;
    }
    void LateUpdate()
    {
        if (playerTransform!=null)
        {
            CamFollow();
        }
       
    }
    void CamFollow()
    {
        //follow!
        Vector3 targetPos = playerTransform.position + offset;
        transform.position = targetPos;
    }
}
