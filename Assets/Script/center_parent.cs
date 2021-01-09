using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center_parent : MonoBehaviour
{
    public static center_parent center_pare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        center_pare = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
