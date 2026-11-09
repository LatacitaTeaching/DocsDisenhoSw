Patrón Singleton
========================

Problema a resolver
---------------------

.. admonition:: Problema

   Cómo crear una única instancia de una clase ``C`` y asegurar que todos los clientes de dicha clase utilicen la misma instancia y puedan acceder a ella universalmente, sin necesidad de tener una referencia directa a ella.

Receta para aplicar el patrón (clase simple)
---------------------------------------------

    #. Ocultar el constructor y darle visibilidad privada o protegida.
    #. Crear un atributo ``instancia`` estático, privado o protegido que almacene la única instancia de la clase ``C``. Dicho atributo debe ser inicializado a ``null``.
    #. Crear un método estático público ``getInstance() : C`` que devuelva la única instancia de la clase ``C``. Dicho método debe crear la instancia si no existe y devolverla en cualquier caso.

Receta para aplicar el patrón (jerarquía de herencia)
------------------------------------------------------

    #. Ocultar los constructores cada clase de la jerarquía de herencia ``JE`` dándole visibilidad protegida. Sea ``R`` la raíz de la jerarquía de herencia ``JE``.
    #. Crear un atributo ``instancia`` (estático) protegido en ``R`` que almacene la única instancia de la jerarquía de herencia. Dicho atributo debe ser inicializado a ``null``.
    #. Crear un método estático ``init`` en cada clase concreta de la jerarquía de herencia ``JE``. Este método inicializa el atributo ``instancia`` de la clase raíz ``R`` con una instancia de la clase concreta que corresponda. 
    #. Crear un método estático ``getInstance() : R`` en ``R`` que devuelva la instancia ínica de la clase ``C``. Dicho método asumen que ``instancia`` tiene un valor distinto de nulo porque algún ,metódo ``init`` de alguna clase concreta de la jerarquía de herencia ``JE`` ha sido invocado previamente. 
