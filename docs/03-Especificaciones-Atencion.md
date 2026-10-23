\# TurnoSmarts

\## Fase 2: Especificaciones funcionales — Parte 2



\*\*Responsable:\*\* Alexiho11

\*\*Metodología:\*\* Spec Driven Development (SDD)

\*\*Versión:\*\* 0.1

\*\*Estado:\*\* Borrador pendiente de revisión



\### 1. Introducción



El presente documento establece las especificaciones funcionales de los módulos de citas, atención de turnos, pantalla externa, notificaciones y reportes del sistema TurnoSmarts.



Su finalidad es definir las reglas de funcionamiento, las restricciones y los criterios de aceptación que deberá cumplir cada módulo antes de comenzar la implementación mediante inteligencia artificial.



Estas especificaciones complementan el documento correspondiente a los módulos administrativos desarrollado por el otro integrante del equipo.



\### 2. Especificaciones funcionales



\#### EF07. Gestión de citas (RF07)



\*\*Descripción:\*\*



El sistema permitirá registrar, consultar y cancelar citas de atención para los servicios disponibles en una sucursal.



\*\*Reglas de negocio:\*\*



\- Cada cita deberá tener un identificador único.

\- Será obligatorio seleccionar un servicio válido.

\- Se deberán ingresar los datos del cliente que correspondan a los campos configurados como obligatorios.

\- La fecha y hora de la cita deberán ser futuras.

\- Las citas deberán respetar los horarios de atención de la sucursal.

\- El sistema deberá verificar la disponibilidad del servicio antes de aceptar una reserva.

\- No se permitirá superar la capacidad de atención de las ventanillas para un horario determinado.

\- Las citas podrán consultarse mediante su código y los datos de identificación del cliente.

\- Solo podrán cancelarse las citas que se encuentren pendientes y cumplan las condiciones de cancelación establecidas.

\- Una cita cancelada conservará su registro con estado Anulado y no aparecerá entre los turnos pendientes.



\*\*Criterios de aceptación:\*\*



\- Se puede registrar una cita cuando los datos y horarios son válidos.

\- Una cita fuera del horario permitido es rechazada.

\- El sistema impide reservar un horario cuando no existe capacidad disponible.

\- Se pueden consultar correctamente las citas registradas.

\- Una cita pendiente puede cancelarse con la identificación correspondiente.

\- Una cita anulada deja de estar disponible para su atención.



\#### EF08. Gestión de atención de turnos (RF08)



\*\*Descripción:\*\*



El sistema permitirá al personal administrar los turnos de atención desde su registro hasta la finalización del servicio.



\*\*Reglas de negocio:\*\*



\- Los turnos iniciarán con el estado PENDIENTE.

\- El sistema permitirá seleccionar el siguiente turno de la fila correspondiente.

\- Al llamar un turno, su estado cambiará a LLAMADO.

\- El personal podrá iniciar la atención de un turno llamado.

\- Al iniciar la atención, el estado cambiará a EN ATENCION.

\- Al finalizar el servicio, el estado cambiará a ATENDIDO.

\- Un turno llamado podrá marcarse como OMITIDO si el usuario no se presenta.

\- Los turnos omitidos podrán reabrirse bajo las condiciones establecidas.

\- No se permitirá finalizar un turno que todavía no haya iniciado su atención.

\- Los turnos atendidos deberán conservarse en memoria para las consultas y reportes mientras el programa permanezca abierto.



\*\*Criterios de aceptación:\*\*



\- El sistema identifica correctamente el siguiente turno pendiente.

\- El turno llamado muestra su estado actualizado.

\- Solo se permite iniciar la atención de un turno válido.

\- La finalización de una atención actualiza su estado.

\- Se puede omitir un turno llamado.

\- Se pueden reabrir turnos permitidos.

\- No se permiten transiciones de estado incorrectas.



\#### EF09. Pantalla externa de turnos (RF09)



\*\*Descripción:\*\*



El sistema permitirá visualizar los turnos desde una ventana independiente, facilitando que los usuarios conozcan el avance de la atención.



\*\*Reglas de negocio:\*\*



\- La pantalla mostrará el turno que está siendo llamado.

\- Se visualizará la ventanilla asignada al turno.

\- Se mostrarán los turnos pendientes del servicio seleccionado.

\- La información deberá actualizarse mientras la aplicación esté en ejecución.

\- Se podrá mostrar una estimación del tiempo de espera según la cantidad de turnos, la duración estimada del servicio y las ventanillas disponibles.

\- La pantalla utilizará la misma información administrada mediante las listas del sistema.

\- No será necesario almacenar información adicional en archivos.

\- La ventana podrá maximizarse para mostrarse en una pantalla externa.



\*\*Criterios de aceptación:\*\*



\- La pantalla se abre correctamente desde el sistema.

\- Los turnos pendientes aparecen en el orden establecido.

\- Cuando se llama un turno, la pantalla refleja el cambio.

\- Se muestra correctamente el número de ventanilla.

\- Los turnos finalizados dejan de aparecer como pendientes.

\- La información permanece sincronizada con la atención realizada dentro de la misma aplicación.



\#### EF10. Notificaciones y recordatorios (RF10)



\*\*Descripción:\*\*



El sistema permitirá gestionar notificaciones relacionadas con las citas y turnos registrados, utilizando principalmente el correo electrónico.



\*\*Reglas de negocio:\*\*



\- El sistema podrá generar una confirmación al registrar una cita.

\- La confirmación incluirá el código de la cita, el servicio y la fecha de atención.

\- Se deberá verificar que el correo electrónico del destinatario tenga un formato válido.

\- Los

