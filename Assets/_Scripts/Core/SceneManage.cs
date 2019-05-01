using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    public Transform viveCtrlLeft;
    public Transform viveCtrlRight;

    public static Transform getViveCtrlRight;
    public static string currentScene = "Menu 0";
    public static int loadTestScene = -2;
    private int bCount = 0;
    private int menuCount = 0;

    void Start()
    {
        viveCtrlLeft.gameObject.SetActive(false);
        viveCtrlRight.gameObject.SetActive(false);
    }

    void Update()
    {
        getViveCtrlRight = viveCtrlRight;
    }

    public void SetBaking()
    {
        bCount++;
        currentScene = "Bageplade " + bCount;
        loadTestScene = 2;
    }

    public void SetMenu()
    {
        menuCount++;
        currentScene = "Menu " + menuCount;
        loadTestScene = 0;
    }
}
