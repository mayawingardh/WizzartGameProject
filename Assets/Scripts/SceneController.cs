using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Scene changes from Ateljén
        //if(other.CompareTag("TriggerRoomPopArt"))
        //{
        //    SceneManager.LoadScene("SceneRoomPopArt");
        //}

        //if(other.CompareTag("TriggerRoomSurreal"))
        //{
        //    SceneManager.LoadScene("SceneRoomSurreal");
        //}

        //if(other.CompareTag("TriggerRoomWaterColour"))
        //{
        //    SceneManager.LoadScene("SceneRoomWaterColour");
        //}

        // Scene change from RoomPopArt
        //if(other.CompareTag("TriggerLevelPopArt"))
        //{
        //    SceneManager.LoadScene("SceneLevelPopArt");
        //}

        if(other.CompareTag("TriggerAteljen"))
        {
            
            SceneManager.LoadScene("SceneAteljen");
        }


        // Scene change from RoomSurreal
        //if(other.CompareTag("TriggerLevelSurreal"))
        //{
        //    SceneManager.LoadScene("SceneLevelSurreal");
        //}

        //if(other.CompareTag("TriggerAteljen"))
        //{
        //    SceneManager.LoadScene("SceneAteljen");
        //}

        //// Scene change from RoomWaterColour
        //if(other.CompareTag("TriggerLevelWaterColour"))
        //{
        //    SceneManager.LoadScene("SceneLevelWaterColour");
        //}

        //if(other.CompareTag("TriggerAteljen"))
        //{
        //    SceneManager.LoadScene("SceneAteljen");
        //}
    }
}
