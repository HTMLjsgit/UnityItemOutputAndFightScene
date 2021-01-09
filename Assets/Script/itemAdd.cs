using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemAdd : MonoBehaviour
{
    public int HPIn;
    public int MPIn;
    public string item_sprite_name;
    public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public int itemPower;
    public int itemDefense;
    public int itemAttackSpeed;
    public int itemLifeSteal;
    public ItemList.ElementType elemenType;
    public ItemList.ItemType itemType;
    ItemDataBase itemdata;
    public static itemAdd itemadd;
    private bool col_item_add = false;
    public Sprite image;
    public KeyCode enter;
    // Start is called before the first frame update
    void Start()
    {
        itemdata = ItemDataBase.item_base;
    }

    private void Awake()
    {
        itemadd = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (col_item_add)
        {
            if (Input.GetKeyDown(enter))
            {
                Add();

            }
        }
    }

    public void Add()
    {
        itemdata.ItemAdd(HPIn, MPIn,item_sprite_name,itemName, itemID, itemDesc, itemPower, itemDefense, itemAttackSpeed, itemLifeSteal, elemenType, itemType, image);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            col_item_add = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            col_item_add = false;
        }
    }
}
