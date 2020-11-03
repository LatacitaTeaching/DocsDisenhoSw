Patrón Abstract Factory
========================

Problema a resolver
---------------------

.. admonition:: Problema

   Cómo independizar un conjunto de clases ``C`` que utilizan otra conjunto de clases abstractas (o interfaces) ``A`` de implementaciones concretas de dichas clases abstractas, asegurando además que todas las clases de ``C`` utilizan las mismas versiones concretas de ``A``.

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

    #. Identificar el conjunto de clases abstractas (o interfaces) ``A`` cuyas clases concretas pueden dar lugar a distintos modos de funcionamiento o configuración de la aplicación.
    #. Crear una clase (o interfaz) que represente la *factoría abstracta* que se va a encargar de crear instancias de las clases abstractas (o interfaces) ``A``. Se recomienda nombrar a dicha factoría abstracta con un nombre que describa el conjunto de clases ``A``, seguido del sufijo ``AbstractFactory``.
    #. Por cada clase abstracta (o interfaz) ``X`` en ``A``, añadir un método abstracto ``createX() : X`` a la factoría abstracta.
    #. Identificar todas las configuraciones ``Configs`` en las cuales puede funcionar la aplicación.
    #. Por cada configuración concreta ``Cfg`` en la cual puede funcionar la aplicación, crear una factoría concreta ``CF`` que represente dicha configuración. Dicha factoría concreta heredará de la factoría abstracta antes creada. Se recomienda dar como nombre a dicha factoría concreta el nombre de la configuración a la que corresponde, el prefijo dado a la factoría abstracta que implemente, y ``Factory`` como sufijo.
    #. Implementar cada método ``createX() : X`` de cada factoría concreta ``CF`` para que dentro de dicho método se cree y se retorne un objeto de la clase concreta que corresponda a la clase ``X`` dentro de la configuración asociada a la factoría concreta ``CF``.
