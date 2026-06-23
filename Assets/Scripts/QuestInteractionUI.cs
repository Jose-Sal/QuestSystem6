using TMPro;
using UnityEngine;

public class QuestInteractionUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI npcText;
    private bool isVisible;
    private void Start()
    {

    }

    public void SetVisibilitytrue()
    {
        isVisible = true;
        gameObject.SetActive(isVisible);
    }
    public void SetVisibilityFalse()
    {
        isVisible = false;
        gameObject.SetActive(isVisible);
    }

    public void NewText(string visualString)
    {
        npcText.text = visualString;
    }

    public bool getisVisible()
    {
        return isVisible;
    }
}
