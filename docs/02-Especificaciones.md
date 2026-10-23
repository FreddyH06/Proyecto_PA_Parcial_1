# TurnoSmarts
## Fase 2: Especificaciones funcionales — Parte 1 (Actualizada)

**Responsable:** FreddyH06  
**Revisor:** Alexiho11  
**Metodología:** Spec Driven Development (SDD)  
**Versión:** 0.2  
**Estado:** Actualización pendiente de revisión

### 1. Introducción

TurnoSmarts es un sistema de escritorio para gestionar empresas, sucursales, servicios, usuarios, tótems, tickets y citas de atención.

Esta versión de las especificaciones incorpora las funcionalidades administrativas del sistema original Virtual List .NET, manteniendo su funcionamiento principal y adaptándolo a las decisiones técnicas del proyecto.

La aplicación se desarrollará en C# Windows Forms con .NET Framework 4.8, utilizando programación orientada a objetos, estructuras List<T> y consultas LINQ.

A diferencia del sistema original, no se utilizarán bases de datos ni archivos XML para guardar los registros. Toda la información permanecerá en memoria durante la ejecución.

### 2. Objetivo

Definir de manera detallada el comportamiento que deberán cumplir los módulos administrativos, de seguridad y de configuración de TurnoSmarts.

Estas especificaciones servirán para generar posteriormente el código mediante inteligencia artificial, siguiendo la metodología Spec Driven Development.

### 3. EF01. Configuración de empresa (RF01)

El sistema permitirá administrar la configuración general de la empresa desde Frm_Empresa.

**Información que se administrará:**

- RUC.
- Razón social.
- Correo electrónico institucional.
- Campos obligatorios para solicitar turnos.
- Parámetros de configuración del correo.
- Identificador de aplicación Microsoft 365, cuando corresponda.
- Identificador del directorio institucional, cuando corresponda.

**Reglas de negocio:**

- El RUC y la razón social serán obligatorios.
- La configuración general corresponderá a una empresa principal.
- El administrador podrá modificar la información institucional.
- Se permitirá definir si la cédula, nombre, correo y teléfono son obligatorios al solicitar tickets.
- Los cambios en los campos obligatorios deberán aplicarse a la generación de turnos y citas.
- No se almacenarán contraseñas de correo directamente en el código fuente.
- El sistema permitirá realizar una prueba de envío cuando exista un servicio de correo autorizado.

**Criterios de aceptación:**

- Se puede consultar y modificar la configuración de la empresa.
- El sistema rechaza información obligatoria incompleta.
- Los campos configurados como obligatorios se validan al generar tickets.
- El administrador puede realizar una prueba del servicio de correo.
- Una falla del correo no elimina ni altera otros registros.

### 4. EF02. Administración de sucursales (RF02)

El sistema permitirá registrar, modificar, eliminar y consultar sucursales desde Frm_Sucursales.

**Atributos:**

- Codigo.
- Direccion.
- Telefono.
- InicioAtencion.
- FinAtencion.

**Reglas de negocio:**

- Cada sucursal tendrá un código único.
- No se permitirán códigos duplicados.
- Se deberá registrar una dirección válida.
- La hora de inicio deberá ser anterior a la hora de finalización.
- Las sucursales podrán tener varias filas o servicios.
- No se permitirá eliminar una sucursal que tenga registros relacionados que deban conservarse.
- Las modificaciones se actualizarán en los listados y ComboBox correspondientes.

**Criterios de aceptación:**

- Una sucursal válida se registra correctamente.
- Se rechaza una sucursal con código repetido.
- Los horarios inválidos generan una advertencia.
- Se pueden consultar y modificar los registros.
- Se respetan las relaciones entre sucursales y servicios.

### 5. EF03. Administración de filas y servicios (RF03)

El sistema permitirá configurar los servicios de atención disponibles desde Frm_Filas.

**Atributos:**

- Codigo.
- CodigoSucursal.
- Descripcion.
- TiempoEstimadoMinutos.
- CostoEstimado.
- CantidadVentanillas.

**Reglas de negocio:**

- Cada fila tendrá un identificador único.
- Cada fila pertenecerá a una sucursal existente.
- La descripción del servicio será obligatoria.
- El tiempo estimado deberá ser mayor que cero.
- El costo estimado no podrá ser negativo.
- La cantidad de ventanillas deberá ser mayor que cero.
- El tiempo estimado y la cantidad de ventanillas servirán para calcular la disponibilidad de citas.
- Los tickets estarán asociados con la fila correspondiente.
- No se eliminarán servicios que tengan registros relacionados sin aplicar las reglas de integridad definidas.

**Criterios de aceptación:**

- Se pueden registrar servicios válidos.
- El sistema rechaza códigos duplicados.
- No se permite registrar un servicio sin sucursal.
- Se validan los tiempos, costos y ventanillas.
- Los servicios aparecen correctamente en los ComboBox.
- La capacidad configurada se utiliza para validar las reservas.

### 6. EF04. Administración de usuarios (RF04)

El sistema permitirá administrar los usuarios desde Frm_Usuarios.

**Atributos:**

- Username.
- Nombre.
- Apellidos.
- Telefono.
- ClaveHash.
- TipoUsuario.
- CodigoSucursal.
- Ventanilla.
- Activo.

**Reglas de negocio:**

- Cada usuario tendrá un nombre de usuario único.
- No se permitirán usuarios duplicados.
- Los usuarios tendrán los roles Administrador o Trabajador.
- Los trabajadores estarán asociados a una sucursal y ventanilla cuando corresponda.
- Las contraseñas se protegerán mediante un mecanismo de hash seguro.
- No se mostrarán contraseñas en los DataGridView.
- Los usuarios inactivos no podrán iniciar sesión.
- Las contraseñas nuevas deberán cumplir las reglas de seguridad establecidas.
- Solo los administradores podrán gestionar las cuentas de otros usuarios.

**Criterios de aceptación:**

- Se pueden registrar usuarios válidos.
- Se rechazan nombres de usuario duplicados.
- Los trabajadores tienen acceso limitado.
- Los administradores acceden a los módulos autorizados.
- No se permite iniciar sesión con una contraseña incorrecta.
- Las cuentas inactivas no pueden acceder al sistema.

### 7. EF05. Inicio de sesión y perfil

TurnoSmarts contará con Frm_Login y Frm_Perfil.

**Frm_Login permitirá:**

- Ingresar nombre de usuario y contraseña.
- Comprobar credenciales.
- Identificar el rol.
- Abrir Frm_Principal.
- Acceder al flujo público de solicitud de turnos cuando corresponda.
- Mostrar mensajes ante credenciales incorrectas.

**Frm_Perfil permitirá:**

- Consultar información del usuario activo.
- Cambiar su contraseña.
- Validar la contraseña anterior.
- Confirmar la nueva contraseña.
- Actualizar la contraseña protegida mediante hash.

**Criterios de aceptación:**

- El acceso funciona con credenciales válidas.
- Las credenciales incorrectas son rechazadas.
- Las opciones del menú dependen del rol.
- La contraseña se puede modificar correctamente.
- La nueva contraseña permite iniciar sesión.
- No se muestran contraseñas sin protección.

### 8. EF06. Administración de tótems (RF05)

El sistema permitirá configurar tótems desde Frm_Totems.

**Atributos:**

- Codigo.
- CodigoSucursal.
- Ubicacion.
- CodigosFila.

**Reglas de negocio:**

- Cada tótem tendrá un código único.
- Cada tótem estará asociado a una sucursal existente.
- Se podrán seleccionar las filas o servicios habilitados.
- Un tótem podrá tener varios servicios asociados.
- No se permitirá asociar un servicio perteneciente a otra sucursal.
- Los servicios asociados podrán consultarse y modificarse.
- Se utilizarán controles gráficos para seleccionar las filas correspondientes.

**Criterios de aceptación:**

- Se puede registrar un tótem válido.
- Se rechazan códigos duplicados.
- Los servicios mostrados corresponden a la sucursal seleccionada.
- Se pueden modificar los servicios asociados.
- Un tótem no puede generar tickets para servicios inexistentes.

### 9. EF07. Generación de tickets (RF06)

El sistema permitirá generar tickets inmediatos desde Frm_Turnos.

**Información requerida:**

- Sucursal.
- Servicio o fila.
- Cédula, cuando sea obligatoria.
- Nombre, cuando sea obligatorio.
- Correo electrónico, cuando sea obligatorio.
- Teléfono, cuando sea obligatorio.

**Reglas de negocio:**

- Cada ticket tendrá un identificador interno único.
- La numeración será diaria e independiente por fila.
- Se utilizará un código visible con el prefijo del servicio.
- Los tickets normales se diferenciarán de las citas programadas.
- El estado inicial será PENDIENTE.
- Cada ticket registrará su fecha y hora de emisión.
- Se permitirá imprimir el ticket mediante las funciones de impresión de Windows.
- Los datos obligatorios dependerán de la configuración de la empresa.
- Los tickets permanecerán disponibles en memoria mientras la aplicación esté abierta.

**Criterios de aceptación:**

- Se genera un ticket válido.
- No existen identificadores duplicados.
- Los números se generan consecutivamente según la fila y fecha.
- Se permite imprimir el ticket.
- El ticket aparece en la lista de pendientes del servicio.
- Los datos incompletos generan advertencias cuando son obligatorios.

### 10. EF08. Dashboard y estadísticas

El sistema contará con Frm_Dashboard para mostrar información general.

**Información que presentará:**

- Cantidad de sucursales.
- Cantidad de filas o servicios.
- Tickets emitidos durante el día.
- Turnos pendientes.
- Últimos tickets registrados.

**Reglas de negocio:**

- Los resultados se calcularán utilizando las listas.
- Se utilizará LINQ para obtener conteos y filtros.
- Los datos deberán actualizarse cuando se solicite refrescar el panel.
- Los valores deberán coincidir con los registros existentes.

**Criterios de aceptación:**

- Las estadísticas muestran información correcta.
- Los conteos cambian al generar o atender tickets.
- Los últimos tickets aparecen en orden.
- El panel no produce errores cuando las listas están vacías.

### 11. Relaciones entre entidades

Se utilizarán las siguientes relaciones:

- Empresa representará la configuración institucional.
- Una sucursal podrá tener varias filas.
- Una fila pertenecerá a una sucursal.
- Un usuario podrá estar asociado a una sucursal y ventanilla.
- Un tótem pertenecerá a una sucursal.
- Un tótem podrá tener varios códigos de fila asociados.
- Un ticket pertenecerá a una fila.
- Un ticket podrá representar un turno inmediato o una cita programada.
- Un ticket podrá tener recordatorios relacionados.

Las relaciones se administrarán mediante los identificadores correspondientes y las clases controladoras.

### 12. Controladores TList

Se conservarán los seis controladores principales del sistema original:

- TListSucursales.
- TListFilas.
- TListUsuarios.
- TListTotems.
- TListTickets.
- TListRecordatorios.

Estos controladores administrarán los objetos mediante List<T> y realizarán las operaciones necesarias para cada módulo.

La configuración de Empresa se administrará como un único objeto en memoria, manteniendo el comportamiento propuesto para el sistema original.

### 13. Funcionalidades complementarias obligatorias

Además de los módulos administrativos anteriores, TurnoSmarts conservará:

- Registro y anulación de citas.
- Validación de disponibilidad de horarios.
- Atención desde ventanillas.
- Llamada del siguiente turno.
- Inicio y finalización de atención.
- Omisión y reapertura de turnos.
- Pantalla externa actualizada cada segundo.
- Estimación de tiempos de espera.
- Confirmación automática de citas mediante correo cuando el servicio esté configurado.
- Recordatorios adicionales y opción de SMS.
- Reportes utilizando LINQ.
- Exportación manual de reportes a CSV.

Estas funcionalidades se desarrollan con mayor detalle en `03-Especificaciones-Atencion.md` y `06-Decisiones-Tecnicas.md`. Ambos documentos deberán mantenerse coherentes con esta actualización.

### 14. Formularios del sistema

La aplicación conservará los 15 formularios establecidos en el sistema original:

1. Frm_Login.
2. Frm_Principal.
3. Frm_Dashboard.
4. Frm_Empresa.
5. Frm_Sucursales.
6. Frm_Filas.
7. Frm_Usuarios.
8. Frm_Totems.
9. Frm_Turnos.
10. Frm_Citas.
11. Frm_Atencion.
12. Frm_Reportes.
13. Frm_Pantalla.
14. Frm_Recordatorios.
15. Frm_Perfil.

Todos tendrán controles visibles, editables y funcionales desde el diseñador de Visual Studio.

### 15. Requerimientos no funcionales

- Desarrollo en C# Windows Forms.
- Uso de .NET Framework 4.8.
- Programación orientada a objetos.
- Entidades con atributos privados, constructores y propiedades.
- Uso de List<T> para administrar registros.
- Uso de LINQ para consultas.
- Separación de Entidades, Controlador y Formularios.
- Componentes editables mediante el diseñador.
- Validación de los datos antes de modificar registros.
- Sin almacenamiento permanente de registros.
- Control de versiones mediante Git y GitHub.
- Generación de código con apoyo de inteligencia artificial.
- Revisión del código generado antes de integrarlo a master.

### 16. Plan de verificación

Durante la fase de pruebas se comprobará:

1. Configuración de empresa.
2. Registro y modificación de sucursales.
3. Validación de horarios.
4. Registro de servicios y ventanillas.
5. Administración de usuarios.
6. Inicio de sesión y permisos.
7. Cambio de contraseña.
8. Configuración de tótems.
9. Generación y numeración de tickets.
10. Impresión de tickets.
11. Registro y anulación de citas.
12. Gestión de estados de atención.
13. Actualización de pantalla externa.
14. Estadísticas del Dashboard.
15. Correos de confirmación y recordatorios.
16. Consultas LINQ.
17. Exportación de reportes.
18. Funcionamiento de todos los formularios.
19. Administración temporal de información con List<T>.

### 17. Estado del documento

**Proyecto:** TurnoSmarts  
**Responsable:** FreddyH06  
**Versión:** 0.2  
**Estado:** Pendiente de revisión por Alexiho11.

Esta actualización sustituye las especificaciones administrativas anteriores para incorporar el alcance completo del sistema original, respetando las decisiones técnicas aprobadas.

El código todavía no ha sido generado ni verificado. Su implementación deberá seguir las especificaciones mediante la metodología SDD.