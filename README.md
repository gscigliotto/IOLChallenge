###Informe de Cambios IOLCodingChallenge

###Introducción
El presente documento tiene como objetivo enumerar y describir las modificaciones realizadas en la solución. también describir como él mismo se puede extender a partir de las modificaciones realizadas.

###Estado Inicial
Se ejecutan los test tal como estaban y se detecta que hay 2 que fallan.


Los test fallan porque el aserts usa como separador de miles “,” y la función devuelve como separador de miles “.” 
Se detecta que la solución tal como está es poco escalable, la misma  resuelve todo en un sola clase y en un solo proyecto, hay acoplamiento y falta de cohesión, toda la lógica se encuentra en la clase FormaGeometrica. la misma resuelve el manejo cálculo de área y perímetro de distintas formas geométricas, se ocupa de generar el reporte y el manejo del idioma del reporte.
TODO: Implementar Trapecio/ Rectángulo, agregar otro idioma a reporting.


###Cambios propuestos
Separar la lógica en distintos componentes, paquetizar y organizar la solucoin.
Abstraer el concepto de FormaGeometrica y implementar de manera concreta cada una de sus varianetes, separar por otro la generación de reportes, y por otro el manejo del idioma del reporte

Como a futuro el manejo y la creación de estas formas geométricas puede ir siendo más complejo decidí incorporar un abtractFactory que se ocupa de crear esta familia de formas geométricas, entendiendo que la familia inicial que contamos en este ejemplo es 2D pero a futuro podemos querer que estos mismos objetos se vean en 3D. A esta altura esto no es tan necesario.

La generalización FormaGeometrica tiene 2 métodos abstractos que tengo que implementar en cada extensión que son CalcularArea() y CalcularPerimetro().

ImprimirForma también es una generalización esta clase define en su constructor que tiene que recibir la clase Idioma para dejarlo seteado internamente. Esto es algo comun a todas las salidas en reportes.

La clase ImprimirFormaHTML es nuestra clase concreta que se ocupa de las salidas en texto, en esta instancia se estaba haciendo una salida en html, pero a futuro si queremos agregar una salida en PDF tan solo tenemos que extender esta clase e implementar la lógica de la salida PDF.

Datos: como decidí almacenar los distintos idiomas en objeto json, lo que hice fue crear una interfaz de acceso a datos, cuestión que si algún día se quiere cambiar la forma de almacenar o recuperar los datos sea sencillo de cambiar.

###Agregar un idioma nuevo

Agregar un idioma nuevo es tan sencillo como agregar la descripción de los labels al archivo Json.
Dentro del projecto CodingChallenge.Data hay un archivo que se llama Idimoas.json.

Cada elemento representa un label que se imprime, también acá se almacenan los nombres de los objetos en distintos idiomas y su denominación en plural.

Una vez agregada la descripción en el nuevo idioma de cada una de las propiedades del JSON tenemos que agregar dentro del Enum de Idiomas el idioma que creamos en el  JSON.


Listo ya se configuró un nuevo idioma para el reporte, faltaría agregar los test para la salida en nuevo idioma.

###Agregar una nueva forma

Para agregar la nueva forma debemos ir al proyecto de entidades, crear una nueva clase con el nombre de la forma que queremos crear, y heredar de FormaGeometrica.
Implementar los métodos CalcularArea() y CalcularPerimetro().

También debemos agregar la denominación para esta forma dentro del json de idimoa.
Si la clase se llama Rectángulo, la propiedad para singular debe llamarse Rectangulo tambien, y para la propiedad en plural se agrega el sufijo “Plural” ej: RectanguloPlural.

Implemento constructor y métodos.




Agregar denominación de la forma, en todos los idiomas como en plural.



También tenemos que agregar los métodos de creación en el Factory Lo único que falta es agregar los test que se consideren necesarios para la nueva forma y o nuevo idioma.
