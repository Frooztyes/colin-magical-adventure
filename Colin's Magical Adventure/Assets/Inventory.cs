using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Sprite> sheets;
    // Start is called before the first frame update
    void Start()
    {
        sheets = new List<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Sprite> getSheets()
    {
        return sheets;
    }

    public void addSheet(Sprite gameObject)
    {
        if(gameObject != null)
            sheets.Add(gameObject);
    }
}
