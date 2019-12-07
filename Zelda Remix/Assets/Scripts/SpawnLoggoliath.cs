using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLoggoliath : MonoBehaviour
{
    public static int enemiesDefeated;
    public GameObject loggoliath;

    // Start is called before the first frame update
    void Start()
    {
        enemiesDefeated = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemiesDefeated);
        if (enemiesDefeated == 6)
        {
            loggoliath.SetActive(true);
        }
    }
}
