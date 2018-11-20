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
  #. El *pool* posee un método para recueperar *objetos pesados*.
  #. El *pool* posee un método para devolver *objetos pesados*.
  #. Los métodos para devolver y retornar objetos son conformes con las políticas del *pool*.
  #. El *pool* es un *Singleton*.

Apéndice A: Material de Ayuda
==============================

Para evitar que el alumno pierda tiempo escribiendo el código necesario para crear una conexión de a Bases de Datos, se facilita la clase :download:`DbConnectionHelper.java <src/pr08/DbConnectionHelper.java>`. Esta clase contiene un único método estático, denominado ``createConnection()``, el cual devuelve una conexión a una base de datos concreta.

Para que dicha conexión pueda ser creada:

  #. Debe existir un gestor de base de datos al cual conectarse;
  #. Los datos de conexión a dicha base de datos deben haber sido incorporados a la clase ``DbConnectionHelper``.
  #. El proyecto debe incorporar una serie de dependencias que proporcionen los *drivers* adecuados para realizar la conexión con las Bases de Datos. Para hacer más cómoda la gestión de las dependencias, se recomienda la utilización de Maven.

Los siguientes apéndices indican como llevar a cabo dichas acciones

Apéndice B: Crear un Esquema de Base de Datos
==============================================

Como Sistema Gestor de Bases de Datos se recomienda la utilización de `MySQL <https://www.mysql.com/>`_. Para configurar adecuadamente MySQL, se deberán llevar a cabo las siguientes acciones:

  #. Crear un nuevo *esquema* que se denomine ``polaflix``.
  #. Añadir un nuevo usuario que se denomime ``polaflixStdUser``, con el password que se estime conveniente.
  #. Otorgar al usuario permisos para gestionar el esquema ``polaflix``.
  #. Averiguar la dirección y el puerto donde está accesible el servidor de *MySQL*.

Apéndice C: Trabajar con Maven
===============================

  #. Al crear el proyecto, seleccionar en *Eclipse* ``File/New/Project`` y a continuación ``Maven/Maven Project``.
  #. Especificar los datos requeridos para crear el proyecto. En caso de duda, preguntar al profesor.
  #. Una vez creado el proyecto, incorporar las secciones ``build`` y ``dependencies`` de este fichero :download:`pom.xml <src/pr08/pom.xml>`.
  #. Una vez configurado el fichero ``pom.xml``, las dependencias con ``ConnectorJ`` se resolverán automáticamente.
  #. Para compilar el proyecto, se seleccionará el archivo ``pom.xml`` y, pulsando el botón derecho, se selecionará la opción ``Run As/Maven Build``.
  #. Para ejecutar el proyecto, se seleccionará el archivo ``pom.xml`` y, pulsando el botón derecho, se selecionará la opción ``Run As/Run Configurations``. A continuación, una vez abierto el cuadro de especifciación de las configuraciones, se dará un nombre a la configuración y especificará como *Goals* ``exec:java``. Esta configuración sólo necesita ser creada una vez y a partir de ahí puede ser ejecutada tantas veces como haga falta.
