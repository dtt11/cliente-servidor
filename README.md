## 🎮 Aplicación Cliente/Servidor - Sistema de Inventario

📌 Descripción

Este proyecto implementa una aplicación Cliente/Servidor para la empresa ficticia 45GAMES4U, que permite la gestión de inventario de videojuegos y la reserva de títulos por parte de clientes.
El sistema se desarrolla bajo una arquitectura en capas utilizando C# .NET 8.0, Windows Forms, Sockets TCP y una base de datos SQL Server.

## 🚀 Funcionalidades

- Crear, leer, actualizar y eliminar productos
- Comunicación cliente-servidor (Sockets TCP)
- Validación de Datos y Manejo de Excepciones en formularios
- Reservas de Videojuegos
- Arquitectura en capas
- Conexión con base de datos SQL Server

⚙️ Requisitos de software

Visual Studio Community 2022
.NET 8.0
SQL Server (con seguridad integrada de Windows)
Script de creación de base de datos 

🏗️ Arquitectura del sistema

El sistema está compuesto por dos soluciones principales:
1. Servidor

Gestiona la base de datos SQL Server.
Maneja hasta 5 conexiones simultáneas de clientes.
Muestra bitácora de eventos en tiempo real (conexiones, reservas, consultas, etc.).

Permite al administrador:
Registrar y consultar Tipos de Videojuegos
Registrar y consultar Videojuegos
Registrar y consultar Administradores de Tiendas
Registrar y consultar Tiendas
Registrar y consultar Clientes
Registrar y consultar Inventario (Videojuegos por Tienda)
Registrar Reservas de Videojuegos

2. Cliente

Se conecta al servidor mediante TCP.
Requiere validación con número de identificación.

Permite al cliente:
Reservar videojuegos por tienda
Consultar sus reservas (todas o por ID)

🗄️ Entidades principales

TipoVideojuegoEntidad
VideojuegoEntidad
AdministradorEntidad
TiendaEntidad
ClienteEntidad
VideojuegosXTiendaEntidad
ReservaEntidad
(Opcional) PersonaEntidad para herencia entre Administrador y Cliente


▶️ Ejecución del sistema

1-Iniciar el Servidor

2-Ejecutar la aplicación servidor.

3-Configurar la base de datos con el script oficial.

4-Verificar que el servidor escuche en 127.0.0.1:14100.

5-Conectar Clientes

6-Ejecutar la aplicación cliente.

7-Ingresar el número de identificación previamente registrado.

8-Realizar reservas y consultas disponibles.


🧑‍💻 Autor
Daniel Tapia Traña – Diplomado en informática
