using UnityEngine;
using System.Collections;
public class CameraFollow : MonoBehaviour
{
  
    public Transform targetObject; //Transform = info on position, rotation, scale
 
    public Vector3 cameraOffset; //default distance between the camera and the player
    
    public float smoothSpeed = 0.5f; //to smooth camera movement

    public bool lookAtTarget = false; //check if the camera looked at the target or not
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothSpeed);
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetObject.rotation, smoothSpeed);

        //Camera rotation change
        if (lookAtTarget) 
        {
            transform.LookAt(targetObject);
            //transform.rotation = Quaternion.Lerp(transform.rotation, targetObject.rotation, smoothSpeed);
        }
    }





    /*public Transform targetObject;
  public float pLerp = .02f; //position speed
  public float rLerp = .01f; //rotation speed
  public Vector3 cameraOffset; //default distance between the camera and the player

  private void Update()
  {
      transform.position = Vector3.Lerp(transform.position, targetObject.position, pLerp);
      transform.rotation = Quaternion.Lerp(transform.rotation, targetObject.rotation, rLerp);
  }*/



    // Update is called once per frame
    /*void FixedUpdate() //same as update but it's run right after
    {
        Vector3 desiredPosition = targetObject.position + Cameraoffset; // we add offset so the camera it's not on theplayer but we have the offset
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed); //Lerp is to smoth the movement from point A to point B; smoothSpeed = valute beween 0 and 1 = if it's 0 it gives us the first position (=transform.position), if it's 1 it gives us the second positiono (= desiredPosition); her ewe decide how close to get and how colse we get depends on smoothSpeed
        transform.position = smoothedPosition;

        //transform.LookAt(target); //so the camera always face our player
    }*/
}
