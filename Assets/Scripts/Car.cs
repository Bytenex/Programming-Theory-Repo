using UnityEngine;

// INHERITANCE
public class Car : Vehicle
{
    // POLYMORPHISM
    protected override void MoveVehicle()
    {
        transform.Translate(Vector3.forward * maxSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
    }

    // POLYMORPHISM
    protected override void TurnVehicle()
    {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
