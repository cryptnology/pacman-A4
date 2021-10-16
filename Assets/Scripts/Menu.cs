using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    float timer = 0.0f;
    float currentIntTimer = 0.0f;
    public Image[] border;

    public bool levelText1 = true;

    public Text level1;
    public Text level2;
    public Text levelSelector;

    void Update()
    {
        timer += Time.deltaTime;
        currentIntTimer = (float)System.Math.Round(timer, 1);

        if (currentIntTimer == 1.0)
        {
            border[0].enabled = true;
            border[1].enabled = false;
            border[2].enabled = true;
            border[3].enabled = false;
            border[4].enabled = true;
            border[5].enabled = false;
            border[6].enabled = true;
            border[7].enabled = false;
            border[8].enabled = true;
            border[9].enabled = false;
        }
        if (currentIntTimer == 2.0)
        {
            border[0].enabled = false;
            border[1].enabled = true;
            border[2].enabled = false;
            border[3].enabled = true;
            border[4].enabled = false;
            border[5].enabled = true;
            border[6].enabled = false;
            border[7].enabled = true;
            border[8].enabled = false;
            border[9].enabled = true;
            timer = 0;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (!levelText1)
            {
                levelText1 = true;
                levelSelector.transform.localPosition = new Vector3(levelSelector.transform.localPosition.x, level1.transform.localPosition.y, levelSelector.transform.localPosition.z);
            }
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (levelText1)
            {
                levelText1 = false;
                levelSelector.transform.localPosition = new Vector3(levelSelector.transform.localPosition.x, level2.transform.localPosition.y, levelSelector.transform.localPosition.z);
            }
        }
        else if (Input.GetKeyUp(KeyCode.Return) && levelText1)
        {
            SceneManager.LoadScene("Level_1");
        }
    }
}
