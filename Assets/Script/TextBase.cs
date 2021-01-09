using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBase : MonoBehaviour
{
    ItemDataBase item;
    // Start is called before the first frame update
    void Start()
    {
        item = ItemDataBase.item_base;
        GetComponent<Text>().text = item.items[item.items.Count -1].itemName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
