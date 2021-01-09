using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemDisplayScript : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Button ItemButton;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = ItemImageGetScript.item_image_script.gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemDisplay()
    {
        anim.SetBool("move", true);
        button.Select();
    }
    public void ItemUnDisplay()
    {
        anim.SetBool("move", false);
        ItemButton.Select();

    }
}
