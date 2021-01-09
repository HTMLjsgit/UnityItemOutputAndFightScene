using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Mouse_Invalid : MonoBehaviour
{
    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        Screen.lockCursor = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Cursor.lockState != CursorLockMode.Locked)
        {
            //OnClick();  //クリックされた時の処理
            return;
        }
    }

    void OnClick()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            return;  //lockStateがLockedだったら以後の処理をしない
        }
    }
}
