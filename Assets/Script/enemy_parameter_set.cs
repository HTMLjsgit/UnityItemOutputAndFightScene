using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_parameter_set : MonoBehaviour
{
    public static enemy_parameter_set set;
    EnemySetImage setimage;
    public int[] HP;
    public int[] power;
    public int[] defense;
    public Sprite[] enemy_image;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        set = this;
        setimage = EnemySetImage.enemy_image;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
