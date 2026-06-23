using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable {

    [SerializeField] private NPCScriptableObjectScript npcData;
    [SerializeField] private GameObject npcTextBubble;
    private QuestInteractionUI questUIControls;
    private List<string> currentQuestList;
    private int currentListIndex= 0;
    private void Start()
    {
        //get all of the npc string/quest
        currentQuestList = npcData.getQuestStrings();
        questUIControls = npcTextBubble.GetComponent<QuestInteractionUI>();
    }

    public void Interact() {
        //later check if the list is done first then have the interaction ui to disapear
        if(currentListIndex >= currentQuestList.Count)
        {
            questUIControls.SetVisibilityFalse();
            currentListIndex = 0;
            return;
        }


        if (!questUIControls.getisVisible())
        {
            questUIControls.SetVisibilitytrue();
        }
        
        Debug.Log("Talking with NPC " + transform);
        questUIControls.NewText(currentQuestList[currentListIndex]);
        currentListIndex++;
    }


}