using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDetection : MonoBehaviour
{
    BoxCollider boxCollider;
    Animator animator;
    Animation animation;
    bool isAnimated;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        //animator = GetComponentInChildren<Animator>();
        animation = GetComponentInChildren<Animation>();
        isAnimated = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*if (isAnimated && animation["OpenDoor"].normalizedTime == 1)
        {
            
            isAnimated = false;
            animation.Stop();
        }*/
    }

    void OnTriggerStay(Collider other){

        Debug.Log(animation);
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animation.Play("OpenDoor");
                isAnimated = true;
            }
                //animator.SetBool("isOpen", true);

            Debug.Log("collision with player");
        }

    }

    void OnTriggerExit(Collider other)
    {
        GameObject newNeighbor = other.GetComponent<CapsuleCollider>().gameObject;
        if (newNeighbor.tag == "Player")
        {
            animator.SetBool("isOpen", false);
        }
    }
}
