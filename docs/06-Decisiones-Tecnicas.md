# TurnoSmarts
## Fase 3: Decisiones técnicas y alcance completo del sistema

**Responsable:** FreddyH06  
**Colaborador y revisor:** Alexiho11  
**Metodología:** Spec Driven Development (SDD)  
**Versión:** 0.2  
**Estado:** Pendiente de revisión y aprobación

### 1. Objetivo

Establecer las decisiones técnicas definitivas propuestas para TurnoSmarts, conservando las funcionalidades del sistema original Virtual List .NET y adaptando su arquitectura para utilizar exclusivamente listas de objetos en memoria.

La implementación deberá conservar las funcionalidades de administración, generación de turnos, gestión de citas, atención, impresión, estadísticas, notificaciones y reportes.

El código será generado con apoyo de inteligencia artificial a partir de los requerimientos y especificaciones aprobados.

### 2. Tecnologías y arquitectura

- Lenguaje: C#.
- Plataforma: .NET Framework 4.8.
- Interfaz: Windows Forms.
- Entorno: Visual Studio 2026.
- Programación orientada a objetos.
- Almacenamiento temporal: List<T>.
- Consultas: LINQ.
- Control de versiones: Git y GitHub.
- Generación de código: GitHub Copilot.
- Metodología: Spec Driven Development.

La aplicación se organizará en Entidades, Controlador y Formularios.

No se utilizarán archivos XML, JSON ni bases de datos para almacenar permanentemente los registros del sistema.

### 3. Entidades del sistema

Se conservarán las siete entidades del sistema original.

**Empresa**

Configuración general de la organización, incluyendo RUC, razón social, correo, configuración de campos obligatorios y parámetros de correo electrónico.

**Sucursal**

Código, dirección, teléfono y horarios de inicio y finalización de atención.

**Fila**

Código, sucursal, descripción del servicio, tiempo estimado por atención, costo estimado y cantidad de ventanillas.

**Usuario**

Nombre de usuario, nombre, apellidos, teléfono, contraseña protegida mediante hash, tipo de usuario, sucursal, ventanilla y estado activo.

**Totem**

Código, sucursal, ubicación y servicios o filas asociados.

**Ticket**

Identificador, fila, número, código de ticket, indicador de cita programada, cédula, nombres, correo, teléfono, solicitudes de recordatorio y SMS, fecha de emisión, fecha de cita, estado, usuario de atención, ventanilla, fecha de llamado, inicio y finalización de atención.

**Recordatorio**

Identificador, ticket asociado, tipo de envío, destinatario, contenido, fecha de envío programada, indicador de enviado y resultado.

Cada entidad tendrá atributos privados, constructor vacío, constructor parametrizado y propiedades públicas, siguiendo el estilo establecido para las clases de C# del proyecto.

### 4. Controladores

Se conservarán los seis controladores TList principales del sistema original:

- TListSucursales.
- TListFilas.
- TListUsuarios.
- TListTotems.
- TListTickets.
- TListRecordatorios.

Cada controlador administrará su correspondiente List<T> y sus operaciones de registro, modificación, eliminación, búsqueda y consulta, según las reglas de negocio.

La información de Empresa se manejará como configuración general en memoria, de acuerdo con el diseño original. Si se decide administrar múltiples empresas, deberá ampliarse esta especificación y el modelo de datos antes de programar.

También se conservarán las responsabilidades de Seguridad, CorreoInstitucional y Utilidades.

No se utilizará la persistencia XML del Repositorio original. Cualquier inicialización necesaria se realizará directamente en memoria.

### 5. Formularios obligatorios

Se implementarán los 15 formularios presentes en el sistema original:

1. **Frm_Login:** acceso de administradores, trabajadores y opción pública para solicitar turnos.
2. **Frm_Principal:** menú general de navegación según el rol.
3. **Frm_Dashboard:** estadísticas generales y últimos tickets registrados.
4. **Frm_Empresa:** configuración de la empresa y datos institucionales.
5. **Frm_Sucursales:** registro y administración de sucursales.
6. **Frm_Filas:** administración de servicios, tiempos estimados, costos y ventanillas.
7. **Frm_Usuarios:** administración de cuentas de usuario y permisos.
8. **Frm_Totems:** administración de dispositivos y servicios asociados.
9. **Frm_Turnos:** emisión e impresión de tickets normales.
10. **Frm_Citas:** registro, consulta y anulación de citas.
11. **Frm_Atencion:** llamada, inicio, finalización, omisión y reapertura de turnos.
12. **Frm_Reportes:** consultas, filtros y exportación CSV.
13. **Frm_Pantalla:** visualización externa de los turnos y tiempos de espera.
14. **Frm_Recordatorios:** administración y envío manual de notificaciones pendientes.
15. **Frm_Perfil:** cambio de contraseña del usuario activo.

Todos los formularios contarán con controles reales y editables mediante el diseñador de Windows Forms.

Se mantendrán separados los archivos de eventos y los archivos Designer.

### 6. Inicio de sesión y seguridad

El sistema tendrá dos roles principales: Administrador y Trabajador.

El administrador podrá administrar los catálogos, usuarios, configuración y reportes.

El trabajador podrá atender turnos desde los servicios y ventanillas autorizados.

Se permitirá cambiar la contraseña desde Frm_Perfil, comprobando la contraseña anterior y la nueva.

Las contraseñas de usuarios se almacenarán en memoria mediante representaciones hash seguras.

Deberá existir un procedimiento de inicialización de la primera cuenta administradora para acceder a la aplicación.

### 7. Administración de tickets

El usuario podrá seleccionar la sucursal y el servicio correspondiente.

El sistema validará los datos obligatorios configurados por la empresa.

Los tickets normales se generarán para la fecha actual.

Cada ticket contará con una identificación única y una numeración diaria por fila.

Se conservará el formato original de referencia:

- Turno normal: ODO-20261023-1.
- Cita programada: R-ODO-20261023-1.

La numeración será independiente para turnos inmediatos y citas programadas dentro de la fila y fecha correspondiente.

Los tickets podrán imprimirse utilizando las funciones de impresión de Windows.

### 8. Gestión de citas

Las citas se representarán mediante la entidad Ticket, utilizando el atributo Programado.

Las reservas permitirán:

- Seleccionar sucursal y servicio.
- Registrar los datos del usuario.
- Seleccionar fecha y hora futura.
- Comprobar el horario de atención.
- Verificar la capacidad según las ventanillas.
- Registrar la reserva.
- Consultar mediante cédula y código.
- Anular citas pendientes.

Las citas anuladas conservarán su información en memoria, pero no participarán en la atención.

La validación de disponibilidad tendrá en cuenta el tiempo estimado de cada servicio y la cantidad de ventanillas.

### 9. Administración de turnos y prioridades

Los estados del proceso serán:

- PENDIENTE.
- LLAMADO.
- EN ATENCION.
- ATENDIDO.
- OMITIDO.
- ANULADO, para las citas que correspondan.

La atención seguirá las transiciones autorizadas.

Los tickets normales se organizarán según su orden de emisión.

Las citas programadas del día podrán incorporarse a la cola cuando falten 15 minutos o menos para su horario reservado.

Las citas habilitadas tendrán prioridad de acuerdo con el orden definido para el servicio.

Se permitirá llamar el siguiente turno, iniciar la atención, finalizar, omitir y reabrir cuando corresponda.

No se podrá finalizar un turno que todavía no haya iniciado su atención.

Los tickets atendidos se conservarán para los reportes mientras permanezca abierta la aplicación.

### 10. Pantalla externa

Frm_Pantalla será una ventana independiente dentro de la misma aplicación.

La información se actualizará cada 1000 milisegundos mediante un Timer de Windows Forms.

Mostrará:

- Turno actual.
- Ventanilla de atención.
- Turnos pendientes.
- Historial reciente de llamados.
- Cantidad de tickets en espera.
- Cantidad de turnos atendidos.
- Tiempo estimado de espera.
- Citas del día todavía no habilitadas.

El tiempo de espera se calculará aproximadamente utilizando los turnos pendientes, el tiempo estimado por servicio y las ventanillas disponibles.

La pantalla podrá maximizarse para un segundo monitor.

No se abrirán copias innecesarias de la misma ventana externa.

### 11. Notificaciones y recordatorios

Al registrar una cita válida se generará su confirmación.

El sistema intentará enviar automáticamente la confirmación por correo electrónico cuando el servicio esté configurado y autorizado.

La confirmación incluirá el código, servicio, sucursal, fecha y hora.

Si el correo falla, la cita permanecerá registrada y su confirmación quedará pendiente.

Frm_Recordatorios permitirá consultar y enviar manualmente los recordatorios.

Se contemplará el correo electrónico y la opción SMS. El envío real de SMS requerirá un proveedor y credenciales autorizadas.

Para correo institucional se podrán estudiar las opciones compatibles de Outlook clásico o Microsoft Graph.

No se escribirán contraseñas, tokens ni otras credenciales privadas directamente en el código fuente.

La aceptación de un correo por el proveedor no garantizará su entrega final al destinatario.

### 12. Dashboard y reportes

Frm_Dashboard mostrará:

- Número de sucursales.
- Número de servicios o filas.
- Tickets emitidos durante el día.
- Turnos pendientes.
- Últimos tickets registrados.

Frm_Reportes permitirá:

- Filtrar por fecha.
- Consultar por servicio.
- Consultar por sucursal.
- Filtrar por estado.
- Ordenar registros.
- Contabilizar turnos.
- Mostrar información mediante DataGridView.
- Exportar manualmente los resultados a CSV.

Las consultas se realizarán utilizando LINQ sobre las listas administradas en memoria.

### 13. Gestión exclusivamente en memoria

Todos los registros del sistema utilizarán List<T>.

Los formularios compartirán los datos mediante los controladores durante una misma ejecución.

No habrá almacenamiento permanente de registros.

Al cerrar y volver a abrir TurnoSmarts se perderán los datos registrados durante la ejecución anterior.

Por lo tanto, las pruebas de persistencia XML del sistema original se reemplazarán por pruebas que comprueben el funcionamiento correcto de las listas y su reinicialización.

Los archivos CSV serán exportaciones de reportes, no un mecanismo para restaurar la información del sistema.

### 14. Diseño de los formularios

Los formularios deberán contar con controles visibles y funcionales.

Se utilizarán TextBox, ComboBox, Button, Label, DataGridView, DateTimePicker, Timer y los controles necesarios según cada módulo.

Se mantendrá un diseño sencillo.

Los componentes deberán poder modificarse desde el diseñador de Visual Studio.

Los eventos de los botones y controles deberán funcionar correctamente, evitando formularios que solo tengan una apariencia visual sin implementar sus operaciones.

### 15. Verificación y pruebas

Antes de considerar terminado el sistema, deberán comprobarse:

1. Inicio de sesión correcto e incorrecto.
2. Cambio de contraseña.
3. Registro y administración de sucursales.
4. Registro de servicios con tiempos, costos y ventanillas.
5. Administración de usuarios y permisos.
6. Configuración de tótems.
7. Generación de tickets y numeración diaria.
8. Impresión de tickets.
9. Registro de citas futuras.
10. Rechazo de horarios no disponibles.
11. Consulta y anulación de citas.
12. Llamada e inicio de atención.
13. Finalización y omisión de turnos.
14. Reapertura de turnos autorizados.
15. Actualización automática de pantalla externa.
16. Estadísticas del Dashboard.
17. Envío o registro pendiente de confirmaciones de correo.
18. Administración de recordatorios y opciones SMS.
19. Consultas LINQ y exportación CSV.
20. Visualización de todos los formularios en el diseñador.
21. Funcionamiento sin bases de datos ni XML.
22. Conservación de los datos durante la ejecución y pérdida de los registros al cerrar.

### 16. Implementación mediante SDD

La implementación se dividirá en módulos y tareas pequeñas.

GitHub Copilot generará código a partir de las especificaciones aprobadas.

Cada integrante trabajará en su propia rama.

Se revisará el código generado antes de incorporarlo a master.

Se utilizarán pruebas manuales y GitHub Actions cuando sean técnicamente viables.

El código generado deberá cumplir los requerimientos establecidos y no podrá eliminar funcionalidades sin aprobación del equipo.

### 17. Control de cambios

Las especificaciones de las fases anteriores deberán actualizarse para coincidir con este alcance, especialmente en:

- Las 15 ventanas y sus nombres.
- Las 7 entidades y 6 TList principales.
- La configuración de Empresa.
- Los atributos de Fila y Ticket.
- La impresión de tickets.
- El Dashboard y Frm_Perfil.
- Los formatos de numeración.
- La pantalla externa y su intervalo de actualización.
- La confirmación automática de citas.
- Los recordatorios y opciones SMS.

Si alguna decisión entra en conflicto con los documentos anteriores, deberá corregirse expresamente antes de implementar el módulo.

### 18. Aprobación

**Proyecto:** TurnoSmarts  
**Responsable:** FreddyH06  
**Revisor:** Alexiho11  
**Estado:** Pendiente de revisión.

Este documento representa el alcance completo propuesto para conservar las funcionalidades del sistema original, sustituyendo únicamente su almacenamiento permanente por estructuras List<T> en memoria.

Su aprobación no constituye todavía una prueba de funcionamiento. El código generado deberá compilarse, ejecutarse y verificarse posteriormente.