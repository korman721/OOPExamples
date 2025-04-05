using UnityEngine;

public class ArtifactCollector : MonoBehaviour
{
    [SerializeField] private Transform _pickUpPoint;

    private Artifact _artifact;

    private Vector3 _pickUpScale = new Vector3(0.45f, 0.45f, 0.45f);

    public bool IsPicked { get; private set; } = false;

    private void OnTriggerEnter(Collider other)
    {
        if (IsPicked == false)
        {
            _artifact = other.GetComponent<Artifact>();

            if (_artifact != null)
            {
                PickUp();

                IsPicked = true;
            }
        }
    }

    private void PickUp()
    {
        _artifact.transform.position = _pickUpPoint.position;
        _artifact.transform.localScale = _pickUpScale;
        _artifact.transform.SetParent(_pickUpPoint.transform);
    }

    private void Update()
    {
        if (_artifact == null)
            IsPicked = false;
    }

    public Artifact GetArtifact() => _artifact;
}
