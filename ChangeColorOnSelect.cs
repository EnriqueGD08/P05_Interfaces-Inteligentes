using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;

/// Cambia el color del objeto mientras esta seleccionado por un Ray Interactor.
[RequireComponent(typeof(XRBaseInteractable))]
public class ChangeColorOnSelect : MonoBehaviour
{
    [SerializeField] Color selectedColor = Color.green;

    XRBaseInteractable interactable;
    Renderer rend;
    Color originalColor;

    void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
        rend = GetComponentInChildren<Renderer>();
        originalColor = rend.material.color;
    }

    void OnEnable()
    {
        interactable.selectEntered.AddListener(OnSelectEntered);
        interactable.selectExited.AddListener(OnSelectExited);
    }

    void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnSelectEntered);
        interactable.selectExited.RemoveListener(OnSelectExited);
    }

    void OnSelectEntered(SelectEnterEventArgs args) => rend.material.color = selectedColor;
    void OnSelectExited(SelectExitEventArgs args) => rend.material.color = originalColor;
}
