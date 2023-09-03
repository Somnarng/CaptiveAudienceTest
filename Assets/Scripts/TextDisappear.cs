using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisappear : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Count());
    }
    IEnumerator Count()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }//disables warning text after 2 seconds.
}
