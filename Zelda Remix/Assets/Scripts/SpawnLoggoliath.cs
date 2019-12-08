using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SpawnLoggoliath : MonoBehaviour
{
    public static int enemiesDefeated;
    public bool loggoliathSpawned;
    public bool loggitosSpawned;
    public AudioSource dingDong;

    public GameObject loggoliath;
    public GameObject loggito0;
    public GameObject loggito1;
    public GameObject loggito2;
    public GameObject loggito3;
    public GameObject loggito4;
    public GameObject loggito5;
    public GameObject loggito6;
    public GameObject loggito7;
    public GameObject loggito8;
    public GameObject loggito9;
    public GameObject loggito10;
    public GameObject loggito11;

    public GameObject loggoliathSpawnPoint;
    public GameObject loggitoSpawn0;
    public GameObject loggitoSpawn1;
    public GameObject loggitoSpawn2;
    public GameObject loggitoSpawn3;
    public GameObject loggitoSpawn4;
    public GameObject loggitoSpawn5;
    public GameObject loggitoSpawn6;
    public GameObject loggitoSpawn7;
    public GameObject loggitoSpawn8;
    public GameObject loggitoSpawn9;
    public GameObject loggitoSpawn10;
    public GameObject loggitoSpawn11;

    public GameObject breakableWall;

    // Start is called before the first frame update
    void Start()
    {
        enemiesDefeated = 0;
        loggoliathSpawned = false;
        loggitosSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemiesDefeated);
        if (enemiesDefeated == 6)
        {
            SetLoggoliathActive();
        }
        if (enemiesDefeated == 7)
        {
            SetLoggitosActive();
        }
        if (enemiesDefeated >= 19)
        {
            if (breakableWall.activeInHierarchy == true)
            {
                PlayDingDong();
            }
            breakableWall.SetActive(false);
        }
    }

    void PlayDingDong()
    {
        dingDong.Play();
    }

    private async void SetLoggoliathActive()
    {
        if (!loggoliathSpawned)
        {
            loggoliathSpawnPoint.SetActive(true);
            await Task.Delay(1000);
            loggoliathSpawnPoint.SetActive(false);
            loggoliathSpawned = true;
        }
        loggoliath.SetActive(true);
    }

    private async void SetLoggitosActive()
    {
        if (!loggitosSpawned)
        {
            loggitoSpawn0.SetActive(true);
            loggitoSpawn1.SetActive(true);
            loggitoSpawn2.SetActive(true);
            loggitoSpawn3.SetActive(true);
            loggitoSpawn4.SetActive(true);
            loggitoSpawn5.SetActive(true);
            loggitoSpawn6.SetActive(true);
            loggitoSpawn7.SetActive(true);
            loggitoSpawn8.SetActive(true);
            loggitoSpawn9.SetActive(true);
            loggitoSpawn10.SetActive(true);
            loggitoSpawn11.SetActive(true);
            await Task.Delay(1000);
            loggitoSpawn0.SetActive(false);
            loggitoSpawn1.SetActive(false);
            loggitoSpawn2.SetActive(false);
            loggitoSpawn3.SetActive(false);
            loggitoSpawn4.SetActive(false);
            loggitoSpawn5.SetActive(false);
            loggitoSpawn6.SetActive(false);
            loggitoSpawn7.SetActive(false);
            loggitoSpawn8.SetActive(false);
            loggitoSpawn9.SetActive(false);
            loggitoSpawn10.SetActive(false);
            loggitoSpawn11.SetActive(false);
            loggitosSpawned = true;
        }
        loggito0.SetActive(true);
        loggito1.SetActive(true);
        loggito2.SetActive(true);
        loggito3.SetActive(true);
        loggito4.SetActive(true);
        loggito5.SetActive(true);
        loggito6.SetActive(true);
        loggito7.SetActive(true);
        loggito8.SetActive(true);
        loggito9.SetActive(true);
        loggito10.SetActive(true);
        loggito11.SetActive(true);
    }
}
