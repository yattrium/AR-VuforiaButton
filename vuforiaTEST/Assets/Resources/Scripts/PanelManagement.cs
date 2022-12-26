using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManagement : MonoBehaviour
{
    public GameObject Panel;
    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
    public void OpenPanel()
    {
        Panel.SetActive(true);
    }
    
    
}
