using UnityEngine;

public class ArtifactSpawnPoint : MonoBehaviour
{
    private Artifact _artifact;

    public bool IsEmpty
    {
        get
        {
            if (_artifact == null)
                return true;
            else if (_artifact.gameObject == null)
                return true;

            else
                return false;
        }
    }

    public void Occupy(Artifact artifact) => _artifact = artifact;

    public Vector3 Position => transform.position;
}
