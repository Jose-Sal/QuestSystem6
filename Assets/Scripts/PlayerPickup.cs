using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPickup : MonoBehaviour {


    public static PlayerPickup Instance { get; private set; }


    public event EventHandler OnDroppedObject;
    public event EventHandler OnPickedUpObject;



    [SerializeField] private Transform carryingObjectHoldPoint;


    private ICarryable carryingCarryableObject;
    private ICarryable canPickupCarryable;


    private void Awake() {
        Instance = this;
    }

    private void Update() {
        HandleCanPickupObject();

        if (Keyboard.current.eKey.wasPressedThisFrame) {
            if (carryingCarryableObject == null) {
                // Not carrying anything, pick up
                if (canPickupCarryable != null) {
                    canPickupCarryable.GetTransform().GetComponent<Rigidbody>().isKinematic = true;
                    canPickupCarryable.GetTransform().parent = carryingObjectHoldPoint;
                    canPickupCarryable.GetTransform().localPosition = Vector3.zero;
                    carryingCarryableObject = canPickupCarryable;

                    Debug.Log("Picked up " + carryingCarryableObject);
                    OnPickedUpObject?.Invoke(this, EventArgs.Empty);
                }
            } else {
                // Carrying something, drop it
                Debug.Log("Dropped " + carryingCarryableObject);

                carryingCarryableObject.GetTransform().GetComponent<Rigidbody>().isKinematic = false;
                carryingCarryableObject.GetTransform().parent = null;
                carryingCarryableObject = null;

                OnDroppedObject?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public void HandleCanPickupObject() {
        canPickupCarryable = null;

        float pickupDistance = 3f;
        RaycastHit[] raycastHitArray = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, pickupDistance);
        foreach (RaycastHit raycastHit in raycastHitArray) {
            if (raycastHit.transform.TryGetComponent(out ICarryable carryable)) {
                canPickupCarryable = carryable;
                break;
            }
        }
    }

    public ICarryable GetCanPickupCarryable() {
        return canPickupCarryable;
    }

    public ICarryable GetCarryingCarryableObject() {
        return carryingCarryableObject;
    }

}