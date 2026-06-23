using System;
using UnityEngine;

public class Rat : MonoBehaviour, IInteractable {


    public static event EventHandler OnAnyDead;


    private HealthSystem healthSystem;


    private void Awake() {
        healthSystem = GetComponent<HealthSystem>();
    }

    private void Start() {
        healthSystem.OnDead += HealthSystem_OnDead;
    }

    private void HealthSystem_OnDead(object sender, EventArgs e) {
        Debug.Log("Killed Rat!");

        OnAnyDead?.Invoke(this, EventArgs.Empty);

        Destroy(gameObject);
    }

    public void Interact() {
        healthSystem.Damage(35);
    }


}