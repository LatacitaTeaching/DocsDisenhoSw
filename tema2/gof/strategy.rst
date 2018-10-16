Patrón Strategy
==================

Problema a resolver
---------------------

.. todo:: Completar con ejemplo. Utilizar por ejemplo el formato de las fechas.

.. admonition:: Problema

   Dada una clase ``C`` con un método ``m``, donde ``m`` presenta una alta variabilidad no acotada en un punto concreto de su implementación, cómo conseguir que la clase ``C`` pueda recibir nuevos cambios sin necesidad de modificarla.


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

    #. Identificar el bloque de código del método ``m`` de la clase ``C`` donde se presenta la àlta variabilidad.
    #. Identificar las entradas y salidas de dicho bloque de código.
    #. Diseñar un método ``x`` que abstraiga dicho bloque de código.
    #. Crear una clase abstracta ``Strategy`` que contenga dicho método ``x``.
    #. Añadir una referencia de la clase ``C`` a la clase ``Strategy``.
    #. Reemplazar el bloque de código del método ``m`` con alta variabilidad por una llamada al método ``x`` de la clase ``Strategy``.
    #. Implementar tantas subclases de la clase ``Strategy`` como variantes existían en el bloque de código con alta variabilidad. 

Detalles a considerar
-----------------------

    1. ¿Cuántos parámetros debe recibir el método que calcula la estrategia?
    2. ¿Quién y cómo configura las estrategias?
