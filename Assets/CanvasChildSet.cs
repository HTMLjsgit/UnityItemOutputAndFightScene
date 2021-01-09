using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasChildSet : MonoBehaviour
{
    public static CanvasChildSet canvas_get;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        canvas_get = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
