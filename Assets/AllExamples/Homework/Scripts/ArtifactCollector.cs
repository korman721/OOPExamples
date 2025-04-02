using UnityEngine;

public class ArtifactCollector : MonoBehaviour
{
    [SerializeField] private Transform _pickUpPoint;

    public Artifact Artifact { get; set; }

    public bool IsPicked { get; set; } = false;

    private void OnTriggerEnter(Collider other)
    {
        if (IsPicked == false)
        {
            Artifact = other.GetComponent<Artifact>();

            if (Artifact != null )
            {
                Artifact.PickUp(_pickUpPoint);

                IsPicked = true;
            }
        }
    }
}
