using UnityEngine;

public class FlashLight : MonoBehaviour, IInteractable
{
    [SerializeField] private Light _pointLight;

    public void Interact()
    {
        _pointLight.enabled = !_pointLight.enabled;
    }
}
