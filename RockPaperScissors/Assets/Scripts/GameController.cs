using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private int[] images = null;
    [SerializeField] private GameObject playerImageObject = null;
    [SerializeField] private GameObject cpuImageObject = null;
    private int count = 0;
    private int currImageIndex = 0;
    public void OnCount()
    {
        count++;
        Debug.Log($"Count: {count}");
    }

    public void OnSelectionUp(){
        currImageIndex--
        if(currImageIndex < 0){
            currImageIndex = images.length - 1;
        }
        playerImageObject.GetComponent<Image>() = images[currImageIndex];
    }

    public void OnSelectionDown(){
        currImageIndex++;
        if(currImageIndex == currImageIndex.index){
            currImageIndex = 0;
        }
        playerImageObject.GetComponent<Image>() = images[currImageIndex];
    }
    
}
