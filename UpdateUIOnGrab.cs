using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

/// Actualiza un texto de la UI cuando el objeto es agarrado o soltado por un Direct Interactor.
[RequireComponent(typeof(XRBaseInteractable))]
public class UpdateUIOnGrab : MonoBehaviour
{
    [SerializeField] Text label;
    [SerializeField] string objectName = "Objeto";

    XRBaseInteractable interactable;
    int grabCount;

    void Awake() => interactable = GetComponent<XRBaseInteractable>();

    void OnEnable()
    {
        interactable.selectEntered.AddListener(OnGrab);
        interactable.selectExited.AddListener(OnRelease);
    }

    void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnGrab);
        interactable.selectExited.RemoveListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        grabCount++;
        if (label != null) label.text = $"Agarrando: {objectName}\nVeces agarrado: {grabCount}";
    }

    void OnRelease(SelectExitEventArgs args)
    {
        if (label != null) label.text = $"Soltado: {objectName}\nVeces agarrado: {grabCount}";
    }
}
