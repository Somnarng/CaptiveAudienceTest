using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    private GameObject currentPlayer;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    private void OnEnable()
    {
        currentPlayer = player1;
    }

    void Update()
    {
        if (currentPlayer == player1)
        {
            player1.GetComponent<Movement>().enabled = true;
            player2.GetComponent<Movement>().enabled = false;
        }
        else
        {
            player1.GetComponent<Movement>().enabled = false;
            player2.GetComponent<Movement>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }
        }
    }
}//switches player on space press, disables other players movement.