using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StealScript : MonoBehaviour
{
    public static event Action<bool> Steal;
    private bool canSteal;
    public GameObject prompt;
    private void Update()
    {
        if (gameObject.GetComponent<Movement>().isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.E) && canSteal)
            {
                Steal.Invoke(true);
                Debug.Log("InvokedSteal");
            }
        }
    }//invokes steal if this player is active and e is pressed
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Thief"))
        {
            prompt.SetActive(true);
            canSteal = true;
        }//sets the interaction prompt upon being able to steal.
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Thief"))
        {
            prompt.SetActive(false);
            canSteal = false;
        }
    }//removes interaction prompt when leaving trigger.
}