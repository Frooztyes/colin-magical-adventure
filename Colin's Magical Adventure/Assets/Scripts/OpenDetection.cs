using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDetection : MonoBehaviour
{
    BoxCollider boxCollider;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        animator = GetComponentInChildren<Animator>();
        //animation = GetComponentInChildren<Q>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other){
        
        if (other.gameObject.name == "Hand")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Key a down");
                /*animation.Play("OpenDoor");
                isAnimated = true;*/
                if (!animator.GetBool("isOpen"))
                {
                    animator.SetBool("isOpen", true);
                }
                else
                {
                    animator.SetBool("isOpen", false);
                }
            }
                

            //Debug.Log("collision with player");
        }

    }

    void OnTriggerExit(Collider other)
    {
        /*GameObject newNeighbor = other.GetComponent<CapsuleCollider>().gameObject;
        if (newNeighbor.tag == "Player")
        {
            animator.SetBool("isOpen", false);
        }*/
    }

    public void openDoor()
    {
        animator.SetBool("isOpen", true);
    }
    public void closeDoor()
    {
        animator.SetBool("isOpen", false);
    }
}
