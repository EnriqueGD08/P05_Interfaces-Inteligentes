# Práctica 5: Interacción con objetos en realidad virtual

Práctica realizada en Unity para trabajar con los eventos de interacción del
XR Interaction Toolkit. Se implementan cambios visuales al seleccionar objetos
con un `Ray Interactor` y una interfaz que informa de las veces que un objeto
ha sido agarrado y soltado mediante un `Direct Interactor`.

## Índice

1. [Controles](#controles)
2. [Archivos](#archivos)
3. [Funcionamiento](#funcionamiento)
4. [Resultado](#resultado)

## Controles

La interacción se realiza mediante los interactores configurados en la escena:

- El `Ray Interactor` permite apuntar y seleccionar un objeto a distancia.
- El `Direct Interactor` permite acercarse a un objeto, agarrarlo y soltarlo.

Los controles concretos dependen del dispositivo XR y de las acciones
configuradas en el `Input Action Manager` de Unity.

## Archivos

En la raíz se incluyen los scripts utilizados en la práctica:

- [`ChangeColorOnSelect.cs`](ChangeColorOnSelect.cs): cambia el color del
  objeto mientras está seleccionado.
- [`UpdateUIOnGrab.cs`](UpdateUIOnGrab.cs): actualiza un texto de la interfaz
  cuando el objeto se agarra o se suelta.
- [`Ejercicio.gif`](Ejercicio.gif): demostración del resultado de la práctica.

## Funcionamiento

### Cambio de color al seleccionar

`ChangeColorOnSelect` requiere un componente `XRBaseInteractable` y se suscribe
a los eventos `selectEntered` y `selectExited`.

Cuando un objeto es seleccionado por un interactor, su `Renderer` cambia al
color configurado en `selectedColor`. Al dejar de estar seleccionado, recupera
su color original.

### Actualización de la interfaz al agarrar

`UpdateUIOnGrab` utiliza los mismos eventos de interacción para detectar cuándo
un objeto es agarrado y soltado. Cada vez que se agarra, incrementa un contador
y actualiza el texto indicado en `label` con el nombre del objeto y el número
de agarres realizados.

Al soltarlo, la interfaz muestra que el objeto ha sido soltado y conserva el
contador acumulado.

## Resultado

![Resultado de la práctica](Ejercicio.gif)

[Volver al índice](#índice)
