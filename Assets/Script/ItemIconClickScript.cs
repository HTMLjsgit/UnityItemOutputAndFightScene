using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemIconClickScript : MonoBehaviour
{
    private Animator anim;
    public ItemList item;
    private ItemDataBase itemdata;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        itemdata = ItemDataBase.item_base;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnItemClick()
    {
            if (item.itemType == ItemList.ItemType.Consumable)
            {
                playerStatus.player_status.HPIncrease(item.HPIncrease, this.gameObject, item);
                playerStatus.player_status.MPIncrease(item.MPIncrease, this.gameObject, item);
            }
            else if (item.itemType == ItemList.ItemType.Weapon)
            {
                playerStatus.player_status.playerGear(item.itemPower, item.itemDefense);
            }else if(item.itemType == ItemList.ItemType.Defense)
            {
                playerStatus.player_status.playerGear(item.itemPower, item.itemDefense);
            }
            else if (item.itemType == ItemList.ItemType.Quest)
            {
                playerStatus.player_status.playerGear(item.itemPower, item.itemDefense);
            }

    }
}
