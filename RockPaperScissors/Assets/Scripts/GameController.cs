using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Sprite[] images = null;
    [SerializeField] private GameObject playerImageObject = null;
    [SerializeField] private GameObject cpuImageObject = null;
    private Dictionary<int, Choice> choices = new Dictionary<int, Choice>();
    private Dictionary<Choice, Choice> whatLosesAgainst = new Dictionary<Choice, Choice>();
    private Choice currChoice; 
    private int currImageIndex = 0;
    private int cpuChoiceIndex = 0;
    private bool isPlaying = false;
    private void Start()
    {
        playerImageObject.GetComponent<Image>().sprite = images[currImageIndex];
        currChoice = currChoice = Choice.Paper;
        choices.Add(0, Choice.Paper);
        choices.Add(1, Choice.Rock);
        choices.Add(2, Choice.Scissors);

        whatLosesAgainst.Add(Choice.Rock, Choice.Scissors);
        whatLosesAgainst.Add(Choice.Paper, Choice.Rock);
        whatLosesAgainst.Add(Choice.Scissors, Choice.Paper);
    }

    public void OnSelectionLeft(){
        currImageIndex--;
        if(currImageIndex < 0){
            currImageIndex = images.Length - 1;
        }
        SetImageAndChoice();
    }

    public void OnSelectionRight()
    {
        currImageIndex++;
        if (currImageIndex == images.Length)
        {
            currImageIndex = 0;
        }
        SetImageAndChoice();
    }

    public void OnPlay()
    {
        if(!isPlaying)
        {
            isPlaying = true;
            Choice cpuChoice = GetCPUChoice();
            StartCoroutine(CycleCPUChoices(CheckResults, cpuChoice));
        }
    }

    private IEnumerator CycleCPUChoices(Action<Choice> callback, Choice cpuChoice)
    {
        IncrementCPUChoice();
        yield return new WaitForSeconds(.5f);
        IncrementCPUChoice();
        yield return new WaitForSeconds(.5f);
        IncrementCPUChoice();
        yield return new WaitForSeconds(.5f);
        callback(cpuChoice);
    }

    private void IncrementCPUChoice()
    {
        cpuChoiceIndex++;
        if (cpuChoiceIndex == images.Length) cpuChoiceIndex = 0;
        cpuImageObject.GetComponent<Image>().sprite = images[cpuChoiceIndex];
    }

    private Choice GetCPUChoice()
    {
        cpuChoiceIndex = UnityEngine.Random.Range(0, choices.Count);
        cpuImageObject.GetComponent<Image>().sprite = images[cpuChoiceIndex];
        Choice cpuChoice = choices[cpuChoiceIndex];
        return cpuChoice;
    }

    private void CheckResults(Choice cpuChoice)
    {
        if (cpuChoice == currChoice)
        {
            Debug.Log("Tied");
        }
        else if (cpuChoice == whatLosesAgainst[currChoice])
        {
            Debug.Log("You won!");
        }
        else
        {
            Debug.Log("You lost");
        }
        isPlaying = false;
    }

    private void SetImageAndChoice()
    {
        currChoice = choices[currImageIndex];
        playerImageObject.GetComponent<Image>().sprite = images[currImageIndex];
    }
}
