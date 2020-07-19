using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthContainer : MonoBehaviour
{
    public static string[] initiativeId = new string[12];
    public static string[] description = new string[12];
    public static string[] category = new string[12];
    public static Texture2D[] imageRaw = new Texture2D[12];
    //public static GrowthContainer instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //    else if (instance != this)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //private void Start()
    //{
    //    DontDestroyOnLoad(this);
    //}
}
