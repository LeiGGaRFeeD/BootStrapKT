using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
   //  ScreenTime M = new ScreenTime();
    [SerializeField] GameObject SCtwo;
    void Awake()
    {
        //     M.StartIsTrue();
        SCtwo.GetComponent<ScreenTime>().StartIsTrue();
    }
}
