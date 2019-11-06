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
.. #. Comprender el funcionamiento general del *patrón State*.
.. #. Ser capaz de aplicar el patrón State a la implementación de iteradores que necesiten re-correr estructuras compuestas como las generadas por el patrón Composite.

Para alcanzar estos objetivos, el alumno deberá realizar las actividades que se describen a continuación.

Actividades
============

El alumno, para alcanzar los objetivos perseguidos, deberá completar las siguientes actividades:

  #. Crear un iterador que permita recorrer los *Sistemas de Archivos Sparrow* creados en prácticas anteriores. Para ello se recomiendo utilizar como guía la implementación ejemplo de un iterador sobre composites encontrada más abajo.
  #. Crear, en una clase denominada `SparrowHelper`, una función estática que acepte un sistema de archivos Sparrow y una cadena de caracteres, y devuelva la colección de elementos de dicho sistema de archivos cuyo nombre contiene la cadena de caracte-res pasada como parámetro. 
4.	Crear, en la clase SparrowHelper, otra función estática que acepte un sistema de ar-chivos Sparrow y una cadena de caracteres y devuelva un elemento del sistema (el primero que encuentre) cuyo nombre contiene la cadena de caracteres pasado como parámetro.  Para la creación de esta función queda terminantemente prohibido rom-per el bucle mediante una sentencia return o break.


:download:`Explorador de Archivos Sparrow <src/pr06/SparrowFileExplorer.zip>`
  Proyecto Visual Studio C# conteniendo la definición de las interfaces gráficas que conformarán el *Explorador de Archivos Sparrow*.

Criterios de Autoevaluación
============================

  #. Existe una interfaz o clase abstracta que representa a cualquier observador de un elemento *Sparrow*.
  #. Dicha clase abstracta o interfaz de observación permite notificar cualquier cambio que sea relevante en los objetos observados.
  #. Cada objeto que necesita actualizarse cuando un objeto *Sparrow* cambia implementa de manera adecuada la interfaz de observación.
  #. Los elementos *Sparrow* contienen un registro de observadores en el cual es posible tanto darse de alta como de baja.
  #. Todos los observadores de un objeto *Sparrow* ``x`` se registran como observadores en dicho objeto ``x`` tan pronto como se establece un vínculo con dicho objeto.
  #. Todos los observadores de un objeto *Sparrow* ``x`` se retiran del registro de observadores tan pronto  como un vínculo con dicho objeto ``x`` se deshace.
  #. Siempre que hay un cambio relevante en un objeto *Sparrow* se procede a notificar a sus observadores.
  #. Se evitan de alguna forma bucles infinitos por notificaciones cruzadas.
