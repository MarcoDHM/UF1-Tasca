<!-- Nom: Marco de Haro Martín | Data: 08/10/2026 -->

## GameObject
Un **GameObject** és el contenidor bàsic d'objectes a l'escena d'Unity.
Equivalent anglès: **GameObject**.

## Hierarchy
La **Hierarchy** mostra la llista ordenada de tots els objectes presents a l'escena actual.
Equivalent anglès: **Hierarchy**.

## Inspector
L'**Inspector** permet visualitzar i modificar els components i propietats de l'objecte seleccionat.
Equivalent anglès: **Inspector**.

## Scene
La **Scene** és l'espai de treball tridimensional o bidimensional on construeixes el joc.
Equivalent anglès: **Scene View**.

## Project
La finestra **Project** mostra l'estructura de fitxers i recursos (assets) de tot el teuAquí tienes la guía paso a paso y el código para completar el resto de tareas de la UF1.

---

### T1.3 Escena amb un cub pintat (b)

1. En la ventana **Hierarchy**, haz clic derecho > **3D Object > Plane**[cite: 2].
2. Clic derecho > **3D Object > Cube**[cite: 2]. Ajusta su posición en el panel **Inspector** a `Y = 0.5` para que quede sobre el suelo[cite: 2].
3. En la carpeta **Assets** del panel **Project**, haz clic derecho > **Create > Material**[cite: 2, 3]. Nómbralo `MaterialAzul`. En el Inspector, cambia el color *Albedo* a azul y arrastra el material sobre el Cubo[cite: 2].
4. En la Hierarchy, selecciona **Directional Light** y en el Inspector cambia el color de la luz a un tono cálido (naranja/amarillo)[cite: 2].
5. Guarda la escena con el nombre `Casa_UF1_TuNombre.unity` (**File > Save As**)[cite: 2].

---

### T1.4 Tres objectes amb física (m)

1. **Explicación teórica (para incluir en tus respuestas/entrega):**
   * **¿Por qué no se mueven al pulsar Play?** Unity no aplica simulación física ni gravedad a un objeto a menos que tenga adjunto un componente `Rigidbody`. Los objetos solo con `Collider` son estáticos.
   * **¿Qué pasa si añades Rigidbody a una?** Solo esa esfera caerá por la gravedad hasta colisionar con el `Plane`, mientras que las otras dos se quedarán flotando en el aire.
   * **¿Y a las tres?** Las tres esferas caerán por gravedad y colisionarán con el suelo.

---

### T1.5 Moneda que gira (m)

Crea un script llamado `Spinner.cs` e incluye este código:

```csharp
// Nombre: Marco de Haro Martín
// Fecha: 08/10/2026

using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float speed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}