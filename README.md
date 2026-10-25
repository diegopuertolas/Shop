# Shop

## Precio más barato

Crear una clase:

```csharp
Articulo
```

con:

- Nombre.
- Precio.

Crear varios artículos y almacenarlos en:

```csharp
List<Articulo>
```

Recorrer la colección y localizar el artículo con el precio más bajo.

Ejemplo:

```text
El artículo más barato es:

Cable USB - 4,50 €
```

## Precio medio

Calcular el precio medio de todos los artículos.

El resultado deberá calcularse a partir de los objetos almacenados en la colección.

No se indicará manualmente el número de artículos.

Ejemplo:

```text
Precio medio: 23,45 €
```

## Buscar por precio máximo

Solicitar:

```text
Precio máximo:
```

Validar el valor utilizando:

```csharp
decimal.TryParse()
```

Mostrar todos los artículos cuyo precio sea igual o inferior al indicado.

Si no existe ninguno, mostrar un mensaje.
