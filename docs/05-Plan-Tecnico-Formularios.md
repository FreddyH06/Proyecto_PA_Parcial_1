\# TurnoSmarts

\## Fase 3: Plan técnico — Parte 2



\*\*Responsable:\*\* Alexiho11  

\*\*Metodología:\*\* Spec Driven Development (SDD)  

\*\*Versión:\*\* 0.1  

\*\*Estado:\*\* Propuesta pendiente de revisión



\### 1. Introducción



Este documento establece la planificación técnica de los formularios y procesos de atención del sistema TurnoSmarts.



Su propósito es definir cómo se implementarán las interfaces gráficas, las operaciones de los usuarios y la comunicación entre los formularios y las clases administradoras TList.



La implementación se realizará posteriormente con apoyo de inteligencia artificial, utilizando las especificaciones funcionales y técnicas previamente definidas.



Este documento complementa el plan técnico de entidades y controladores elaborado por FreddyH06.



\### 2. Tecnologías



El sistema utilizará:



\- Lenguaje de programación: C#.

\- Plataforma: .NET Framework 4.8.

\- Interfaz gráfica: Windows Forms.

\- Entorno de desarrollo: Visual Studio 2026.

\- Administración de datos: List<T>.

\- Consultas: LINQ.

\- Control de versiones: Git y GitHub.

\- Asistente de programación: GitHub Copilot.

\- Metodología: Spec Driven Development.



No se implementarán bases de datos ni mecanismos de persistencia de registros.



\### 3. Diseño de formularios



Los formularios permitirán administrar las funciones del sistema mediante componentes gráficos visibles y editables desde el diseñador de Visual Studio.



\#### 3.1. Frm\_Login



Permitirá el acceso al sistema mediante las credenciales de los usuarios.



\*\*Componentes propuestos:\*\*

\- TextBox para usuario.

\- TextBox para contraseña.

\- Button para iniciar sesión.

\- Label para mensajes de validación.



El sistema comprobará las credenciales y verificará los permisos correspondientes al rol del usuario.



La gestión de credenciales deberá definirse antes de implementar este módulo.



\#### 3.2. Frm\_Principal



Será la ventana principal para acceder a los módulos del sistema.



\*\*Contendrá:\*\*

\- Menú de navegación.

\- Botones de acceso a los módulos.

\- Información del usuario activo.

\- Opción para cerrar sesión.



Los módulos disponibles dependerán del rol del usuario.



\#### 3.3. Frm\_Empresas



Permitirá registrar, modificar, eliminar y consultar empresas.



Utilizará controles TextBox, Button y DataGridView para administrar la información mediante TListEmpresa.



Las operaciones deberán respetar las reglas de validación establecidas en la especificación EF01.



\#### 3.4. Frm\_Sucursales



Permitirá administrar las sucursales de las empresas.



Utilizará ComboBox para seleccionar empresas, TextBox para los datos y DataGridView para mostrar los registros existentes.



Se comunicará con TListSucursal y TListEmpresa.



\#### 3.5. Frm\_Filas



Permitirá configurar los servicios y las filas disponibles.



Utilizará ComboBox, TextBox, Button y DataGridView.



Los registros serán administrados mediante TListFila.



Cada fila deberá estar asociada a una sucursal y al servicio correspondiente.



\#### 3.6. Frm\_Usuarios



Permitirá registrar y administrar los usuarios del sistema.



Se utilizarán TextBox para los datos, ComboBox para seleccionar el rol, Button para las operaciones y DataGridView para los listados.



Se comunicará con TListUsuario.



El acceso a las funciones estará condicionado por los permisos de cada usuario.



\#### 3.7. Frm\_Totems



Permitirá configurar los tótems asociados a las sucursales.



Contendrá controles para seleccionar una sucursal, registrar los datos del tótem y consultar los registros existentes.



Se utilizará TListTotem.



\#### 3.8. Frm\_GenerarTicket



Permitirá solicitar tickets de atención.



El usuario seleccionará el servicio correspondiente y el sistema generará el turno mediante TListTicket.



La pantalla mostrará el identificador del ticket y la información del servicio solicitado.



Los nuevos tickets tendrán inicialmente el estado Pendiente.



\#### 3.9. Frm\_Citas



Permitirá registrar, consultar y cancelar citas.



\*\*Componentes propuestos:\*\*

\- TextBox para datos del cliente.

\- ComboBox para seleccionar sucursal y servicio.

\- DateTimePicker para fecha y hora.

\- Button para registrar y cancelar citas.

\- DataGridView para consultar los registros.



Antes de registrar una cita se validarán los datos, los horarios y la disponibilidad del servicio.



Se utilizará TListTicket si se confirma que Ticket también representará las citas.



La decisión sobre la entidad que almacenará las citas deberá resolverse antes de generar código.



\#### 3.10. Frm\_Atencion



Permitirá administrar los turnos desde las ventanillas.



\*\*Contendrá botones para:\*\*

\- Llamar turno.

\- Iniciar atención.

\- Finalizar atención.

\- Omitir turno.

\- Reabrir turno.



Además, tendrá controles para seleccionar la fila y la ventanilla, así como una tabla para consultar los turnos.



Las operaciones modificarán los estados de los tickets mediante los controladores.



\#### 3.11. Frm\_PantallaTurnos



Será una ventana independiente para visualizar los turnos llamados y pendientes.



\*\*Mostrará:\*\*

\- Código del turno llamado.

\- Ventanilla correspondiente.

\- Turnos pendientes.

\- Estado de atención.



La información se actualizará utilizando los registros disponibles en las listas durante la ejecución.



La pantalla deberá ejecutarse dentro de la misma aplicación para compartir las listas en memoria.



La ventana podrá maximizarse para utilizarse en una pantalla externa.



\#### 3.12. Frm\_Recordatorios



Permitirá administrar las notificaciones relacionadas con citas y tickets.



\*\*Contendrá:\*\*

\- Listado de recordatorios.

\- Información del destinatario.

\- Estado del envío.

\- Botón para enviar notificaciones.

\- Mensajes de confirmación o error.



Se utilizará TListRecordatorio.



El envío de correos necesitará una configuración autorizada del servicio correspondiente.



\#### 3.13. Frm\_Reportes



Permitirá consultar la información mediante LINQ.



\*\*Se utilizarán:\*\*

\- ComboBox para seleccionar filtros.

\- DateTimePicker para consultar fechas.

\- Button para ejecutar consultas.

\- DataGridView para mostrar resultados.



Se contemplarán reportes de citas, tickets, estados y servicios.



La exportación manual a CSV será opcional y no se utilizará para restaurar registros.



\### 4. Comunicación entre formularios y controladores



Los formularios no administrarán directamente las listas del sistema.



Cada formulario utilizará las clases TList para registrar, consultar, modificar y eliminar objetos.



Los controladores realizarán las operaciones sobre List<T>, mientras que los formularios se encargarán de presentar la información al usuario.



De esta manera se mantendrá separada la lógica del sistema de su interfaz gráfica.



\### 5. Gestión de citas



El proceso propuesto será:



1\. Seleccionar una sucursal.

2\. Seleccionar un servicio.

3\. Ingresar los datos del cliente.

4\. Seleccionar una fecha y hora.

5\. Validar la disponibilidad.

6\. Registrar la cita.

7\. Generar una confirmación.

8\. Incorporar el registro a la lista correspondiente.



La estructura definitiva dependerá de la decisión sobre si se utilizará Ticket para representar las citas o una entidad Cita independiente.



No se permitirá registrar citas en horarios no disponibles.



\### 6. Gestión de turnos



El proceso de atención utilizará los siguientes estados:



\- Pendiente.

\- Llamado.

\- EnAtencion.

\- Atendido.

\- Omitido.



\*\*Transiciones propuestas:\*\*



\- Pendiente a Llamado.

\- Llamado a EnAtencion.

\- EnAtencion a Atendido.

\- Llamado a Omitido.

\- Omitido a Pendiente, cuando se autorice reabrir el turno.



No se permitirán cambios de estado que incumplan las reglas de atención.



El sistema deberá respetar el orden de los turnos, considerando las prioridades que se definan antes de la implementación.



\### 7. Notificaciones por correo



El módulo de recordatorios permitirá preparar y enviar notificaciones.



\*\*Antes del envío se verificará:\*\*

\- Existencia de la cita o ticket.

\- Correo electrónico válido.

\- Información del destinatario.

\- Disponibilidad de la configuración del servicio de correo.



Cuando se produzca un error, se informará al usuario sin eliminar la cita registrada.



Las credenciales del servicio de correo no deberán escribirse directamente en el código fuente.



El envío de recordatorios se realizará manualmente desde el formulario correspondiente.



\### 8. Consultas LINQ



Los formularios de consultas permitirán:



\- Filtrar citas por fecha.

\- Buscar tickets por código.

\- Consultar turnos pendientes.

\- Listar turnos atendidos.

\- Agrupar tickets por servicio.

\- Contabilizar turnos por estado.

\- Ordenar registros según fecha y hora.

\- Consultar información por sucursal.



Los resultados se mostrarán mediante DataGridView.



Las consultas utilizarán los datos administrados en memoria por las clases TList.



\### 9. Validaciones



Los formularios deberán verificar:



\- Campos obligatorios.

\- Identificadores duplicados.

\- Existencia de relaciones entre registros.

\- Disponibilidad de horarios.

\- Formatos de correo electrónico.

\- Permisos de usuarios.

\- Estados válidos de los turnos.



Cuando una operación no pueda completarse, se mostrará un mensaje explicativo.



Las validaciones deberán realizarse antes de modificar los registros administrados por los controladores.



\### 10. Restricciones de diseño



\- Los formularios se desarrollarán con Windows Forms.

\- Los componentes deberán ser visibles y editables desde el diseñador.

\- Se priorizará una interfaz sencilla y funcional.

\- Los formularios utilizarán los controladores TList.

\- No se utilizarán bases de datos.

\- La información permanecerá temporalmente en List<T>.

\- No se utilizarán archivos XML o JSON para persistir los registros.

\- Se realizarán consultas mediante LINQ.

\- Las funcionalidades deberán respetar las especificaciones aprobadas.

\- Se evitará agregar clases o componentes que no sean necesarios.



\### 11. Plan de verificación



Durante la fase de pruebas se comprobará:



1\. Apertura correcta de los formularios.

2\. Validación de campos obligatorios.

3\. Registro y consulta de citas.

4\. Generación de tickets.

5\. Cambios válidos de estado.

6\. Actualización de la pantalla de turnos.

7\. Manejo de notificaciones.

8\. Funcionamiento de consultas LINQ.

9\. Visualización correcta de los resultados.

10\. Restricciones de acceso según el rol.



Los resultados se compararán con los criterios de aceptación definidos en los documentos de la Fase 2.



\### 12. Decisiones pendientes



Antes de generar el código, el equipo deberá definir:



\- Diseño definitivo de las ventanas.

\- Datos exactos de cada formulario.

\- Cantidad y funcionamiento de las ventanillas.

\- Reglas de prioridad de atención.

\- Estructura definitiva de las citas.

\- Método de generación de códigos de turno.

\- Configuración del servicio de correo.

\- Criterios de cálculo del tiempo estimado de espera.

\- Mecanismo de autenticación de los usuarios.



Estas decisiones deberán resolverse y documentarse antes de iniciar la implementación.



\### 13. Estado del documento



\*\*Proyecto:\*\* TurnoSmarts  

\*\*Responsable:\*\* Alexiho11  

\*\*Versión:\*\* 0.1  





Este documento complementa el plan técnico de entidades y controladores elaborado por FreddyH06.



Ambos documentos servirán como base para definir las tareas de implementación y orientar la generación de código mediante inteligencia artificial.

