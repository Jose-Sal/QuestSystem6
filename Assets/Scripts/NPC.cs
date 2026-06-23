using UnityEngine;

public class NPC : MonoBehaviour, IInteractable {

    [SerializeField] private NPCScriptableObjectScript npcData;
    public void Interact() {
        Debug.Log("Talking with NPC " + transform);
        Debug.Log(npcData.getQuestStrings()[0]);
    }


}