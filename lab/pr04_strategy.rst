====================================
Práctica 04 - Patrón Statregy e IoD
====================================
---------------------------------------------------------------------------------------------
A veces la mejor decisión es no tomar ninguna decisión y eso es también una decisión [#f0]_
---------------------------------------------------------------------------------------------

.. [#f0] Frase pronunciada por D. Mariano Rajoy Brey (https://goo.gl/D0j203).

Introducción
=============

Una técnica frecuentemente utilizada por los patrones de diseño para soportar variabilidad en el comportamiento dentro de un producto software es la de especificar la parte variable de un método como un método abstracto que tenga que ser sobrescrito en diferentes subclases, cada una correspondiendo a una de las diferentes variabilidades existentes. En este caso el método abstracto ejerce de *punto de variación* y las subclases serían las *variantes*. Ejemplos de dichos patrones son, entre otros, el patrón *Template Method*, el patrón *Strategy* o el patrón *State*.

Mediante esta técnica, la parte estable del comportamiento de estas clases se encapsula en una clase abstracta, mientras que las partes variables queda confinadas dentro de diversas clases concretas.

Idealmente, las clases que utilizan las clases abstractas deberían depender sólo de la clase abstracta y no de las clases concretas que la implementan. Para conseguir este objetivo se puede utilizar una técnica conocida como *inversión de dependencias*.

El primer objetivo de esta práctica es que el alumno aprenda a especificar comportamientos variables mediante la aplicación del patrón *Strategy* a un problema determinado. El segundo objetivo es que el alumno aprenda a invertir dependencias de manera que evite que las clases que dependen de clases abstractas acaben también dependiendo de las clases concretas que la implementan. El tercer y último objetivo es que el alumno conozca alternativas a los patrones de diseño, como puede ser la utilización de *funciones lambda*, de manera que comprenda que ciertos patrones de diseño existen fudamentalmente por la complejidad accidental de ciertos lenguajes orientados a objetos.

El siguiente apartado refina esta serie de objetivos genéricos en un conjunto de objetivos concretos.
