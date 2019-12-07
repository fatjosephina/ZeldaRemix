using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondHeart : MonoBehaviour
{
    public GameObject winText;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            winText.SetActive(true);
            restartButton.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
