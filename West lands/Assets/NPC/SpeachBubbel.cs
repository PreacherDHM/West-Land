using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




[System.Serializable]
public struct SpeachBubbelDialog
{
    [System.Serializable]
    public struct SpeachBubbelDialogChoice
    {
        public string choice;
        public SpeachBubbelDialog Responce;
    }
    [TextArea]
    public string[] _dialog;
    
    public SpeachBubbelDialogChoice[] choices;
    
    
    
};


public class SpeachBubbel : MonoBehaviour
{
    [SerializeField] private Button choiceDialogButton;

    public int activeSelection;
    
    public SpeachBubbelDialog[] dialogs;
    
    public void Choice(int choiceID)
    {
        
    }

    public void Next()
    {

    }

}
