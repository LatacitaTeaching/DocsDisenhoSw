Patrón Composite
==================

Problema a resolver
---------------------

.. todo:: Completar con ejemplo. Utilizar programa de dibujo o tablero de juego.

.. admonition:: Problema

   Cómo tratar un conjunto de objetos heterogéneos, que pueden formar
   jerarquías de profundidad arbitraria, como objetos homogéneos indistingibles,
   tanto desde fuera de la jerarquía, es decir a nivel de cliente de la
   jerarquía, como internamente dentro de la jerarquía.

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

    #. Identificar que elementos de la jerarquía son hojas y cuáles nodos intermedios.
    #. Crear una clase abstracta ``CA`` que represente tanto a los nodos intermedios como a las hojas.
    #. Añadir a la clase abstracta ``CA`` las operaciones que queramos homogeneizar dentro de la jerarquía.
    #. Crear una clase ``X`` por cada tipo de hoja que pueda aparecer en la jerarquía de elementos y hacer que dicha clase herede de la clase abstracta ``CA``.
    #. Implementar los métodos de la clase abstracta ``CA`` en las clases ``X`` como corresponda a cada hoja.
    #. Crear una clase ``Y`` por cada tipo de nodo intermedio que pueda aparecer en la jerarquía de elementos y hacer que dicha clase herede ``Y`` de la clase abstracta ``CA``.
    #. Añadir una asociación/composición desde las clases ``Y`` a la clase abstracta ``CA``.
    #. Implementar los métodos de la clase abstracta ``CA`` en las clases ``Y``, correspondientes a los nodos intermedios, mediante delegación en los elementos contenidos en cada nodo intermedio. Estos elementos contenidos deben tratarse de manera homogénea.

Detalles a considerar
-----------------------

    1. ¿Cuántos métodos subo de las clases concretas a las clases abstractas?
    2. La referencia entre los grupos y los hijos, ¿asociación o composición?
    3. La referencia entre los grupos y los hijos, ¿unidireccional o bidireccional?
