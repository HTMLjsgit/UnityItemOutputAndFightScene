using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemList
{
    public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public int itemPower;
    public int itemDefense;
    public int itemAttackSpeed;
    public int itemLifeSteal;
    public ElementType elemenType;
    public ItemType itemType;
    public string item_sprite_name;
    public int HPIncrease;
    public int MPIncrease;
    public Sprite image;
    public enum ElementType
    {
        Non,
        FIre,
        Ice,
        Lightning,
    }

    public enum ItemType
    {
        Weapon,
        Consumable,
        Quest,
        Defense
    }

    public ItemList(int HPIn,int MPIn,string item_name_go,string name, int id, string desc, int power, int def, int speed, int ls, ElementType etype, ItemType type, Sprite sprite)
    {
        HPIncrease = HPIn;
        MPIncrease = MPIn;
        itemName = name;
        itemID = id;
        itemIcon = Resources.Load<Texture2D>("icons/" + item_name_go);
        item_sprite_name = item_name_go;
        itemDesc = desc;
        itemPower = power;
        itemDefense = def;
        itemAttackSpeed = speed;
        itemLifeSteal = ls;
        elemenType = etype;
        itemType = type;
        image = sprite;
    }

}
