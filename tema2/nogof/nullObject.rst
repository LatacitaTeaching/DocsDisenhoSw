Patrón Null Object
===================

Problema a resolver
---------------------

.. todo:: Completar con ejemplo. Utilizar programa de dibujo o tablero de juego.

.. admonition:: Problema

   Cómo tratar de manera uniforme referencias a objetos nulas y no nulas.

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

    #. Identifica la clase ``Class`` los objetos cuyas referencias nulas ocasiones problemas.
    #. Crear una subclase ``NullClass`` de dicha clase ``Class``.
    #. Sobreescribir los métodos públicos de ``NullClass`` para que tengan sentido en el caso de referencias nulas.
    #. Donde antes se asignaba una referencia nula para el tipo ``Class``, asignar un objeto del tipo ``NullClass``.

Detalles a considerar
-----------------------

    1. ¿Qué se considera un comportamiento adecuado en caso de nulo?
