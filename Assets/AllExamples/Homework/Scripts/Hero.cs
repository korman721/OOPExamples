using UnityEngine;

[RequireComponent(typeof(ArtifactCollector))]
public class Hero : MonoBehaviour
{
    private const KeyCode ArtifactUseKeyCode = KeyCode.F;

    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [field: SerializeField] public float RotationSpeed { get; set; }
    [field: SerializeField] public float MovementSpeed { get; set; }
    [field: SerializeField] public float Health { get; set; }

    private ArtifactCollector _artifactCollector;
    private Mover _mover;
    private Rotator _rotator;
    private Rigidbody _rigidbody;

    private float _xInput;
    private float _zInput;

    private float _deadZone = 0.05f;

    private void Awake()
    {
        _mover = new Mover();
        _rotator = new Rotator();

        _rigidbody = GetComponent<Rigidbody>();
        _artifactCollector = GetComponent<ArtifactCollector>();
    }

    private void Update()
    {
        _xInput = Input.GetAxisRaw(HorizontalAxis);
        _zInput = Input.GetAxisRaw(VerticalAxis);

        if (Input.GetKeyDown(ArtifactUseKeyCode) && _artifactCollector.IsPicked)
        {
            _artifactCollector.Artifact.Use(this);

            _artifactCollector.IsPicked = false;
        }
    }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(_xInput, 0, _zInput);

        if (input.magnitude <= _deadZone)
            return;

        Vector3 normalized = input.normalized;

        _mover.ProcessMoveTo(normalized, _rigidbody, MovementSpeed);

        _rotator.ProcessRotateTo(normalized, transform, RotationSpeed);
    }
}
