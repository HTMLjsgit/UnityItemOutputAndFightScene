using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform trans in this.gameObject.transform)
        {
            DontDestroyOnLoad(trans.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
