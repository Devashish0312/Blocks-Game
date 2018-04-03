using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnCollisionEnter()
    {
        Debug.Log("LEVEL WON>>!!");
        gameManager.CompleteLevel();
    }
}
