using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TESTScene : MonoBehaviour
{
    //GameObject panelDialoguePopArt;
    //GameObject panelDialogueSurreal;

    private void Start()
    {
        //panelDialoguePopArt = GameObject.FindGameObjectWithTag("PanelDialoguePopArt");
        //panelDialoguePopArt.SetActive(false);

        //panelDialogueSurreal = GameObject.FindGameObjectWithTag("PanelDialogueSurreal");
        //panelDialogueSurreal.SetActive(false);
    }

    // Prompts for Pop Art
    //public void DialoguePopArt()
    //{
    //    panelDialoguePopArt.SetActive(true);
    //}

    public void LoadRoomPopArt()
    {
        SceneManager.LoadScene("SceneRoomPopArt");
    }

    public void EnterLevelPopArt()
    {
        SceneManager.LoadScene("SceneLevelPopArt");
    }

    //public void CancelRoomPopArt()
    //{
    //    panelDialoguePopArt.SetActive(false);
    //}

    // Prompts for Surreal
    //public void DialogueSurreal()
    //{
    //    panelDialogueSurreal.SetActive(true);
    //}

    public void LoadRoomSurreal()
    {
        SceneManager.LoadScene("SceneRoomSurreal");
    }

    //public void CancelRoomSurreal()
    //{
    //    panelDialogueSurreal.SetActive(false);
    //}


}

//public int index;
//public int indexMax;
//[SerializeField] bool keyDown;

//void Update()
//{
//    int choice = (int)Input.GetAxis("Horizontal");

//    if (choice != 0)
//    {
//        if (!keyDown)
//        {
//            if (choice < 0)
//            {
//                if (index < indexMax)
//                {
//                    index++;
//                }
//                else
//                {
//                    index = 0;
//                }
//            }
//            else if (choice > 0)
//            {
//                if (index > 0)
//                {
//                    index--;
//                }
//                else
//                {
//                    index = indexMax;
//                }
//            }

//            keyDown = true;
//        }
//    }
//    else
//    {
//        keyDown = false;
//    }
//}