==========================================
Apéndice A. Trabajando con H2 desde Java
==========================================

Introducción
=============

Para la realización de las prácticas sobre patrones para arquitecturas de sistemas de información empresarial, es necesario utilizar algún *Sistema Gestor de Bases de Datos (SGBD)*, que en nuestro caso será un sistema gestor de bases de datos relacional.
En el contexto de esta asignatura, recomendamos la utilización de `H2 <https://www.h2database.com/html/main.html>`_ como sistema gestor de bases de datos.

*H2* un sistema gestor de base de datos muy simple, que puede mantener la base de datos en memoria, sin acceder a disco, y que no precisa ni de instalación ni de configuración. Dado que durante las fases de desarrollo y pruebas no es necesaria la robustez y escalabilidad de un sistema gestor de bases de datos profesional, como `MySQL <https://www.mysql.com/>`_, suele preferirse la utilización de estos sistemas ligeros.

Además, *H2* se instala habitualmente de manera transparente al desarrollador a partir de una dependencia Maven, lo que facilita que se pueda ejecutar el código fuente del proyecto en diferentes computadores, sin necesidad de realizar ninguna configuración adicional.

A continuación, explicaremos como trabajar con *H2* desde Java con ayuda de *Maven*. En :download:`demoH2.zip <src/misc/demoH2.zip>` puede encontrarse un pequeño proyecto de ejemplo que ilustra los diferentes conceptos que se explican a continuación.

.. warning:: Para importar este proyecto en *Eclipse*, primero debe descromprimirse. Luego se seleccionará el menú ``File/Import``,  la opción ``Maven/Existing Maven Projects``, y por último ``Browse``, indicando la carpeta que se acaba de descomprimir.

Crear un proyecto con Maven
=============================

  #. Para crear un proyecto Maven, seleccionar en *Eclipse* ``File/New/Project`` y a continuación ``Maven/Maven Project``.
  #. A continuación, seleccionar ``Create a simple project (skip archetype selection)``.
  #. Especificar los datos requeridos para crear el proyecto. En caso de duda, preguntar al profesor.
  #. Una vez creado el proyecto, se deberán añadir la siguiente dependencia al fichero ``pom.xml`` de Maven.

.. code-block:: XML

  <dependency>
    <groupId>com.h2database</groupId>
    <artifactId>h2</artifactId>
    <version>1.4.196</version>
   </dependency>

Con esto, tendremos *H2* instalado y listo para ser usado desde Java. Además, cuando transfiramos el proyecto a otro computador, *H2* se instalará automáticamente en él, evitando tener que hacer nuevas configuraciones de manera manual.

Crear una conexión a H2
========================

Para evitar que el alumno pierda tiempo escribiendo el código Java necesario para crear una conexión de a bases de datos, se facilita la clase :download:`DbConnectionHelper.java <src/pr08/DbConnectionHelper.java>`. Esta clase contiene un único método estático, denominado ``createConnection()``, el cual devuelve una conexión a una base de datos concreta. Para poder utilizar esta clase, hay que dar valor a sus propieades ``username``, ``password`` y ``databaseUrl``, aunque en la clase proporcionada existen unos valores adecuados por defecto.

Para conectarse a *H2* se recomienda utilizar los siguientes parámetros de conexión:

:username:    ``sa``
:password:
:databaseUrl: ``jdbc:h2:mem:polaflix``

Al especificar como *url* para la conexión a la base de datos ``jdbc:h2:mem:polaflix``, estamos indicando que queremos crear una conexión local vía ``jdbc``, que el sistema gestor de bases de datos al que nos conectaremos es ``h2``, que la base de datos se alojará en memoria y no en disco (``mem``), y que el esquema de bases de datos al que nos conectamos se llama ``polaflix``.

Ejecutar un script SQL
========================

Una vez creada una conexión a base de datos, nos interesará crear una serie de tablas en ella, de manera que nuestro código pueda tanto almacenar datos en esas tablas o recuperarlos. Es bastante probable que tambiñen nos interesé alimentar la base de datos con una serie de datos iniciales que nos sirvan para realizar diversas pruebas.

Para realizar ambas tareas, la práctica recomendable cuando se trabaja con *H2* es crear *scripts SQL* que realicen estas tareas y ejecutar estos *scripts* desde código.

Para ejecutar un script SQL, se hará uso de la clase ``RunScript`` (`ver documentación <http://www.h2database.com/javadoc/org/h2/tools/RunScript.html>`_). En el código abajo mostrado se propociona un ejemplo de uso de esta clase.

.. code-block:: Java

  private static void inicializarBBDD(Connection conn)
               throws SQLException, FileNotFoundException {

    RunScript.execute(conn, new FileReader("src/main/resources/sql/createDatabase.sql"));
    RunScript.execute(conn, new FileReader("src/main/resources/sql/feedDatabase.sql"));

  }

Para inicializar la base de datos crearemos dos *scripts* separados. El primero de ellos será responsable de la creación las tablas de la base de datos, mientras que el segundo será el que inicialice dichas tablas con un conjunto inicial de datos. En el ejemplo de arriba, los *scripts* ``createDatabase.sql`` y ``feedDatabase.sql`` son los que realizan dichas tareas, respectivamente. Estos *scripts* deben situarse en algún lugar adecuado de nuestro proyecto, siendo la opción recomendada la carpeta recursos, es decir, ``src/main/resources``.

Para ejecutar dichos scripts, usaremos el método ``execute`` de la clase ``RunScript``. Este método acepta dos parámetros, una conexión a la base de datos donde se ejecutará el *script*, y un *stream* de carácteres conteniendo el script a ejecutar. En nuestro caso, para crear dicho *stream* de caracteres, crearemos un objeto de la clase ``FileReader``. Para crear dicho objeto, en el ejemplo proporcionado, utilizamos como párametro la ruta del archivo que contiene el *script* a ejecutar.

Visualizar la base de datos H2
===============================

*H2* no es un sistema de base de datos que esté pensado para ser utilizado desde una consola, interfaz gráfica o *front-end*, sino directamente desde código. Sin embargo, cuando estamos empezando a trabajar con *H2*, podrías querer visualizar la base de datos para saber si las tablas y los datos se están creando de manera correcta.

La forma más efectiva y simple para acceder a la consola de administración de la base de datos es lanzarla desde código por medio de la sentencia ``Console.main()``. Esta sentencia, al ejecutarse, abrirá un navegador por medio del cual nos podremos conectar a nuestra base de datos *H2*.

.. note:: Nuestra aplicación Java no se cerrará hasta que no se cierre la consola de H2. Dado que no existe método alguno para cerrar dicha consola, utilizaremos para terminar nuestro programa Java la sentencia ``System.exit(0)``, la cual indica que la aplicación actual y todos sus elementos asociados deben cerrarse, generando como código de salida ``0``, que significa éxito.
