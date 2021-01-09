using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck : MonoBehaviour
{
    ItemDataBase item_base;
    // Start is called before the first frame update
    void Start()
    {
        item_base = ItemDataBase.item_base;
    }

    // Update is called once per frame
    void Update()
    {
            foreach(ItemList item in item_base.items)
            {
                Debug.Log(item.itemName);
            }
    }
}
