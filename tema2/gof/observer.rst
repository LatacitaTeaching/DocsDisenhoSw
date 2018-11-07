Patrón Observer
==================

Problema a resolver
---------------------

.. todo:: Completar con ejemplo. Celda Excel.

.. admonition:: Problema

   Cómo notificar cambios en una clase ``C`` a un conjunto no acotado y variable de clases heterogéneas donde, además, el número de instancias de dichas clases a ser notificadas puede variar en tiempo de ejecución.

Solución
---------

Ejemplo Concreto
*****************

.. todo:: Completar una vez que esté listo el ejemplo concreto.

Solución Abstracta
*******************

.. todo:: Completar

Ventajas e Incovenientes
-------------------------

.. todo:: Completar (OPC, Polimorfismo)

Receta para aplicar el patrón
--------------------------------

  #. Identificar la clase ``C`` cuyas modificaciones necesitan ser notificadas.
  #. Crear una clase abstracta ``C_Observer``.
  #. Añadir un método ``void x_Changed(<params>)`` a la clase abstracta ``C_Observer`` por cada cambio ``x`` en ``C`` que necesite ser notificado. Añadir como parámetros a ese métodos los que se estime conveniente para que los observadores puedan actualizar su estado tras ser notificados.
  #. Añadir a la clase ``C`` un conjunto ``observers`` de ``C_Observer``s. Permitir además que se puedan añadir y eliminar objetos a esta colección en tiempo de ejecución.
  #. Añadir a la clase ``C`` un método no público ``notify_x()`` por cada tipo de cambio ``x`` que pueda producirse
  en la clase ``C``. Dicho método recorrerá la colección ``observers`` e invocará por cada elemento ``obs`` de
  dicha colección su método ``x_changed(..)``,  proporcionando los parámetros adecuados.
  #. Hacer que siempre que ``C`` sufra un cambio ``x`` se invoque el método ``notify_x()``.
  #. Hacer que cada clase que necesite actualizarse cuando ``C`` cambie implemente la clase abstracta ``C_Observer``.
  #. Hacer que, cuando un objeto ``obj`` necesite actualizarse cuando un objeto concreto ``unC`` de la clase ``C``  cambie, el objeto ``obj`` se registre como observador en dicho objeto ``unC``.
  #. Hacer que cuando un objeto ``obj`` deje de necesitar actualizarse cuando un objeto concreto ``unC`` de la clase ``C``  cambie, el objeto ``obj`` se retire del registro de observadores de dicho objeto ``unC``.

Detalles a considerar
-----------------------

    1. ¿Cuántos parámetros deben tener los métodos de la clase *Observer*?
    2. ¿Son realmente necesarios los métodos *notify*?
    3. ¿Debo suscribirme a todos los cambios o sólo a algunos concretos?
    4. ¿Necesito métodos de registro y baja como observador explícitos?
