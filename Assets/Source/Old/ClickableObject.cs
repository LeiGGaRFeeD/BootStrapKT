using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] GameObject SCtwo;
    ScreenTime SC = new ScreenTime();
    [SerializeField] private float multiplyer;
    private void OnMouseDown()
    {
        PlayerPrefs.SetFloat("score", PlayerPrefs.GetFloat("score")+multiplyer);
       // SC.Texting();
        SCtwo.GetComponent<ScreenTime>().Texting();
 //       Debug.Log("is "+ PlayerPrefs.GetFloat("score".ToString());
    }
}
