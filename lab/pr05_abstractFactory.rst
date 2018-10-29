=======================================
Práctica 05 - Patrón Abstract Factory
=======================================
-------------------------
 Tiempos Modernos [#f0]_
-------------------------

.. [#f0] En referencia a la obra maestra del cine mudo, *Tiempos Modernos (Charles Chaplin, 1936)*.

Introducción
=============

Los principios de *indirección* e *inversión de dependencias* establecen que cuando un módulo ``A`` depende de otro módulo ``B``, dicho módulo ``A`` sólo debería depender de los detalles de alto nivel de dicho módulo ``B``, permaneciendo sus detalles de bajo nivel de ocultos. De esta forma, variaciones o cambios realizados en los elementos de bajo nivel del módulo ``B`` no deberían afectar al módulo ``A``.

Por ejemplo, supongamos que tenemos un módulo ``Agenda`` que utiliza un módulo ``Fecha`` para manipular fechas. Una fecha podría implementarse, al menos, de dos maneras completamente distintas:

  #. Almacenando los tres valores que constituyen la fecha, es decir, el *día*, el *mes* y el *año*, de manera separada;
  #. Almacenando el número de días transcurridos desde una fecha determinada, como, por ejemplo, el 1 de enero de 1970.

La primera alternativa permite visualizar muy fácilmente la fecha representada, por lo que mostrarla en un dispositivo de salida cualesquiera resulta bastante trivial. Por otro lado, la segunda representación permite calcular con mayor comodidad el número de días transcurridos entre dos fechas. Este cálculo se podría realizar para determinar, por ejemplo, los días que faltan para alcanzar una determinada fecha, o cuánto ha transcurrido desde un determinado evento. Por tanto, dependiendo del uso que la clase ``Agenda`` vaya a realizar de la clase ``Fecha``, una implementación podría resultar más adecuada que otra.

No obstante, en el caso ideal, un módulo ``Agenda`` debería depender exclusivamente de la interfaz pública del módulo ``Fecha``, y no de la forma concreta en la cual se implementa ésta última. Es decir, ``Agenda`` debería depender sólo de ``Fecha`` y no de implementaciones concretas de ``Fecha`` como podrían ser ``UserFriendlyDate`` (versión donde se almacenan los tres valores de la fecha de manera separada) o ``CounterDate`` (versión donde se almacenan el número de días transcurridos desde una fecha fija). Además, cambiar la implementación concreta del módulo ``Fecha`` que queremos utilizar en la clase ``Agenda`` debería ser una operación relativamente fácil de realizar.

En los lenguajes orientados a objetos, esta independencia se alcanza mediante la siguiente estrategia: cuando una clase ``A`` necesita utilizar otra clase ``B``, se crea una interfaz (o clase abstracta) que contenga la interfaz pública de ``B``. Esta interfaz es común a todas las implementaciones concretas de ``B`` y está libre de detalles ed bajo nivel. De esta forma, la clase ``A`` sólo utiliza esta interfaz como tipo para las referencias a la clase ``B``, evitando así depender de implementaciones concretas de la clase ``B``.

En nuestro ejemplo concreto, crearíamos una interfaz para la clase ``Fecha``. Esta interfaz contendría sólo la declaración de las operaciones que se pueden realizar sobre un objeto del tipo ``Fecha``, cualesquiera que sea su implementación. A continuación haríamos que la clase ``Agenda`` sólo contuviese referencias a esta interfaz y  crearíamos tantas implementaciones o clases concretas de la interfaz ``Fecha`` como formas de implementar dicha interfaz conozcamos. En nuestro caso, crearíamos como clases concretas ``UserFriendlyDate`` y ``CounterDate``. Cada clase concreta implementaría una de las dos formas de almacenar fechas descritas con anterioridad. Ambas clases heredarían de ``Fecha``.

De esta manera, gracias al polimorfismo y la vinculación dinámica, se pueden utilizar instancias de las clases concretas ``UserFriendlyDate`` y ``CounterDate`` allá donde se requiera un objeto del tipo abstracto ``Fecha``. De esta forma, la clase ``Agenda`` puede evitar hacer referencia a las clases concretas de ``Fecha`` y trabajar exclusivamente sobre el tipo abstracto, aceptando sin problemas diferentes implementaciones de dicho tipo abstracto.

Esta técnica, sin embargo, tiene un punto débil. Dado que no se pueden crear instancias ni de clases abstractas ni de interfaces, si la clase ``A`` necesita crear una instancia de la clase ``B``, dicha clase ``A`` necesitaría hacer referencia a una implementación concreta de ``B``. Por ejemplo, en nuestro ejemplo, si la clase ``Agenda`` necesitase crear una instancia de la clase ``Fecha``, la clase ``Agenda`` tendría que hacer referencia a las clases concretas ``UserFriendlyDate`` o ``CounterDate``, por lo que al final acabaría acoplada a alguna de estas implementaciones concretas.

Para solventar este problema, existe un conjunto de patrones de diseño particulares denominados *creacionales*.
Dentro de este conjunto de patrones destaca especialmente el *Abstract Factory*,  el cual ha alcanzado gran éxito y popularidad, utilizándose en la práctica totalidad de las aplicaciones creadas hoy en día. Tal es su popularidad, que, para facilitar su aplicación, en los últimos años se han creado una serie de librerías y frameworks, conocidos como *inyectores de dependencias*, cuyo objetivo es permitir la especificación de factorías a alto nivel, de manera cuasi declarativa, simplificando en gran medida su desarrollo.

El objetivo general de esta práctica es que el alumno aprenda tanto a crear factorías abstractas manualmente como a generarlas mediante la utilización de un inyector de dependencias. El siguiente apartado refina esta serie de objetivos genéricos en un conjunto de objetivos concretos.

Objetivos
==========

Los objetivos concretos de esta práctica son:

  #. Aprender a utilizar el patrón *Abstract Factory*.
  #. Aprender a utilizar el patrón *Singleton*.
  #. Aprender a utilizar el patrón *Prototype*.
  #. Aprender a utilizar un *inyector de dependencias*.

Para alcanzar dichos objetivos, el alumno deberá aplicar el patrón *Abstract Factory*, complementado con los patrones *Prototype* y *Singleton* a la situación que se describe a continuación. Además, se creará una implementación alternativa basada en *inyección de dependencias*.

 
