Patrón Template Method
=======================

Problema a resolver
---------------------

.. todo:: Completar con ejemplo. Utilizar el mismo ejemplo que en el caso del strategy.

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

Strategy vs Template Method
-----------------------------

    1. El patrón *Strategy* permite modificar el variante en uso en tiempo de ejecución, mientras que *TemplateMethod* no.
    2. El patrón *Template Method* permite controlar las configuraciones de múltiples estrategias para que sean coherentes, mientras que con el *Strategy* podríamos crear configuaciones erróneas.
    3. El patrón *Template Method* permite un más fácil acceso a las partes internas de una clase, mientras que en el caso del patrón *Strategy* hay que pasar los datos que hagan falta como parámetros a las estrategias.

Receta para aplicar el patrón
--------------------------------

    #. Identificar el bloque de código del método ``m`` de la clase ``C`` donde se presenta la àlta variabilidad.
    #. Identificar las entradas y salidas de dicho bloque de código.
    #. Diseñar un método ``x`` que abstraiga dicho bloque de código.
    #. Añadir dicho método ``x`` como abstracto a la clase ``C``, que pasa a ser abstracta.
    #. Reemplazar el bloque de código del método ``m`` con alta variabilidad por una llamada al método abstracto ``x``.
    #. Implementar tantas subclases de la clase ``C`` como variantes existían en el bloque de código con alta variabilidad.
