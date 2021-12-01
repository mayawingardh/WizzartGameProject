using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TESTMouseOver : MonoBehaviour
{
    GameObject panelDialoguePopArt;

    private void Start()
    {
        panelDialoguePopArt = GameObject.FindGameObjectWithTag("PanelDialoguePopArt");
        panelDialoguePopArt.SetActive(false);
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse is over Pop Art");
        panelDialoguePopArt.SetActive(true);

    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is NOT over Pop Art");
        //panelDialoguePopArt.SetActive(false);
    }
}
