using UnityEngine;

[RequireComponent(typeof(ArtifactCollector))]
public class Hero : MonoBehaviour
{
    private const KeyCode ArtifactUseKeyCode = KeyCode.F;

    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [SerializeField, Range(1, 1000)] private float _rotationSpeed;
    [SerializeField, Range(1, 1000)] private float _movementSpeed;
    [SerializeField, Range(1, 1000)] private float _health;

    public float RotationSpeed
    {
        get => _rotationSpeed;
        set
        {
            if (value >= 0)
            {
                _rotationSpeed = value;
            }
        }
    }
    public float MovementSpeed
    {
        get => _movementSpeed;
        set
        {
            if (value >= 0)
            {
                _movementSpeed = value;
            }
        }
    }
    public float Health
    {
        get => _health;
        set
        {
            if (value >= 0)
            {
                _health = value;
            }
        }
    }

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
            Artifact artifact = _artifactCollector.GetArtifact();

            artifact.Use(this);
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
