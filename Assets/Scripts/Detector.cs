using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField]private bool isSeen = false;
    [SerializeField] private GameObject stealObject;
    [SerializeField] private GameObject stopText;
    [SerializeField] private GameObject winScreen;
    private void OnEnable()
    {
        StealScript.Steal += StealCheck;
    }
    private void OnDisable()
    {
        StealScript.Steal -= StealCheck;
    }
    private void StealCheck(bool check)
    {
        if (isSeen == true)
        {
            Debug.Log("SEEN");
            stopText.SetActive(true);
        }//warns player if they are seen.
        else
        {
            stealObject.SetActive(false);
            winScreen.SetActive(true);
        }//if you try to steal, checks if the detection cone can see the object or the thief which both have the "thief" tag.
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Thief"))
        {
            isSeen = true;
        }//if the object in the collision has the "thief" tag, it is marked as "seen"
        else
        {
            isSeen = false;
        }
    }
}