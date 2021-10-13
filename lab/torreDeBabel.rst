===================================
Práctica Opcional - Torre de Babel
===================================

Introducción
=============

Sabido es por toda persona con algún conocimiento de programación que existe un número bastante elevado de lenguajes de programación (más de 300). Al igual que los diferentes idiomas usados en el mundo, todos los lenguajes de programación sirven para expresar prácticamente los mismos conceptos pero con diferente sintaxis.

Existen, no obstante, lenguajes que permiten expresar ciertos conceptos con mayor precisión que otros. Por ejemplo, el idioma utilizado por los esquimales posee un alto número de términos para describir diferentes tonos de blanco. Los ingleses, por ejemplo, tienen una palabra (*loitering*) para designar el acto de permanecer en un sitio, normalmente público, por un tiempo indefinido y sin propósito aparente, sin que existan indicios de que se vaya a revertir esa situación. El mismo fenómeno acontece con los lenguajes de programación. Cada lenguaje está diseñado para satisfacer unos determinados objetivos, por lo que suele contener construcciones y facilidades para satisfacer esos objetivos concretos.

Al contrario que ocurre con los idiomas, los lenguajes de programación resultan muy fáciles de aprender siempre y cuando se manejan de forma adecuada una serie de conceptos teóricos básicos, ya que cuando se cambia de lenguaje, se trata de usar los mismos conceptos pero con una sintaxis diferente. Por ejemplo, entendiendo bien cuáles son los problemas derivados de la herencia múltiple, el concepto de interfaz resulta prácticamente trivial de aprender. Por tanto, un programador que domine los conceptos de la programación orientada a objetos debería ser capaz de escribir un mismo algoritmo, sin demasiado esfuerzo, en cualquier lenguaje de este tipo, como *Java*, *C++*, *Smalltalk*, *Ada95*, *C#* ó *Eiffel*.

No obstante, conviene aclarar que la situación del párrafo anterior no sería cierta cuando el lenguaje de programación que queremos aprender soporta conceptos y técnicas de programación que desconocemos. Por ejemplo, un programador experto en técnicas de orientación a objetos que quiera aprender *Scala* tendrá que emplear cierto tiempo y esfuerzo en ello, por ser Scala un lenguaje de programación con un marcado carácter funcional, con conceptos nuevos como el de *closure*, *funciones reductoras* o *funciones mapeadoras*. No obstante, merece la pena resaltar que este esfuerzo se debe a la necesidad de interiorizar nuevos conceptos y a la necesidad de aprender una nueva sintaxis.

Este fenómeno es especialmente perceptible en el caso de los *streams* de Java, los cuales apenas introducen elementos sintácticos nuevos, pero resultan muy complejos de entender y utilizar para muchos programadores orientados a objetos. Ello se debe a que estos *streams* introducen muchos conceptos nuevos de programación funcional, como *lazy evaluation* o *funciones mapeadoras*, que resultan poco familiares a estos programadores orientados a objetos. Sin embargo, un desarrollador con amplia experiencia en programación funcional podría empezar a utilizar estos *streams* de manera ampliamente solvente en apenas unas horas, igual que podría aprender a utilizar otros lenguajes funcionales, como Haskell, F# o LISP, en cuestión de horas.

Resumiendo, lo importante no es saberse la sintaxis de muchos lenguajes de programación, sino conocer, entender y saber usar los conceptos que éstos soportan. En palabras más técnicas, lo importante es la semántica de un lenguaje y no su sintaxis.

Objetivos
==========

El objetivo general de esta práctica es que el alumno interiorice, mediante la experiencia, que lo importante de un lenguaje de programación son los conceptos y técnicas de programación que soporta y no su sintaxis, ya que aprenderse la sintaxis de un nuevo lenguaje de programación es una tarea más o menos irrelevante.

Para alcanzar este objetivo general, el alumno deberá satisfacer los siguientes objetivos concretos:

  #. Aprender a utilizar un lenguaje de programación orientado a objetos distinto a los que el alumno haya utilizado hasta ahora.
  #. Aprender a implementar el patrón *Composite* en dicho lenguaje.
  #. Aprender a crear casos de prueba en el lenguaje elegido.
  #. Aprender que el concepto de patrón es independiente del lenguaje de programación que se utilice.

Actividades
============

Para alcanzar los objetivos descritos en la sección anterior, el alumno deberá ejecutar las siguientes actividades:

  #. Seleccionar un lenguaje de programación orientado a objetos, distinto a Java, C# y C++, y que el alumno no haya utilizado nunca, preferentemente. Se recomienda utilizar como lenguajes como Eiffel, Smalltalk, Ada o Python. El alumno deberá comunicar al profesor el lenguaje escogido, ya que el profesor deberá dar su aprobación a esta selección antes de continuar.
  #. Instalar un compilador y un editor para dicho lenguaje.
  #. Implementar en el lenguaje orientado a objetos escogido el código resultante de la realización de la práctica dedicada al patrón *Composite*.
  #. Utilizar una *suite* para la creación y ejecución de test compatible con el lenguaje escogido para verificar el correcto funcionamiento del programa creado. Si no existiera tal suite, crear un programa de prueba que haga las veces de *suite* de ejecución de pruebas.

Entrega y Criterios de Evaluación
==================================

La práctica se entregará a través de la plataforma *moodle* siguiendo las instrucciones en ella proporcionadas.

Para la evaluación de la práctica se prestará especial atención a que el alumno haya sido capaz de traducir correctamente la implementación realizada en C# del patrón *Composite* al lenguaje de programación que haya escogido, así como que haya sido capaz de utilizar con corrección las características propias de dicho lenguaje. También se valorará que la traducción de la práctica al nuevo lenguaje de programación esté completa y no falten elementos por trasladar.

La traducción al lenguaje destino de la implementación del *Composite* tendrá un peso del 75% del global de esta práctica, mientras que la traducción de la *suite* de pruebas tendrá un peso del 25%.
