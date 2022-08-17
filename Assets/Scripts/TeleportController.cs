using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TeleportController : MonoBehaviour
{

    public GameObject baseControllerGameObject;
    public GameObject teleportationGameObject;
    public InputActionReference teleportActivationReference;

    [Space]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    // Start is called before the first frame update
    void Start()
    {
        teleportActivationReference.action.performed += teleportModeActivate;
        teleportActivationReference.action.canceled += teleportModeCancel;
    }

    private void teleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();

    private void teleportModeCancel(InputAction.CallbackContext obj)
    {
        Invoke("DeactivateTelporter", .1f);
    }

    void DeactivateTelporter() => onTeleportCancel.Invoke();

    // Update is called once per frame
    void Update()
    {
        
    }
}
