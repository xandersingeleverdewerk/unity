using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int playtime = 0;
    private int seconds = 0;
    private int minutes = 0;
    private int hours = 0;
    private int days = 0;

    void Start()
    {
        StartCoroutine ("Playtimer");
    }
    
    private IEnumerator Playtime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = (playtime % 60);
            minutes = (playtime / 60) % 60;
            hours = (playtime / 3600) % 24;
            days = (playtime / 86400) % 365;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50,50, 400,50), "Playtime = " + days.ToString() + " Days" + hours.ToString() + " Hours" + minutes.ToString() + " Minutes" + seconds.ToString() + " seconds");
    }
}
