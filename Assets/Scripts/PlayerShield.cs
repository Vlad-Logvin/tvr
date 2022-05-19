using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    private HealthScript healthScript;

    void Awake()
    {
        healthScript = GetComponent<HealthScript>();
    }

    public void ActiveShield(bool shieldActive)
    {
        healthScript.shieldActivated = shieldActive;
    }
}