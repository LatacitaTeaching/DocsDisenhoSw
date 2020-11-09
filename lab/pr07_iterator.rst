===============================
Práctica 07 - Patrón Iterator
===============================
---------------------------------------------------------------------------------------------
Sigue el camino de las baldosas amarillas [#f0]_
---------------------------------------------------------------------------------------------

.. [#f0] Famosa frase extraída del clásico del cine “El Mago de Oz” (Victor Fleming, 1939).

Introducción
=============

Los objetos de un sistema software no son normalmente elementos aislados e independientes unos de otros. Como es natural, estos elementos suelen conformar complejas redes  constituyen estructuras de tipos heterogéneos. Por tanto, se hace necesario, para diversos fines, disponer de mecanismos que permitan recorrer dichas estructuras de manera sistemática pasando por todos y cada uno de sus elementos. Por ejemplo, podría ser necesario recorrer dichas estructuras para encontrar un objeto concreto o modificar una serie de ellos, entre otros propósitos.

El objetivo del *patrón Iterator* es resolver el problema anteriormente descrito. Dado que este problema es bastante común y la solución proporcionada por el patrón Iterator es elegante y está comúnmente aceptada, dicho patrón se ha ido integrando en los lenguajes de programación actuales, como Java, C# o Python. Dichos lenguajes proporcionan interfaces predefinidas para la especificación de iteradores e, incluso, instrucciones especiales, como los *bucles foreach*, que permiten simplificar la manipulación de los iteradores.

El objetivo general de esta práctica es que el alumno adquiera familiaridad con el patrón Iterator, para lo que se aplicará dicho patrón a un problema concreto. La siguiente sección describe los objetivos de esta práctica de manera más detallada.

Objetivos
==========

Los objetivos concretos de esta práctica son:

  #. Comprender el funcionamiento general del *patrón Iterator*.
  #. Ser capaz de construir iteradores para recorrer estructuras de clases creadas de acuerdo con el patrón Composite.
  #. Ser capaz de utilizar iteradores para recorrer estructuras compuestas.

Para alcanzar estos objetivos, el alumno deberá realizar las actividades que se describen a continuación.

Actividades
============

El alumno, para alcanzar los objetivos perseguidos, deberá completar las siguientes actividades:

  #. Crear un iterador que permita recorrer los *Sistemas de Archivos Sparrow* creados en prácticas anteriores. Para ello se recomiendo utilizar como guía la implementación ejemplo de un iterador sobre composites disponible al final de esta sección. El iterador debe crearse usando las interfaces proporcionadas por C# a tal efecto, es decir, ``IEnumerable<T>`` e ``IEnumerator<T>``.
  #. Crear, en una clase denominada ``SparrowHelper``, una función estática denominada ``findHeavierThan`` que acepte un *Sistema de Archivos Sparrow* y un entero representado un tamaño de archivo, y que devuelva como resultado el conjunto de elementos del sistema de archivos Sparrow que superen dicho tamaño. Esta función debe implementarse usando bucles *while*, sin usar bucles *forEach*.
  #. Crear, en una clase denominada ``SparrowHelper``, una función estática denominada ``findSizeInRange`` que acepte un *Sistema de Archivos Sparrow* y dos enteros representado un tamaño de archivo y que devuelva como resultado el conjunto de elementos del sistema de archivos Sparrow cuto tamaño esté entre los valores especificados. Esta función debe implementarse usando  bucles *forEach*.
  #. Crear, en la clase ``SparrowHelper`` generada anteriormente, otra función estática, denominada ``findWithPrefix`` que acepte un sistema de archivos Sparrow y una cadena de caracteres y devuelva un elemento del sistema (el primero que encuentre) cuyo nombre contiene como prefijo la cadena de caracteres pasada como parámetro. Para la creación de esta función queda terminantemente prohibido romper el bucle mediante una sentencia *return* o *break*.

:download:`Ejemplo Implementación Iterador Sobre Composite <src/pr07/IteradorComposite.zip>`
  Proyecto Visual Studio C# con una implementación de ejemplo del patrón Iterator sobre un Composite.

.. tip:: Para saber si una cadena ``x`` contiene como prefijo otra cadena ``y``, en C# se puede utilizar el método ``StartsWith``.

Criterios de Autoevaluación
============================

  #. Todos los elementos del *Sistema de Archivos Sparrow* implementan la interfaz ``IEnumerable<T>``.
  #. Existe al menos un ``IEnumerator<T>`` para las hojas y otro para los nodos, pudiendo existir más de uno.
  #. Las funciones ``findHeavierThan``, ``findSizeInRange`` y ``findWithPrefix`` funcionan correctamente.
  #. Las funciones ``findHeavierThan``, ``findSizeInRange`` y ``findWithPrefix`` cumplen con lo solicitado.
  #. La función ``findWithPrefix`` no sigue iterando una vez que se ha encontrado un elementos que satisface la condición de búsqueda.

.. Comprender el funcionamiento general del patrón State.
.. Ser capaz de aplicar el patrón State a la implementación de iteradores que necesiten re-correr estructuras compuestas como las generadas por el patrón Composite.
