using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoryTransformScript : MonoBehaviour
{
    private bool created = false;
    public static DontDestoryTransformScript Instance
    {
        get; private set;
    }
    // Start is called before the first frame update

    void Start()
    {

    }


    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
