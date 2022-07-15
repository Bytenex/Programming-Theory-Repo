using UnityEngine;

abstract public class Vehicle : MonoBehaviour
{
    [SerializeField] protected float maxSpeed;
    // ENCAPSULATION
    [SerializeField] public float speed { get; private set; }
    [SerializeField] protected float turnSpeed;

    private void Update()
    {
        TurnVehicle();
        MoveVehicle();
    }

    protected abstract void MoveVehicle();
    protected abstract void TurnVehicle();
}
