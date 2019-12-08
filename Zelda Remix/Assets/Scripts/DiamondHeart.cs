using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondHeart : MonoBehaviour
{
    public GameObject winText;
    public GameObject restartButton;
    public AudioSource winSound;
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            music.Pause();
            winSound.Play();
            this.gameObject.SetActive(false);
            winText.SetActive(true);
            restartButton.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
