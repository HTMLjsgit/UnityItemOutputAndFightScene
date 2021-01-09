using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class ItemDataBase : MonoBehaviour
{
    public List<ItemList> items = new List<ItemList>();
    public static ItemDataBase item_base;
    public GameObject itemPrefab;
    public GameObject Canvas;
    public GameObject center_prefab;
    int x = 0;
    int y = 0;
    int currentPage = 0;
    public int max_count;
    public static ItemDataBase Instance
    {
        get; private set;
    }
    private void Awake()
    {
        item_base = this;
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
    }

    public void ItemAdd(int HPIn,int MPIn,string item_name,string name, int id, string desc, int power, int def, int speed, int ls, ItemList.ElementType etype, ItemList.ItemType type, Sprite image)
    {
        if (currentPage < 1 && items.Count < max_count)
        {
            items.Add(new ItemList(HPIn, MPIn, item_name, name, id, desc, power, def, speed, ls, etype, type, image));
            ItemPrefabCreate();
            //itemPrefab.transform.GetChild(1).GetComponent<Text>().text = items[items.Count - 1].itemName;

        }
    }

    public void ItemPrefabCreate()
    {

                GameObject g = Instantiate(itemPrefab, new Vector2(1, 1) , Quaternion.identity, Canvas.transform);
                
                foreach (ItemList item in items)
                {
                    
                    //g.GetComponent<Image>().material.mainTexture = Resources.Load<Texture2D>("icons/" + item.item_name);
                    if(item.image != null)
                    {
                        //g.GetComponent<Image>().sprite = Sprite.Create(item.itemIcon, new Rect(0, 0, item.itemIcon.width, item.itemIcon.height), Vector2.zero);
                        g.GetComponent<Image>().sprite = item.image;
                    }
                    if(item.itemPower <= 0 && item.itemType == ItemList.ItemType.Weapon)
                    {
                        item.itemPower = 10;
                    }
                    g.GetComponent<ItemIconClickScript>().item = item;

            //Debug.Log(g.GetComponent<Image>().sprite);
            //g.GetComponent<Image>().sprite = item.itemIcon.sprite;
        }

    }
    public Vector2 GetCenterPosition(RectTransform rect)
    {
        var position = rect.transform.position;

        if(rect.pivot != new Vector2(0.5f, 0.5f))
        {
            var scaleX = rect.transform.lossyScale.x;
            var scaleY = rect.transform.lossyScale.y;
            var x = rect.rect.width / 2f * scaleX;
            var y = rect.rect.height / 2f * scaleY;
            position.x += Mathf.Lerp(x, -x, rect.pivot.x);
            position.y += Mathf.Lerp(y, -y, rect.pivot.y);
        }

        return position;
    }
}
