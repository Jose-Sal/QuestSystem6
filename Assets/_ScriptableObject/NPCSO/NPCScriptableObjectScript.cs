using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCScriptableObjectScript", menuName = "Scriptable Objects/NPCScriptableObjectScript")]
public class NPCScriptableObjectScript : ScriptableObject
{
    [SerializeField]private List<string> questStrings;
    [SerializeField] private Quest quest;

    public List<string> getQuestStrings()
    {
        return questStrings;
    }

    public Quest GetQuest()
    {
        return quest;
    }
    
}
