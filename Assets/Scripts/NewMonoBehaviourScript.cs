using UnityEngine;

public class ControlFisicas : MonoBehaviour
{
    void Start()
    {
        
        Physics.autoSimulation = false;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.Simulate(Time.fixedDeltaTime);
        }
    }
}