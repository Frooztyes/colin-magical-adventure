using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SheetOpen", 0);
        PlayerPrefs.SetInt("SheetTaken", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            foreach(Sprite go in GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().getSheets())
            {
                Debug.Log(go.name);
            }
        }
    }
}
