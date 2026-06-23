using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {


    [SerializeField] private HealthSystem healthSystem;
    [SerializeField] private Image barImage;


    private void Start() {
        healthSystem.OnHealthAmountChanged += HealthSystem_OnHealthAmountChanged;
        barImage.fillAmount = healthSystem.GetHealthAmountNormalized();

        Hide();
    }

    private void HealthSystem_OnHealthAmountChanged(object sender, System.EventArgs e) {
        barImage.fillAmount = healthSystem.GetHealthAmountNormalized();

        Show();
    }

    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }

}