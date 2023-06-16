# TP-Integrador-BonoraSantiago
8) ¿Qué es el IL?

El código IL significaría código intermedio o dicho de otra manera código administrado.
En Microsoft, Visual Studio admite demasiados lenguajes.
Cada usuario diferente tiene una configuración de máquina diferente y un sistema operativo diferente que puede ser desconocido para Visual Studio. 
Ese es el problema principal. Para evitar este problema, Microsoft crea un código que se llama Código IL.
Se llama código IL o código medio compilado, se crea en tiempo de compilación.
Visual Studio no sabe cuál es la configuración del sistema del usuario, por lo que en tiempo de compilación compila el código de idioma y lo convierte en código IL.
Cuando este programa se ejecuta en el sistema del usuario, este código IL de tiempo de ejecución se convierte en código de máquina mediante el compilador JIT (just in time).


9) Explique con sus palabras VES, CTS y CLS.

VES:
Es un sistema de tiempo de ejecución que crea el ambiente o entorno adecuado para ejecutar código administrado. Proporciona soporte directo para un conjunto de tipos de datos integrados,
define una máquina hipotética con un modelo y un estado de máquina asociados, un conjunto de construcciones de flujo de control y un modelo de control de excepciones.
En conclusión, el propósito del VES es proporcionar el soporte necesario para ejecutar el conjunto de instrucciones CIL de Common Intermediate Language.

CTS:

Una implementación de .NET es independiente del lenguaje. Esto no solo significa que un programador puede escribir su código en cualquier lenguaje que se pueda compilar en IL.
También significa que deben poder interactuar con código escrito en otros lenguajes que se pueden usar en una implementación de .NET.
Para hacer esto de forma transparente, tiene que haber una forma común de describir todos los tipos admitidos.
Esto es lo que el Sistema de Tipo Común (STC) se encarga de hacer. Fue hecho para hacer varias cosas:
- Establecer un marco para la ejecución entre idiomas.
- Proporcionar un modelo orientado a objetos para admitir la implementación de varios lenguajes en una implementación de .NET.
- Definir un conjunto de reglas que todos los lenguajes deben seguir a la hora de trabajar con tipos.
- Proporcionar una biblioteca que contenga los tipos primitivos básicos que se utilizan en el desarrollo de aplicaciones.

CLS:

Dado que hay numerosos lenguajes diferentes, .NET ha especificado esas similitudes en algo llamado Common Language Specification (CLS).
Este define un conjunto de características que son necesarias para muchas aplicaciones comunes.
También proporciona una especie de receta para cualquier lenguaje que se implemente sobre .NET en lo que necesita admitir.
CLS es un subconjunto del CTS. Esto significa que todas las reglas del CTS también se aplican al CLS.


10) Explique con sus palabras que es un Assembly, el early y late Binding.

Un Assembly es el resultado compilado del código, normalmente una DLL, pero el archivo EXE también es un Assembly.
Es la unidad de implementación más pequeña para cualquier proyecto .NET.
El Assembly normalmente contiene código .NET en MSIL (lenguaje intermedio de Microsoft) que se compilará en código nativo ("JITted" - compilado por el compilador Just-In-Time)
la primera vez que se ejecute en un equipo determinado. Ese código compilado también se almacenará en el ensamblado y se reutilizará en llamadas posteriores.
El Assembly también puede contener recursos como iconos, mapas de bits, tablas de cadenas, etc. Además, el ensamblado también contiene metadatos.

Early:
Significa que el método de destino se encuentra en tiempo de compilación y se crea código que llamará a esto.

Late Binding:
Significa que el método de destino se busca en tiempo de ejecución.


11) ¿Qué es GIT? ¿Es centralizado o distribuido? Ejemplifique al menos 3 comandos de
git y explique su funcionamiento.

Git es un sistema de control de versiones distribuido, lo que significa que un clon local del proyecto es un repositorio de control de versiones completo.
Estos repositorios locales plenamente funcionales permiten trabajar sin conexión o de forma remota con facilidad.
Los desarrolladores confirman su trabajo localmente y, a continuación, sincronizan su copia del repositorio con la copia en el servidor.
Este paradigma es distinto del control de versiones centralizado, donde los clientes deben sincronizar el código con un servidor antes de crear nuevas versiones.

El comando git merge
Se encarga de fusionar cualquier cambio que se haya hecho en la base de código en una rama separada de tu rama actual como un nuevo commit.
La sintaxis del comando es la siguiente:
git merge NOMBRE-DE-LA-RAMA
Por ejemplo, si estás trabajando actualmente en una rama llamada dev y deseas fusionar los nuevos cambios que se hayan realizado en una rama llamada new-features, ejecutarías el siguiente comando:
git merge new-features

El comando git rebase
Se encarga de reorganizar o cambiar la base de una rama de commit a otra. Esto deriva en que parezca que se ha creado la rama desde un commit diferente.
Los procesos realizados por Git Rebase se realizan desarrollando commits o confirmaciones nuevas, para luego aplicarlas a una base específica que haya sido establecida por el usuario.

El comando git commit --amend
Es una manera práctica de modificar el commit más reciente. Te permite combinar los cambios preparados con el commit anterior en lugar de crear un commit nuevo.



