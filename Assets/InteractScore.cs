using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractScore : MonoBehaviour
{
    public Text scoreText;
    public int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("interactable"))
        {
            count++;
            scoreText.text = "Score : " + count;
        }
    }
}
