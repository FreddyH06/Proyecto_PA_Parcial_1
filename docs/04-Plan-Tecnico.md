# TurnoSmarts
## Fase 3: Plan técnico — Entidades, controladores y arquitectura (Actualizado)

**Responsable:** FreddyH06  
**Revisor:** Alexiho11  
**Metodología:** Spec Driven Development (SDD)  
**Versión:** 0.2  
**Estado:** Pendiente de revisión

### 1. Introducción

El presente documento describe la arquitectura técnica propuesta para desarrollar TurnoSmarts, tomando como referencia las funcionalidades del sistema original Virtual List .NET.

El objetivo es conservar la administración de empresas, sucursales, filas de atención, usuarios, tótems, tickets, citas, notificaciones, seguridad, estadísticas y reportes.

La principal modificación respecto al sistema original será eliminar el almacenamiento permanente en XML y administrar los registros exclusivamente mediante listas de objetos en memoria.

El desarrollo se realizará utilizando C# Windows Forms, programación orientada a objetos, clases TList y consultas LINQ.

### 2. Tecnologías del proyecto

- Lenguaje: C#.
- Plataforma: .NET Framework 4.8.
- Interfaz: Windows Forms.
- Entorno: Visual Studio 2026.
- Control de versiones: Git y GitHub.
- Asistente de programación: GitHub Copilot.
- Metodología: Spec Driven Development.
- Colecciones: List<T>.
- Consultas: LINQ.
- Pruebas: manuales y automatizadas cuando corresponda.

### 3. Estructura del proyecto

El código se organizará en tres carpetas principales.

**Entidades**

Contendrá las clases que representan la información del negocio.

**Controlador**

Contendrá las clases TList y los componentes encargados de la lógica del sistema, seguridad, notificaciones y utilidades.

**Formularios**

Contendrá las ventanas Windows Forms, con sus archivos de diseño y los eventos correspondientes.

No se creará una capa de persistencia XML ni una base de datos.

### 4. Diseño de entidades

Se implementarán siete entidades principales.

#### 4.1. Empresa

Representará la configuración general de la organización.

**Atributos privados:**

- ruc: string
- razonSocial: string
- correo: string
- obligarCedula: bool
- obligarNombre: bool
- obligarCorreo: bool
- obligarTelefono: bool
- smtpServidor: string
- smtpPuerto: int
- smtpUsuario: string
- smtpSsl: bool
- correo365AppId: string
- correo365Tenant: string

Se utilizará un objeto Empresa compartido durante la ejecución.

El objeto contendrá la información institucional y las preferencias de los campos obligatorios.

Las credenciales privadas del servicio de correo no se almacenarán como texto directamente en el código.

#### 4.2. Sucursal

Representará los establecimientos donde se brindará atención.

**Atributos privados:**

- codigo: string
- direccion: string
- telefono: string
- inicioAtencion: string
- finAtencion: string

Cada sucursal podrá tener varias filas.

Los horarios deberán validarse antes de registrar o modificar una sucursal.

#### 4.3. Fila

Representará los servicios de atención ofrecidos por las sucursales.

**Atributos privados:**

- codigo: string
- codigoSucursal: string
- descripcion: string
- tiempoEstimadoMinutos: int
- costoEstimado: decimal
- cantidadVentanillas: int

Cada fila estará asociada a una sucursal.

El tiempo estimado y la cantidad de ventanillas se utilizarán para calcular la disponibilidad de citas y los tiempos aproximados de espera.

#### 4.4. Usuario

Representará a las personas autorizadas a administrar o atender turnos.

**Atributos privados:**

- username: string
- nombre: string
- apellidos: string
- telefono: string
- claveHash: string
- tipoUsuario: string
- codigoSucursal: string
- ventanilla: string
- activo: bool

Los roles iniciales serán ADMINISTRADOR y TRABAJADOR.

La contraseña no se guardará directamente. Se utilizará una función de hash segura y verificación.

Los trabajadores accederán a las funciones autorizadas para su sucursal y ventanilla.

#### 4.5. Totem

Representará un punto de emisión de tickets.

**Atributos privados:**

- codigo: string
- codigoSucursal: string
- ubicacion: string
- codigosFila: List<string>

La colección codigosFila permitirá relacionar el tótem con los servicios habilitados.

Esta colección no sustituirá a las listas administradoras TList.

Un tótem solamente podrá utilizar servicios correspondientes a su sucursal.

#### 4.6. Ticket

Representará tanto los turnos inmediatos como las citas programadas.

**Atributos privados:**

- id: int
- codigoFila: string
- numero: int
- codigoTicket: string
- programado: bool
- cedula: string
- nombres: string
- email: string
- telefono: string
- solicitoRecordatorio: bool
- solicitoSms: bool
- fechaEmision: DateTime
- fechaCita: DateTime
- estado: string
- usuarioAtencion: string
- ventanilla: string
- fechaLlamado: DateTime
- inicioAtencion: DateTime
- finAtencion: DateTime

El atributo programado permitirá identificar las citas reservadas.

Los turnos inmediatos y las citas compartirán la entidad Ticket sin crear una clase adicional.

Se conservarán los registros atendidos para los reportes mientras la aplicación permanezca abierta.

#### 4.7. Recordatorio

Representará los avisos relacionados con los tickets.

**Atributos privados:**

- id: int
- ticketId: int
- tipoEnvio: string
- direccionEnvio: string
- contenido: string
- fechaHoraEnvio: DateTime
- enviado: bool
- resultado: string

Los recordatorios podrán representar notificaciones por correo electrónico y solicitudes de SMS.

Los registros pendientes permanecerán en memoria y podrán consultarse desde su formulario.

### 5. Constructores y propiedades

Todas las entidades deberán mantener el estilo definido para el proyecto de C#:

- Atributos privados.
- Constructor vacío.
- Constructor parametrizado que reciba todos los atributos necesarios.
- Propiedades públicas.
- Métodos específicos cuando sean necesarios.
- Una clase por archivo.

Los nombres y tipos de las propiedades deberán corresponder a sus atributos.

No se agregará lógica de formularios dentro de las entidades.

### 6. Controladores TList

El sistema utilizará seis controladores principales.

| Controlador | Colección |
|---|---|
| TListSucursales | List<Sucursal> |
| TListFilas | List<Fila> |
| TListUsuarios | List<Usuario> |
| TListTotems | List<Totem> |
| TListTickets | List<Ticket> |
| TListRecordatorios | List<Recordatorio> |

Las listas serán compartidas durante la ejecución para que todos los formularios trabajen con los mismos objetos.

La información general de Empresa se administrará mediante un único objeto de configuración en memoria.

### 7. Operaciones de los controladores

Los controladores de catálogos permitirán:

**Agregar:** incorporar un objeto después de verificar sus datos e identificador.

**Modificar:** actualizar un registro existente.

**Eliminar:** quitar un registro cuando las relaciones lo permitan.

**Buscar:** localizar registros utilizando su identificador.

**Obtener:** recuperar un objeto mediante su posición o identificador.

**Listar:** recuperar información para mostrar en los formularios.

Cada clase implementará las operaciones que correspondan a su responsabilidad.

TListTickets tendrá operaciones adicionales para gestionar tickets, reservas y estados de atención.

### 8. Funcionamiento de TListTickets

El controlador TListTickets será responsable de:

- Validar los datos del cliente.
- Generar identificadores y códigos únicos.
- Registrar tickets normales.
- Registrar citas programadas.
- Consultar tickets.
- Verificar disponibilidad de reservas.
- Anular citas permitidas.
- Consultar turnos pendientes.
- Seleccionar el siguiente turno.
- Llamar a un turno.
- Iniciar la atención.
- Finalizar la atención.
- Omitir turnos.
- Reabrir turnos autorizados.
- Conservar el historial durante la ejecución.

La numeración se organizará por fila, fecha y tipo de solicitud, siguiendo el formato establecido en las decisiones técnicas.

Los cambios de estado deberán validarse antes de modificar los objetos.

### 9. Gestión de citas y disponibilidad

Las citas programadas utilizarán el atributo programado de Ticket.

La disponibilidad se calculará teniendo en cuenta:

- La sucursal seleccionada.
- El servicio o fila.
- El horario de atención.
- El tiempo estimado del servicio.
- La cantidad de ventanillas.
- Las reservas existentes.
- La fecha y hora solicitadas.

No se permitirá registrar una cita fuera del horario o cuando no exista capacidad disponible.

Las citas anuladas se conservarán como registro, pero no participarán en la atención.

### 10. Relaciones entre entidades

Las relaciones principales serán:

- Una sucursal podrá tener varias filas.
- Una fila pertenecerá a una sucursal.
- Un usuario podrá estar asociado a una sucursal.
- Un usuario trabajador podrá tener una ventanilla asignada.
- Un tótem pertenecerá a una sucursal.
- Un tótem podrá tener varias filas habilitadas.
- Un ticket pertenecerá a una fila.
- Un ticket podrá relacionarse con un usuario de atención.
- Un ticket podrá tener varios recordatorios.

Las relaciones se implementarán mediante identificadores, y los controladores verificarán su existencia cuando corresponda.

### 11. Seguridad del sistema

El componente Seguridad se ubicará dentro de Controlador.

Será responsable de crear y verificar hashes de contraseñas.

El inicio de sesión validará que el usuario exista, esté activo y tenga las credenciales correctas.

Se establecerá un procedimiento de inicialización para la primera cuenta administradora. No deberán mantenerse contraseñas de demostración inseguras como credenciales definitivas.

El acceso a los formularios se controlará según el rol del usuario.

### 12. Notificaciones por correo electrónico

El componente CorreoInstitucional se ubicará en Controlador.

Permitirá gestionar el envío real de correos mediante un servicio autorizado.

Se contemplará la integración con Outlook clásico o Microsoft Graph, cuando la configuración y los permisos institucionales lo permitan.

Al registrar una cita, el sistema intentará enviar una confirmación al correo del cliente.

La confirmación incluirá:

- Código de la cita.
- Servicio solicitado.
- Sucursal.
- Fecha de reserva.
- Hora de atención.

Cuando se produzca un error de envío, la cita permanecerá registrada y se creará o conservará el aviso pendiente.

No se eliminarán citas por problemas del proveedor de correo.

Las credenciales y tokens deberán manejarse de forma segura y no se incorporarán al repositorio GitHub.

### 13. Gestión de recordatorios y SMS

TListRecordatorios permitirá administrar los avisos pendientes.

Frm_Recordatorios utilizará ese controlador para mostrar los registros y solicitar el envío manual.

El envío real de SMS será opcional y requerirá la configuración de un proveedor autorizado.

No se simulará un envío exitoso cuando el proveedor no esté configurado.

### 14. Componente Utilidades

El componente Utilidades reunirá funciones comunes utilizadas por los formularios.

Entre ellas:

- Presentación de información en DataGridView.
- Exportación manual de reportes a CSV.
- Impresión de tickets.
- Formatos y conversiones auxiliares.
- Funciones de apoyo para notificaciones, cuando corresponda.

Estas funciones no almacenarán permanentemente los registros del sistema.

### 15. Gestión de datos en memoria

El sistema original contenía DatosSistema y Repositorio para guardar y cargar información mediante XML.

En TurnoSmarts se eliminarán esas responsabilidades de persistencia.

La nueva implementación utilizará:

- Un objeto Empresa compartido.
- Seis listas TList estáticas.
- Un mecanismo de inicialización de datos en memoria.
- Un generador de identificadores únicos durante la ejecución.

Se podrá cargar información de prueba al iniciar, cuando sea necesario para verificar los módulos.

No se utilizarán archivos XML ni JSON para guardar o restaurar registros.

Al cerrar la aplicación, los registros creados durante la ejecución se perderán.

### 16. Consultas LINQ

Se utilizará LINQ sobre las listas para implementar:

- Sucursales registradas.
- Servicios por sucursal.
- Usuarios activos e inactivos.
- Tótems por sucursal.
- Tickets pendientes.
- Tickets atendidos.
- Citas por fecha.
- Turnos por ventanilla.
- Cantidades por estado.
- Cantidades por servicio.
- Últimos tickets generados.
- Estadísticas generales.

Se utilizarán operaciones Where, Select, OrderBy, GroupBy, Count, Any, FirstOrDefault y ToList, entre otras.

Los resultados se mostrarán principalmente en controles DataGridView.

### 17. Formularios e integración

La capa Formularios estará formada por las 15 ventanas definidas en las especificaciones:

- Frm_Login.
- Frm_Principal.
- Frm_Dashboard.
- Frm_Empresa.
- Frm_Sucursales.
- Frm_Filas.
- Frm_Usuarios.
- Frm_Totems.
- Frm_Turnos.
- Frm_Citas.
- Frm_Atencion.
- Frm_Reportes.
- Frm_Pantalla.
- Frm_Recordatorios.
- Frm_Perfil.

Cada formulario utilizará los controladores correspondientes.

Los archivos Designer permitirán modificar visualmente los componentes desde Visual Studio.

La pantalla externa compartirá los registros de las listas y se actualizará cada segundo mediante un Timer de Windows Forms.

### 18. Orden de implementación

La generación del código mediante GitHub Copilot seguirá un orden incremental:

1. Crear las entidades y sus propiedades.
2. Implementar los seis controladores TList.
3. Crear el componente de configuración general en memoria.
4. Implementar seguridad e inicialización.
5. Implementar los formularios administrativos.
6. Implementar la generación e impresión de tickets.
7. Implementar las citas y sus validaciones.
8. Implementar el proceso de atención.
9. Implementar la pantalla externa.
10. Implementar correo electrónico y recordatorios.
11. Implementar Dashboard, perfil y reportes.
12. Integrar y comprobar los módulos.

Cada etapa deberá contar con una especificación aprobada y pruebas de funcionamiento.

### 19. Verificación técnica

Durante las pruebas se comprobará:

- Que existan las siete entidades.
- Que sus constructores y propiedades funcionen.
- Que los seis controladores administren correctamente las listas.
- Que no se registren identificadores duplicados.
- Que las relaciones entre entidades sean válidas.
- Que la generación de tickets y reservas funcione.
- Que los cambios de estado se realicen correctamente.
- Que los formularios utilicen los controladores.
- Que todos los componentes visuales sean editables.
- Que las consultas LINQ devuelvan resultados correctos.
- Que la impresión funcione.
- Que la pantalla externa se actualice.
- Que los errores de correo no eliminen registros.
- Que la aplicación funcione sin almacenamiento XML ni base de datos.

### 20. Control de versiones y trabajo colaborativo

Cada integrante realizará sus tareas en ramas independientes.

Los cambios se enviarán mediante commits y Pull Requests.

Antes de integrar una implementación a master, otro integrante deberá revisar el código y comprobar que cumple las especificaciones.

GitHub Actions podrá utilizarse para automatizar la compilación y las verificaciones compatibles con Windows y .NET Framework 4.8.

### 21. Estado del documento

**Proyecto:** TurnoSmarts  
**Responsable:** FreddyH06  
**Revisor:** Alexiho11  
**Versión:** 0.2  
**Estado:** Pendiente de revisión.

Este documento actualiza el plan técnico original para conservar las funcionalidades de Virtual List .NET, reemplazando únicamente el almacenamiento permanente de registros por estructuras List<T> en memoria.

La implementación y las pruebas se realizarán durante las siguientes fases de SDD.