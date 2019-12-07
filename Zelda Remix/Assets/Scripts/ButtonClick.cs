using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public FloatValue currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
        currentHealth.OnAfterDeserialize();
        Time.timeScale = 1;
    }
}
