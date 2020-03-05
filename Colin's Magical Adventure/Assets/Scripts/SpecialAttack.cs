using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttack : MonoBehaviour
{
    public LayerMask LayerMask;
    public AudioSource AttackSound;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            AttackSound.Play();
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius, LayerMask);
            foreach(Collider c in hitColliders)
            {
                c.gameObject.GetComponent<Chocked>().HasBeenChocked();                
            }
        }
    }
}
