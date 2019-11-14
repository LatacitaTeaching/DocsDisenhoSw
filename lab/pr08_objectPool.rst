=================================
Práctica 08 - Patrón Object Pool
=================================
-----------------------------
El Día de la Marmota [#f0]_
-----------------------------

.. [#f0] En homenaje a la mítica película *Groundhog Day* (Harold Ramis, 1993), traducida al castellano como *Atrapado en el Tiempo*, y protagonizada por un joven Bill Murray.

Introducción
=============

Los lenguajes de programación de alto nivel, como por ejemplo, los lenguajes orientados a objetos, proporcionan una serie de primitivas y operaciones que permiten a los desarrolladores abstraerse de muchos detalles de bajo nivel de la máquina sobre la que se ejecutan. No obstante, dichos detalles de bajo nivel pueden afectar en ocasiones a ciertas propiedades de una aplicación, tales como la seguridad o el rendimiento.

Por ejemplo, la mayoría de lenguajes de programación actuales ofrecen diferentes facilidades para invocar objetos remotos como si fuesen objetos locales. No obstante, estas facilidades deben utilizarse con cierta cautela, pues una invocación masiva y habitual de objetos remotos podría degradar el rendimiento de la aplicación y sobrecargar la infraestructura de red innecesariamente.

Otro caso similar es el de la creación de objetos de clases cuyo proceso de instanciación es complejo. Ejemplos típicos de dichas clases son las  conexiones a bases de datos, el acceso a servicios externos que requieran largos procesos de negociación o autenticación, o la creación de objetos de acceso a documentos XML que precisen de la carga de dicho documento en memoria, entre otros casos.

Para minimizar el impacto en el rendimiento de este tipo operaciones existen diferentes patrones de diseño, como *cachés* o *proxies*. Para el caso concreto de la creación de objetos con con complejos procesos de instanciación el patrón que se suele utilizar es el *Object Pool*, cuya principio básico consiste en crear un número suficiente de estos objetos al inicio de la aplicación, almecenarlos en una colección y deveolverlos a los diferentes objetos de la aplicación cuando estos requieren de la instanciación de uno de estos objetos complejos. Cuando los objetos de la aplicación terminan de utilizar estos objetos complejos, los devuelven al *object pool* de manera que puedan ser reutilizados más adelante, evitando así que tengan que ser creados de nuevo.

El objetivo de esta práctica es que el alumno adquiera familiaridad con el patrón *Object Pool*  mediante su aplicación al problema de crear conexiones a bases de datos. La siguiente sección resume dichos objetivos y los complementa con otros objetivos secundarios.

Objetivos
==========

Los objetivos concretos de esta práctica son:

  #. Comprender que ciertas acciones realizadas dentro de un programa software, aunque puedan parecer equivalentes a otras, pueden tener un serio impacto sobre ciertas propiedades de dicho producto software.
  #. Aprender a solventar el problema de la creación de objetos con procesos de instanciación pesados mediante la utilización de un *Object Pool*.
  #. Aprender a integrar un *Object Pool* en una aplicación real de manera adecuada mediante la aplicación del patrón *Singleton*.

Actividades
============

El alumno, para alcanzar los objetivos descritos, deberá completar satisfactoriamente las siguientes actividades, utilizando para ello el lenguaje de programación Java:

  #. Crear en un *Object Pool* de conexiones *JDBC (Java DataBase Connectivity)*. Las conexiones se crearán mediante la clase ``DriverManager``. El número de conexiones que contendrá inicialmente el *pool* debe ser configurable. En el caso de que se solicite una conexión y el *pool* no tenga conexiones disponibles, se alimentará de nuevo el *pool* con un número de conexiones igual a su tamaño inicial. Cuando se retornen conexiones, si el *pool* ha alcanzado su máxima capacidad, las conexiones retornadas simplemente se cerrarán y se desecharán.
  #. Convertir el pool en un *Singleton*.

Criterios de Evaluación
========================

  #. La colección o estructura donde el *pool* almacena los objetos precreados permite realizar de manera cómoda y eficiente tanto la extracción como la inserción de objetos en dicha estructura.
  #. El *pool* posee un método para recuperar *objetos pesados*.
  #. El *pool* posee un método para devolver *objetos pesados*.
  #. Los métodos para devolver y retornar objetos son conformes con las políticas del *pool*.
  #. El *pool* es un *Singleton*.

Apéndice A: Conexión a Bases de Datos
======================================

Para la realización de la práctica, es necesario interactuar con un sistema gestor de bases de datos. Como Sistema Gestor de Bases de Datos se recomienda la utilización de `MySQL <https://www.mysql.com/>`_ o `H2 <https://www.h2database.com/html/main.html>`_.

*MySQL* es un sistema gestor de base de datos muy popular, ampliamente utilizado por aplicaciones reales en producción. No obstante, para poder ofrecer la robustez y eficiencia que se espera de un sistema gestor de bases de datos profesional, *MySQL* tiene que incorporar una serie de características que aumentan su complejidad, haciéndolo un sistema pesado durante las fases de desarrollo y prueba de un sistema software.

Dado que durante las fases de desarrollo y pruebas no es necesaria la robustez y escalabilidad de un sistema gestor de bases de datos profesional, para estas fases sueles optarse por la utilización de sistemas ligeros como *H2*. *H2* una base de datos simple, que puede correr en memoria y, que no precisa ni de instalación ni de configuración. *H2* se instala habitualmente de manera transparente al desarrollador a partir de una dependencia Maven, lo que mejora enormemente la portabilidad del código fuente. Por tanto, recomendamos la utilización de *H2* durante el desarrollo de las prácticas de patrones de sistemas de información empresarial.

Para evitar que el alumno pierda tiempo escribiendo el código Java necesario para crear una conexión de a bases de datos, se facilita la clase :download:`DbConnectionHelper.java <src/pr08/DbConnectionHelper.java>`. Esta clase contiene un único método estático, denominado ``createConnection()``, el cual devuelve una conexión a una base de datos concreta. Para poder utilizar esta clase, hay que especificar las propiedades ``username``, ``password`` y ``databaseUrl``. Estos parámetros variarán dependiendo de si estamos usando *MySQL* o *H2*.

Apéndice B: Conexión a H2
==========================

Para conectarse a *H2* se utilizaran los siguientes parámetros de conexión:

:username:    ``sa``
:password:
:databaseUrl: ``jdbc:h2:mem:polaflix``

Además, para poder instalar *H2* deberá añadirse la siguiente dependencia al fichero ``pom.xml`` de Maven.

.. code-block:: XML

   <dependency>
    <groupId>com.h2database</groupId>
    <artifactId>h2</artifactId>
    <version>1.4.196</version>
   </dependency>

Apéndice C: Conexión a MySQL
=============================

Para crear una conexión a *MySQL* tendremos que realizar las siguientes acciones:

  #. Instalar *MySQL* en nuestra máquina.
  #. Crear un nuevo *esquema de base de datos* que se denomine ``polaflix``.
  #. Añadir un nuevo usuario a este esquema que se denomine ``polaflixStdUser``, con el *password* que se estime conveniente.
  #. Otorgar al usuario los permisos necesarios para gestionar el esquema ``polaflix``.
  #. Corrobar que la dirección y el puerto donde está accesible el servidor de *MySQL* son los estándares.
  #. Añadir al proyecto Java desde el cual se espera acceder a la base de datos una dependencia con *ConnectorJ*, el driver que se utiliza para acceder a *MySQL* desde Java. El código para añadir esta dependencia al ``pom.xml`` se proporciona  a continuación.

.. code-block:: XML

   <dependency>
     <groupId>mysql</groupId>
     <artifactId>mysql-connector-java</artifactId>
     <version>8.0.13</version>
   </dependency>

Tras realizar estas acciones, debería ser posible conectarse a *MySQL* utilizando los siguientes parámetros:

:username:      ``polaflixStdUser``
:password:      (el especificado por el alumno)
:databaseUrl:   ``jdbc:mysql://127.0.0.1:3306/polaflix``

Apéndice D: Trabajar con Maven
===============================

  #. Al crear el proyecto, seleccionar en *Eclipse* ``File/New/Project`` y a continuación ``Maven/Maven Project``.
  #. A continuación, seleccionar ``Create a simple project (skip archetype selection)``.
  #. Especificar los datos requeridos para crear el proyecto. En caso de duda, preguntar al profesor.
  #. Una vez creado el proyecto, se deberán añadir la dependencias necesarias, especificadas anteriormente, para trabajar con *H2* o *MySQL*.
