===============================
Práctica 11 - Capa de Servicio
===============================

Introducción
=============

Los *modelos de dominio* ayudan a capturar la complejidad de un determinado ámbito de la vida real, encapsulando los datos que se deben manipular en diferentes tipos de entidades y proporcionando métodos y operaciones para modificar dichos datos conforme a las reglas establecidas en cada dominio.

No obstante, para que los usuarios finales puedan manipular este modelo de dominio, dicho modelo debe permitir la recepción de eventos o comandos que permitan tanto su consulta como su modificación. Además, en el caso de las modificaciones, debe asegurarse que éstas se realizan de manera transaccional, evitando que, si por el motivo que sea una operación no puede ejecutarse de manera completa, el modelo de dominio no permanezca en estados intermedios erróneos que no satisfagan las reglas de negocio.

Para liberar a la capa de dominio de la necesidad de procesar estos eventos y gestionar su transaccionalidad, en las arquitecturas empresariales se asigna esta responsabilidad a una *capa de servicio*. De esta forma, el modelo de dominio sólo debe encargarse de modificar los diferentes elementos que lo conforman de acuerdo con las reglas de negocio. Por otra lado, la capa de servicio tendrá como responsabilidades:

  #. Recoger las peticiones de la capa de presentación.
  #. Recuperar los objetos de la capa de persistencia que sean necesarios para procesar cada petición.
  #. Gestionar la transaccionalidad de las operaciones.
  #. Redirigir la petición recibida al objeto del modelo de dominio que corresponda.
  #. Persistir los cambios realizados como consecuencia del procesamiento de la transacción.
  #. Gestionar posibles errores y casos excepcionales.
  #. Manejar el flujo de control de la aplicación.
  #. Devolver una respuesta adecuada a la capa de presentación, serializando los objetos que deba retornar de manera conveniente.

El problema de cómo serializar entidades de dominio para devolvelas a la capa de presentación no es una cuestión trivial. Los modelos de dominio constituyen una red de elementos fuertemente relacionados entre sí. Por lo tanto, para serializar, es decir, para transformar a texto, un objeto del modelo de dominio, necesitaríamos serializar también el resto de objetos con los que éste está relacionado, por lo que podríamos acabar necesitando serializar el modelo completo de dominio antes de transferirlo a la capa de presentación. si la capa de presentación finalmente sólo necesitase una pequeña fracción de dicho modelo de dominio para sus propósitos, estaríamos serializando y enviando mucha información que no se usa, lo cual es ineficiente.

Para evitar este último problema suelen emplearse diferentes estrategias, siendo una de las más populares la utilización de *Data Transfer Objects*. Un *Data Transfer Object* es un objeto o conjunto de objetos que conforman una proyección o subconjunto de un modelo orientado a objetos más amplio, donde dicha proyección contiene toda la información necesaria para un determinado propósito.

El objetivo general de esta práctica es que el alumno aprenda a desarrollar capas de servicio, aplicando los patrones de diseño adecuados para ello. Para alcanzar dicho objetivo general, el alumno deberá satisfacer los objetivos concretos que se describen en la siguiente sección.

Objetivos
==========

Los objetivos concretos que se persiguen con la realización de esta práctica son:

  #.	Aprender a especificar la interfaz de la capa de servicio de una aplicación empresarial.
  #. Aprender a crear *Data Transfers Objects* que permitan transferir objetos de negocio a una capa de presentación.
  #.	Aprender a implementar capas de servicio basadas en el patrón *Domain Model*.
  #. Comprender cómo se integran las diferentes capas de una aplicación empresarial.

Actividades
============

El alumno, para alcanzar los objetivos perseguidos, deberá completar con éxito las siguientes actividades, utilizando para ello el sistema *Polaflix*,  descrito e implementado en prácticas anteriores:

  #.	Especificar las operaciones que se considere necesario implementar en la capa de servicio para dar soporte a las interfaces contenidas en la `descripción de Polaflix <https://apuntes-de-diseno-sw.readthedocs.io/es/latest/lab/pr09_domainDrivenDesign.html#polaflix-un-sistema-de-visualizacion-de-series>`_.
  #. Crear e implementar los objetos DTO (*Data Transfer Objects*) que sean necesarios conectar la capa de servicio con las interfaces ``Página personal`` (Figura 1) y ``Ver Facturas`` (Figura 4) de la `descripción de Polaflix <https://apuntes-de-diseno-sw.readthedocs.io/es/latest/lab/pr09_domainDrivenDesign.html#polaflix-un-sistema-de-visualizacion-de-series>`_.
  #.	Implementar los correspondientes *assemblers* para dichos DTOs.
  #.	Implementar la operación de negocio que agrega una serie al espacio personal de un usuario. En caso de que necesiten utilizarse *Repositories* o *DataMappers* que no se encuentren actualmente implementados, éstos podrán simularse mediante la creación de *mocks* o *stubs*.
