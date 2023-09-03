using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Captivate : MonoBehaviour
{
    public static event Action<bool> CaptivateStart;
    void Update()
    {
        if (gameObject.GetComponent<Movement>().isActiveAndEnabled)
        {
            if (Input.GetKey(KeyCode.E))
            {
                CaptivateStart.Invoke(true);
            }
        }//captivates if this player is active.
    }
}
