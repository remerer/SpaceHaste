using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCameraController : MonoBehaviour
{

    [SerializeField] private Camera m_Camera;

    [SerializeField] private Transform playerTransform;
    [SerializeField] private Quaternion playerQuaternion;

    private float _rotationX;
    private float _rotationY;
    private float _rotationZ;
    private float _rotationW;

    //Position Variables
    private Vector3 _cameraTargetPos;
    private Vector3 _playerForward;
    private Vector3 _playerUp;
    private Vector3 _playerRight;

    [Space]
    //Inspector Edit
    [SerializeField] private Vector3 cameraOffset;
    [SerializeField] private Quaternion cameraRotationOffset;
    [SerializeField] private float cameraPositionTension = 10;
    [SerializeField] private float cameraRotationTension = 10;

    //TEMP: Show Inspector
    //[SerializeField] private Quaternion cameraRotationReal;
    //[SerializeField] private Vector3 cameraPositionReal;
    //[SerializeField] private Vector3 playerPositionNow;
    //[SerializeField] private Vector3 cameraPositionNow;

    private float _cameraX;
    private float _cameraY;
    private float _cameraZ;

    [SerializeField] private Vector3 TransformPoint;
    [SerializeField] private Vector3 InverseTransformPoint;


    [SerializeField] private float cameraDistance;

    //Camera Booster Movement Variable
    private Booster booster;
    private float _shakeX = 0f;
    private float _shakeY = 0f;
    [SerializeField] private float _shakeMagnitude = 0.1f;

    //Camera Gimbal Movement Variable
    public SpaceshipController spaceshipController;
    public RectTransform cursorRectTransform;
    private Vector3 _screenCenter = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0f), _mouseDistance;
    private float _gimbalX = 0f;
    private float _gimbalY = 0f;
    [Range(0f, 20f)] public float gimbalX_Intensity;
    [Range(0f, 5f)] public float gimbalY_Intensity;

    void Start()
    {
        //Common
        gimbalX_Intensity = 3f;
        gimbalY_Intensity = 1f;

        //CameraControlMovement
        m_Camera = GetComponent<Camera>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //CameraBoosterMovement
        booster = GameObject.FindGameObjectWithTag("Player").GetComponent<Booster>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraGimbalMovement();
        CameraControlMovement();
        CameraBoosterMovement();

        m_Camera.transform.position = InverseTransformPoint;

        //TODO: Delete
        //m_Camera.transform.position = new Vector3(_cameraX + _shakeX + _gimbalX, _cameraY + _shakeY + _gimbalY, _cameraZ);

        //cameraRotationReal.x = m_Camera.transform.rotation.x - playerTransform.rotation.x;
        //cameraRotationReal.y = m_Camera.transform.rotation.y - playerTransform.rotation.y;
        //cameraRotationReal.z = m_Camera.transform.rotation.z - playerTransform.rotation.z;
        //cameraRotationReal.w = m_Camera.transform.rotation.w - playerTransform.rotation.w;

        //cameraPositionReal = m_Camera.transform.position - playerTransform.position;
        //playerPositionNow = playerTransform.position;
        //cameraPositionNow = m_Camera.transform.position;
    }

    private void CameraControlMovement()
    {
        //TEMP: Check Camera Distance
        cameraDistance = (m_Camera.transform.position - playerTransform.position).magnitude;

        //Camera Rotation Smooth(1)
        //_rotationX = Mathf.Lerp(m_Camera.transform.rotation.x, playerTransform.rotation.x, Time.deltaTime * cameraRotationTension);
        //_rotationY = Mathf.Lerp(m_Camera.transform.rotation.y, playerTransform.rotation.y, Time.deltaTime * cameraRotationTension);
        //_rotationZ = Mathf.Lerp(m_Camera.transform.rotation.z, playerTransform.rotation.z, Time.deltaTime * cameraRotationTension);
        //_rotationW = Mathf.Lerp(m_Camera.transform.rotation.w, playerTransform.rotation.w, Time.deltaTime * cameraRotationTension);

        //Camera Rotation Smooth(2)
        m_Camera.transform.rotation = Quaternion.Slerp(m_Camera.transform.rotation, playerTransform.rotation, Time.deltaTime * cameraRotationTension);

        //Camera Rotation Hard(1)
        //playerQuaternion = playerTransform.rotation;
        //m_Camera.transform.rotation = playerQuaternion;

        //Camera Position Smooth
        _playerUp = playerTransform.up;
        _playerRight = playerTransform.right;
        _playerForward = playerTransform.forward;

        TransformPoint = m_Camera.transform.InverseTransformPoint(playerTransform.position);
        TransformPoint = new Vector3(TransformPoint.x + cameraOffset.x + _gimbalX + _shakeX, TransformPoint.y + cameraOffset.y + _gimbalY, TransformPoint.z + cameraOffset.z + _shakeY);
        InverseTransformPoint = m_Camera.transform.TransformPoint(TransformPoint);


        //TODO: Change Local Axis Orientation
        _cameraTargetPos = playerTransform.position - (_playerForward * (cameraOffset.x + _gimbalX)) - (_playerUp * (cameraOffset.y + _gimbalY) - (_playerRight * cameraOffset.z));
        _cameraX = Mathf.Lerp(m_Camera.transform.position.x, _cameraTargetPos.x, Time.deltaTime * cameraPositionTension);
        _cameraY = Mathf.Lerp(m_Camera.transform.position.y, _cameraTargetPos.y, Time.deltaTime * cameraPositionTension);
        _cameraZ = Mathf.Lerp(m_Camera.transform.position.z, _cameraTargetPos.z, Time.deltaTime * cameraPositionTension);
    }

    private void CameraBoosterMovement()
    {

        if (booster._isBoosterActive)
        {
            _shakeX = UnityEngine.Random.Range(1f, -1f) * _shakeMagnitude;
            _shakeY = UnityEngine.Random.Range(1f, -1f) * _shakeMagnitude;
        }
        else
        {
            _shakeX = 0;
            _shakeY = 0;
        }
    }

    private void CameraGimbalMovement()
    {
        cursorRectTransform = spaceshipController.cursorRectTransform;

        _mouseDistance.x = (cursorRectTransform.position.x - _screenCenter.x) / _screenCenter.y;
        _mouseDistance.y = (cursorRectTransform.position.y - _screenCenter.y) / _screenCenter.y;

        _mouseDistance = Vector3.ClampMagnitude(_mouseDistance, 1f);

        Mathf.Clamp(_gimbalX, -20f, 20f);
        Mathf.Clamp(_gimbalY, -10f, 5f);

        //Gimbal Position X
        if (_mouseDistance.x > 0.1f)
            _gimbalX = Mathf.Lerp(_gimbalX, 4f * gimbalX_Intensity, Time.deltaTime * 0.5f);
        else if (_mouseDistance.x < -0.1f)
            _gimbalX = Mathf.Lerp(_gimbalX, -4f * gimbalX_Intensity, Time.deltaTime * 0.5f);
        else
            _gimbalX = Mathf.Lerp(_gimbalX, 0f, Time.deltaTime * 1f);

        //Gimbal Position Y
        if (_mouseDistance.y > 0.1f)
            _gimbalY = Mathf.Lerp(_gimbalY, 5f * gimbalY_Intensity, Time.deltaTime * 2f);
        else if (_mouseDistance.y < -0.1f)
            _gimbalY = Mathf.Lerp(_gimbalY, -5f * gimbalY_Intensity, Time.deltaTime * 2f);
        else
            _gimbalY = Mathf.Lerp(_gimbalY, 0f, Time.deltaTime * 2f);


    }
}
