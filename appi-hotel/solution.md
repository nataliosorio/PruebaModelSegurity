# Requerimientos: 

Actores claves en el sistema: 
Marie, la panadera
Sophie, la cajera
Antoine, el manager
Amélie, la clienta fiel
David, el turista

🔄 Interacciones y Casos de Uso por Actor
1. Marie, la panadera
Interacciones:
Interactúa con el sistema de inventario y gestión de recetas.
Consulta el programa de producción.
Casos de uso:
Consultar y actualizar inventario de ingredientes.
Escalar recetas según la cantidad a hornear.
Revisar el programa de producción diario y semanal.

---
2. Sophie, la cajera
Interacciones:
Opera el sistema de punto de venta (POS).
Usa la app para aplicar descuentos o fidelización.
Casos de uso:
Registrar pedidos y pagos de clientes.
Aplicar descuentos y recompensas.
Gestionar pedidos y revisar inventario desde app móvil.
---
3. Antoine, el Manager
Interacciones:
Administra datos operativos y decisiones estratégicas.
Supervisa al personal y controla inventarios.
Casos de uso:
Visualizar ventas, rendimiento y niveles de inventario en tiempo real.
Analizar datos de ventas y comportamiento del cliente.
Asignar turnos y horarios del personal.
---
4. Amélie, la clienta fiel
Interacciones:
Usa una aplicación móvil para hacer pedidos y ver su historial.
Consulta el menú, ingredientes y puntos de fidelidad.
Casos de uso:
Consultar menú y alérgenos.
Hacer pedidos en línea.
Ver puntos acumulados y redimir recompensas.

---

5. David, el turista
Interacciones:
Usa app o web para consultar información y pedir productos.
Elige método de entrega (hotel o recogida).
Casos de uso:
Consultar información sobre la tienda (ubicación, menú, horarios).
Realizar pedidos para entrega o recogida.
Elegir y pagar en la moneda preferida.
```plantuml
@startuml
left to right direction
skinparam actorStyle awesome

actor "Marie - Panadera" as Marie
actor "Sophie - Cajera" as Sophie
actor "Antoine - Manager" as Antoine
actor "Amélie - Clienta fiel" as Amelie
actor "David - Turista" as David

rectangle "Sistema de Panadería" {
  usecase "Actualizar inventario" as UC1
  usecase "Consultar inventario" as UC1b
  usecase "Escalar recetas" as UC2
  usecase "Revisar programa de producción" as UC3

  usecase "Registrar pedidos y pagos" as UC4
  usecase "Aplicar descuentos/recompensas" as UC5
  usecase "Gestionar pedidos desde app móvil" as UC6

  usecase "Visualizar ventas e inventario" as UC7
  usecase "Analizar comportamiento del cliente" as UC8
  usecase "Asignar turnos del personal" as UC9

  usecase "Consultar menú y alérgenos" as UC10
  usecase "Hacer pedidos en línea" as UC11
  usecase "Ver y redimir puntos" as UC12

  usecase "Consultar info de la tienda" as UC13
  usecase "Realizar pedidos y elegir entrega" as UC14
  usecase "Pagar en moneda preferida" as UC15
}

Marie --> UC1
Marie --> UC2
Marie --> UC3
UC1 .> UC1b : <<include>>

Sophie --> UC4
Sophie --> UC5
Sophie --> UC6
UC4 .> UC5 : <<extend>>

Antoine --> UC7
Antoine --> UC8
Antoine --> UC9
UC7 .> UC8 : <<include>>

Amelie --> UC10
Amelie --> UC11
Amelie --> UC12
UC11 .> UC12 : <<extend>>

David --> UC13
David --> UC14
David --> UC15
UC14 .> UC15 : <<include>>
@enduml

```

<img width="500" height="1433" alt="image" src="https://github.com/user-attachments/assets/01db00a6-dee8-4d8e-b4ca-4fed10472b06" />



