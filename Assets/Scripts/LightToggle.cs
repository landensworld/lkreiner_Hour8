using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    public Light targetLight; 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            
            targetLight.enabled = !targetLight.enabled;
        }
    }
}