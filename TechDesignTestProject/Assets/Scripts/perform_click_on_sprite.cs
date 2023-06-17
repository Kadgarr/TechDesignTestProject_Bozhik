using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class perform_click_on_sprite : MonoBehaviour
{

    [SerializeField]
    private Button buttonSwitchScene = null;

    private void OnMouseDown()
    {
     
        if (buttonSwitchScene != null)
            buttonSwitchScene.onClick.Invoke();

    }
}
