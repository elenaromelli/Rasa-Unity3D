using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    /*public Vector3 movimentoOrizz;
    public Vector3 movimentoVert;
    public Vector3 movimentoAvanti;
    public Vector3 movimentoDietro;*/
    public int velocità = 30;
    public int direction = 3;
    //public float tempo = 20; 
    public GameObject Int1;
    //public GameObject Int2;
    //public GameObject Int3;


    HTTPTest leggi; //creo la variabile 'leggi' che è di tipo "HTTPTest" 

    // Use this for initialization 
    void Start()
    {
        leggi = gameObject.GetComponent<HTTPTest>(); //assegna a 'leggi' il componente, cioè lo script contenuto nel gameObject
       
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        if (leggi.displayOutgoingText.text.Contains("walk"))
        {
           
            transform.position -= transform.right * Time.deltaTime * velocità; //transform.right moves an obj on x axis
            direction = 0;
        }

        if (leggi.displayOutgoingText.text.Contains("left")) //left == 1
        {
            if (direction == 0)
            {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 1;
            }

            if (direction == 2)
            {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 1;
            }
            if (direction == 3) {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 1; //1 sta per left
            }
            if (direction == 4)
            {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 1;
            }


            //transform.position += transform.forward * Time.deltaTime * velocità;
            //transform.position -= transform.right * Time.deltaTime * velocità; //to create object relative movement; The difference is that the direction is based on the object’s orientation, not the world. Which means that if the object rotates, it’ll turn as it moves.

        }

        if (leggi.displayOutgoingText.text.Contains("right"))
        {
            if (direction == 0)
            {
                transform.rotation *= Quaternion.Euler(0, 90, 0); //to rotate the player
                direction = 2;
            }
            if (direction == 1) //sta andando a sinistra
            {
                transform.rotation *= Quaternion.Euler(0, 90, 0); //to rotate the player
                direction = 2; //2 sta per right
             }
            if (direction == 3) //sta andando dritto
            {
                transform.rotation *= Quaternion.Euler(0, 90, 0); //to rotate the player
                direction = 2; 
            }
            if (direction == 4)
            {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 2;
            }

           

            //transform.position += transform.forward * Time.deltaTime * velocità;
            //transform.position -= transform.right * Time.deltaTime * velocità;
            //tempo += 1 * Time.deltaTime;
            //leggi.displayOutgoingText.text = "stop";
            //transform.rotation *= Quaternion.Euler(0, 90, 0);
        }

        /*if (leggi.displayOutgoingText.text.Contains("straight"))
        {
            if (direction == 1) //sta andando a sinistra
            {
                transform.rotation *= Quaternion.Euler(0, 90, 0); //to rotate the player
                direction = 3; //3 sta per avanti
            }
            if (direction == 2) //sta andando a destra
            {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 3;
            }
            if (direction == 4) 
            {
                transform.rotation *= Quaternion.Euler(0, 180, 0); //to rotate the player
                direction = 3;
            }

            //transform.position -= transform.right * Time.deltaTime * velocità;
            //transform.position += transform.forward * Time.deltaTime * velocità;
        }*/

        if (leggi.displayOutgoingText.text.Contains("back"))
        {
            if (direction == 1) //sta andando a sinistra
            {
                transform.rotation *= Quaternion.Euler(0, -90, 0); //to rotate the player
                direction = 4; //4 sta per indietro
            }
            if (direction == 2) //sta andando a destra
            {
                transform.rotation *= Quaternion.Euler(0, 90, 0); //to rotate the player
                direction = 4;
            }
            if (direction == 3) 
            {
                transform.rotation *= Quaternion.Euler(0, 180, 0); //to rotate the player
                direction = 4;
            }

            //transform.position -= transform.right * Time.deltaTime * velocità;
            //transform.position += transform.forward * Time.deltaTime * velocità;
        }
        
        if (leggi.displayOutgoingText.text.Contains("intersection"))
        {
            transform.position = Vector3.MoveTowards(transform.position, Int1.transform.position, velocità * Time.deltaTime);
            direction = 0; 
        }
        
        /*if (leggi.displayOutgoingText.text.Contains("next intersection"))
        {
            if (direction == 0) //se rimane rivolto verso dritto = vai all'intersection 2
            {
                transform.position = Vector3.MoveTowards(transform.position, Int2.transform.position, velocità * Time.deltaTime);
            }
            if (direction == 1) //se si è girato a sinistra, vai all'intersection 3
            {
                transform.position = Vector3.MoveTowards(transform.position, Int3.transform.position, velocità * Time.deltaTime);
            }
           
        }*/

    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Int1")  // or if(gameObject.CompareTag("YourWallTag"))
        {
            transform.position = Int1.transform.position;
        }
    }*/

    



}