using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

public class VB : MonoBehaviour
{

    public static string order="";
    
     GameObject vbBtn1Object; //первая кнопка ЗЕЛЕНАЯ
     GameObject vbBtn2Object; //вторая кнопка КРАСНАЯ
     GameObject vbBtn3Object;// третья кнопка ЖЕЛТАЯ

    public Animator animObject;

    void Start()
    {
        vbBtn1Object = GameObject.Find("VirtualButton1");
        vbBtn2Object = GameObject.Find("VirtualButton2");
        vbBtn3Object = GameObject.Find("VirtualButton3");

        vbBtn1Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn1Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton1Pressed);

        vbBtn2Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn2Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton2Pressed);

        vbBtn3Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn3Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton3Pressed);

        animObject.GetComponent<Animator>();
    }

    public void OnButton1Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("kick");
        order += "1";
    }

    public void OnButton2Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("BAM");
        order += "2";
    }
    public void OnButton3Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("sliceunder");
        order += "3";
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       if (Game.hasLost==true)
        {
            animObject.Play("falling");
            order = "";
        }
        if (Game.hasWon == true)
        {
            order = "";
        }
    }

}
