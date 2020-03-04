using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenUp : MonoBehaviour
{
    public AudioSource sound;
    public GameObject image;
    public Sprite imageToOpen;
    public Sprite imageNull;
    private Inventory inventory;
    public GameObject inventoryGameObject;

    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!open)
                {
                    sound.Play();
                    PlayerPrefs.SetInt("SheetOpen", 1);
                    image.transform.parent.gameObject.SetActive(true);
                    image.GetComponent<Image>().sprite = imageToOpen;
                    open = true;
                }
                else
                {
                    PlayerPrefs.SetInt("SheetOpen", 0);
                    image.transform.parent.gameObject.SetActive(false);
                    open = false;
                    PlayerPrefs.SetInt("SheetTaken", PlayerPrefs.GetInt("SheetTaken")+1);
                    
                    inventory.addSheet(Instantiate(this.gameObject, inventoryGameObject.transform));
                    Destroy(this.gameObject);

                }
            }
        }
     }
    
}
