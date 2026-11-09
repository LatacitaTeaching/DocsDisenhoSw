Patrón Prototype
==================

Problema a resolver
---------------------

.. admonition:: Problema

   Cómo conseguir que una determinada clase ``X`` pueda crear instancias concretas de una clase abstracta ``A`` sin necesidad de conocer la clase concreta ``C``  que hereda de ``A``, sin necesidad de que dicha clase ``C`` esté disponible en tiempo de compilación.

Receta para aplicar el patrón (clase simple)
---------------------------------------------

    #. Identificar la clase abstracta ``A`` de la cual se desean crear instancias concretas.
    #. Añadir un método público ``clone() : A`` a dicha clase ``A``.
    #. Añadir una referencia a un objeto de la clase ``A`` en la clase ``X``.
    #. Cuando ``X`` necesite crear una instancia concreta de ``A``, invocará el método ``clone()`` del objeto de la clase ``A`` que tiene como referencia.    

