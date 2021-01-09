using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpriteSet : MonoBehaviour
{
    [SerializeField] Texture2D image;
    // Start is called before the first frame update
    void Start()
    {
        Texture2D box_image = Resources.Load<Texture2D>("icons/pipo-WindowBaseSet2a_01");
        GetComponent<Image>().sprite = Sprite.Create(box_image, new Rect(0, 0, box_image.width, box_image.height), Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
