Patrón Visitor
===============

Problema a resolver
---------------------

.. todo:: Completar con ejemplo. Utilizar serializaación

.. admonition:: Problema

   Cómo añadir una familia de operaciones coehsionadas entre sí, a un conjunto
   o jerarquía de clases coeherente y estable, sin afectar a la estabilidad y
   cohesión de dichas clases.

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

.. todo:: Completar (OPC, Cohesión)

Receta para aplicar el patrón
--------------------------------

   #. Identificar la familia de operaciones a abstraer.
   #. Identificar el perfil de dicha familia de operaciones. Sea ``T`` el tipo que devuelven las operaciones de dicha familia.
   #. Crear una clase abstracta que ejerza de *Visitante Abstracto* ``VA`` y sirva de tipo para común para la familia de operacaciones. Tratar de darle a dicho visitante abstracto un nombre significativo relacionado con la operación que realiza.
   #. Añadir un método *visit* a dicho visitante abstracto ``VA`` por cada clase concreta de la colección o jerarquía de clases a procesar. Cada método *visit* devolverá el tipo ``T`` y aceptará como parámetro un objeto de la clase concreta con la que esté relacionado. Por ejemplo, si el método se llamase ``visitFoo``, su perfil sería ``T visitFoo(Foo f)``.
   #. Añadir a cada clase de la colección o jerarquía a procesar un método ``accept<Visitor>``, que permita ejecutar la operación abstraída por el visitante abstracto. Los métodos *accept* devuelven siempre el tipo ``T`` y tienen como único parámetro el visitante abstracto ``CA``. ``<Visitor>`` debe sustituirse por el nombre del visitante abstracto.
   #. Implementar cada método *accept* de cada clase concreta de la colección o jerarquía de clase mediante delegación en el método del visitante abstracto que corresponda, pasando el propio objeto como para parámetro. Por ejemplo, dentro de la clase ``Foo`` la implementación del método ``T acceptVisitor(CA visitor)`` sería ``return visitor.visitFoo(this)``.
   #. Implementar los métodos *visit* como corresponda a cada clase concreta. Si una clase concreta necesita procesar otros elementos de la jerarquía o colección, deberá hacerse mediante la invocación de su correspondiente método *accept*.
