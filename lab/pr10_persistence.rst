===================================
Práctica 09 - Domain-Driven Design
===================================

Introducción
=============

De acuerdo con la filosofía de desarrollo `Domain-Driven Design <https://domainlanguage.com/ddd/reference/>`_, la mejor estrategia para lidiar con la creciente complejidad de los sistemas software es crear, de manera colaborativa entre *stakeholders* y desarrolladores, un modelo que repesente el dominio del problema que dicho sistema software trata de resolver. Este modelo de dominio contendría únicamente elementos propios del dominio de la aplicación, en el que los *stakeholders* son expertos, y estaría libre de detalles técnicos que compliquen, oscurezcan o ensucien innecesariamente dicho modelo de dominio.

No obstante, una vez que hemos desarrollado un modelo de dominio adecuado y creado instancias de sus entidades, si queremos que dichas instancias no sean volátiles, debemos *persistirlas* de alguna forma. Persistirlas significa guardarlas en algún tipo de almacenamiento no volátil, como un disco duro físico. Obviamente, persistirlo no implica sólo el problema de alamacenarlo, sino también el de una vez almacenada una entidad, como recuperarla, actualizarla y borrarla.

La manera más habitual de persistir un objeto en memoria es almacenarlo en una base de datos relacional, aunque en los últimos años van ganando cada vez más protagonismo otras alternativas, como la utilización de bases de datos NoSQL. La elección de bases de datos relacionales se debe a razones puramente pragmáticas: se trata de una tecnología bastante madura, sobre la cual se lleva trabajando durante mucho tiempo y en la cual se han conseguido importantes avances, los cuales han permitido crear potentes, robustos y eficientes sistemas gestores de bases de datos.

No obstante, por desgracia, los paradigmas orientado a objetos y relacional no encajan directamente, existiendo algunos problemas de compatibilidad entre ellos. Por ejemplo, supongamos que, en una plataforma de compra *online*, un usuario pueda tener asociada a su cuenta diferentes direcciones de envío. Utilizando modelos orientados a objetos, este requisito se podría especificar de manera natural colocando una asociación con multiplicidad infinita entre la clase ``Usuario`` y la clase ``Dirección``, ya que la orientación a objetos soporta de manera natural el concepto de colección.  Sin emabrgo, el concepto de colección no existe tal cual en el mundo relacional, siendo necesario desarrollar trucos, como la creación de tablas intermedias, para representarlo.

Por tanto, para poder almacenar y recuperar objetos de un modelo sobre una base de datos relacional debemos traducir o trasladar dichos objetos hacia y desde   una representación relacional equivalente. Para que dicho proceso de conversión sea transparente al modelo de dominio, permitiendo que las clases de dominio permanezcan agnósticas a estos detalles y los desarrolladores puedan centrarse exclusivamente en la lógica de negocio, se han desarrollado en los últimos años los puentes objeto relacionales, conocidos como *ORMs (Object-Relational Mapper)*. Estas herramientas se basan en un conjunto de reglas y patrones de diseño bien conocidos, como los *Identity Maps*, los *Data Mappers* o los *Unit of Works*, entre otros elementos.

El objetivo de esta práctica es que el alumno comprenda el problema del desacoplamiento o impendancia objeto-relacional y aprenda a solucionarlo mediante la utilización de un conjunto concreto de patrones. La siguiente sección describe cómo este objetivo general se plasma en una serie de objetivos concretos.

Objetivos
==========

Los objetivos concretos que se pretenden alcanzar mediante el desarrollo de esta práctica son:

  #. Comprender el problema de la impedancia o desacoplamiento objeto-relacional.
  #. Aprender a derivar un esquema relacional que sea conforme a un modelo de dominio utilizando un conjunto de reglas de transformación bien definido.
  #. Aprender a implementar *Data Mappers*, en especial en lo relativo a sus operaciones de lectura.
  #. Aprender a utilizar el patrón *LazyLoad* para reducir el número de objetos que necesitan cargarse en memoria cuando se recupera un objeto.
  #. Aprender a implementar *Repositories*, utilizando para ello *Data Mappers* u otros *Repositories*.

Para alcanzar dichos objetivos, el alumno deberá realizar de forma satisfactoria las actividades que se describen a continuación, utilizando para ello la implementación del sistema *Polaflix* creada en la práctica anterior.

Actividades
============

El alumno, para alcanzar los objetivos perseguidos, deberá completar satisfactoriamente las siguientes actividades:

  #. Crear, aplicando los patrones para la transformación estructural objeto-relacional, un esquema relacional que permita persistir el modelo de dominio de *Polaflix*. Como resultado de esta actividad se deberá entregar un documento de texto, preferentemente en formato pdf, en el que describa paso por paso el proceso de transformación aplicado, indicando por cada paso el patrón de transformación aplicado, su justificación cuando proceda y las tablas creadas, utilizando para ello la notación relacional explicada en clase.
  #. Construir un generador de claves artificiales para cada elemento del modelo de dominio que precise utilizar una clave artificial.
  #. Crear un *Repository* que de soporte a las operaciones de creación, lectura y borrado para el *aggregate root* que contenga al elemento  ``Usuario``. No es necesario implementar la operación de actualización de este *Repository*. Para la carga de una entidad ``Usuario`` concreta desde el almacén persistente deberá utilizarse la estrategia de *LazyLoad* mediante la aplicación del patrón *Proxy*. Además, para la implementación de este *Repository* podrán implementarse tantos *DataMappers* como se desee. Finalmente, deberá tenerse en cuenta que para obtener las conexiones con la base de datos, cualquiera de estos elementos deberá hacer uso del *pool de conexiones* creado en prácticas anteriores.
