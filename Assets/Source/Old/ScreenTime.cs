using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTime : MonoBehaviour
{
    [SerializeField] public Text _text;
    private bool _started = false;
    void LetsStart()
    {

    }
    public void StartIsTrue()
    {
        _started = true;
    }
    public void Texting() 
    {
        Debug.Log("Texting is started");
        if (_started == true)
        {
       //     gameObject.GetComponent<Text>() = "Score: " + PlayerPrefs.GetFloat("score").ToString();
            _text = gameObject.GetComponent<Text>();
            _text.text = "Score: " + PlayerPrefs.GetFloat("score").ToString();
            //     gameObject.Text = "Score: " + PlayerPrefs.GetFloat("score").ToString();
        }
    }
}
