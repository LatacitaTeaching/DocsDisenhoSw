=================================
Práctica 03 - Patrón Visitor
=================================
-------------------------------------------------
Los ladrones de cuerpo [#f0]_
-------------------------------------------------

.. [#f0] En homenaje al clásico de la ciencia ficción *La invasión de los ladrones de cuerpos* (Don Siegel, 1956), donde unas extrañas criaturas se introducen en los cuerpos de los habitantes de un pequeño pueblo estadounidense, los cuales mantienen su apariencia externa pero cambian su comportamiento.

Introducción
=============

Desde el punto de vista de la calidad externa, los productos software creados mediante la utilización de patrones de diseño no se distinguen de los creados sin su utilización. Por ejemplo, supongamos que se creasen dos productos software con exactamente la misma funcionalidad, pero donde un producto se ha creado utilizando patrones de diseño y el otro producto sin ellos. En este caso, ambos productos ofrecerían unas funcionalidades y rendimiento similares. En adelante denominaremos al producto que utiliza los patrones de diseño como el *producto patronizado* y al que los utiliza como el *producto sin patronizar*.

Estos productos no serían sólo iguales desde un punto de visto externo, sino que incluso, en algunas situaciones muy particulares [#f1]_, el producto patronizado podría ser ligeramente más lento o consumir más memoria que el producto sin patronizar. Es decir, desde este punto de vista del rendimiento, el producto patronizado se podría considerar peor que el producto que sin patronizar.

Por tanto, si, desde el punto de vista de la calidad externa, ambos productos son prácticamente indistinguibles y la utilización de los patrones de diseño sólo parece servir para empeorar el producto, ¿qué ventaja aportan estos patrones? La principal ventaja que suelen aportar está relacionada con la calidad interna de un producto software y, más concretamente, con su facilidad de evolución y adaptación al cambio. Para ello los patrones de diseño suelen introducir en un producto software *puntos de variación* bien definidos que permiten introducir nuevas funcionalidades, denominadas *variantes*, en dicho producto de manera cómoda, sencilla y elegante, sin necesidad de modificar el producto ya existente.

Por tanto, volviendo a nuestro ejemplo, aunque externamente el producto patronizado pueda parecer exactamente igual que el producto sin patronizar, el producto patronizado es en realidad mucho más fácil de adaptar a nuevas situaciones. Dicho de otra forma, el producto patronizado es mucho más barato de mantener.

El objetivo de esta práctica es que el alumno entienda cómo y por qué los patrones de diseño ayudan a mejorar la calidad interna de un producto software. Para alcanzar este objetivo, el alumno deberá aplicar el *patrón Visitor* a un problema concreto. Siguiendo los principios del *patrón Visitor* podemos incorporar nuevas funcionalidades a una jerarquía o estructura de clases ya existente, sin necesidad de tener que modificar dichas clases. Sin embargo, para aplicar el *patrón Visitor* debemos utilizar de un complejo y exótico mecanismo de *double dispatching*, el puede ser complejo de entender e introduce además una serie de niveles de indirección que teoricamente ralentizaría la ejecución de la aplicación [#f1]_. Para alcanzar este objetivo general, el alumno deberá satisfacer los subobjetivos que se detallan en la siguiente sección.

.. [#f1] Dadas las características del hardware actual, este fenómeno es prácticamente inapreciable en prácticamente el 100% de las situaciones.

Objetivos
==========

Los objetivos concretos de esta práctica son:

  #. Comprender el funcionamiento del *patrón Visitor*.
  #. Comprender el concepto de punto de variación y variante.
  #. Ser capaz de, utilizando el *patrón Visitor*, introducir puntos de variación dentro de una estructura de clases de manera que se puedan incorporar nuevas funcionalidades a dicha estructura sin necesidad de modificarla.
  #. Ser capaz de, utilizando el *patrón Visitor*, extender la funcionalidad de una estructura visitable de clases mediante la implementación de nuevas variantes.
  #. Ser capaz de utilizar el *patrón Visitor* para visitar un elemento cualesquiera de una jerarquía de clases.

Para alcanzar dichos objetivos, el alumno deberá aplicar el *patrón Visitor* al problema que se describe a continuación.
