using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player_colider : MonoBehaviour
{
    private bool col = false;
    private bool col_item = false;
    public KeyCode enter;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (col)
        {
            if (Input.GetKeyDown(enter))
            {
                SceneManager.LoadScene("fight_scene");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            col = true;
        }else if(collision.gameObject.tag == "item")
        {
            col_item = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            col = false;
        }else if(collision.gameObject.tag == "item")
        {
            col_item = false;
        }
    }
}
