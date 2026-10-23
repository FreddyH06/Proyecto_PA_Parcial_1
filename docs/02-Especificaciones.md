\# TurnoSmarts

\## Fase 2: Especificaciones funcionales — Parte 1



\*\*Responsable:\*\* FreddyH06

\*\*Metodología:\*\* Spec Driven Development (SDD)

\*\*Versión:\*\* 0.1

\*\*Estado:\*\* Borrador pendiente de revisión



\### 1. Introducción



Este documento establece las especificaciones funcionales de los módulos administrativos de TurnoSmarts. Su propósito es definir el comportamiento esperado del sistema antes de comenzar su implementación mediante inteligencia artificial.



Se describen las funcionalidades relacionadas con empresas, sucursales, servicios, usuarios, tótems y tickets, incluyendo sus reglas de negocio, validaciones y criterios de aceptación.



\### 2. Especificaciones funcionales



\#### EF01. Administración de empresas (RF01)



\*\*Descripción:\*\* El sistema permitirá registrar, modificar, eliminar, buscar y consultar la información de las empresas.



\*\*Reglas de negocio:\*\*

\- Cada empresa tendrá un código único.

\- No se permitirán empresas con códigos duplicados.

\- Los campos obligatorios deberán estar completos.

\- Antes de eliminar una empresa se comprobará si tiene sucursales relacionadas.

\- Los cambios realizados deberán reflejarse en los listados.



\*\*Criterios de aceptación:\*\*

\- Una empresa válida se registra correctamente.

\- Si el código ya existe, el sistema muestra una advertencia.

\- Se puede buscar una empresa mediante su código.

\- Los cambios realizados se muestran correctamente.

\- No se permite eliminar una empresa que tenga sucursales relacionadas.



\#### EF02. Administración de sucursales (RF02)



\*\*Descripción:\*\* El sistema permitirá administrar las sucursales pertenecientes a cada empresa.



\*\*Reglas de negocio:\*\*

\- Cada sucursal tendrá un identificador único.

\- Cada sucursal deberá pertenecer a una empresa existente.

\- Será obligatorio ingresar el nombre de la sucursal.

\- No se permitirán registros duplicados.

\- Antes de eliminar una sucursal se comprobarán sus relaciones con otros registros.



\*\*Criterios de aceptación:\*\*

\- Se registra una sucursal asociada a una empresa válida.

\- El sistema rechaza sucursales duplicadas.

\- Se pueden consultar las sucursales de una empresa.

\- Las modificaciones se reflejan en los listados.

\- Se impide registrar una sucursal sin empresa.



\#### EF03. Administración de servicios y filas (RF03)



\*\*Descripción:\*\* El sistema permitirá configurar los servicios de atención disponibles en las sucursales y organizar sus respectivas filas.



\*\*Reglas de negocio:\*\*

\- Cada servicio tendrá un código y un nombre.

\- Los servicios estarán asociados a una sucursal.

\- Cada fila estará relacionada con un servicio determinado.

\- No se permitirán códigos duplicados dentro del alcance establecido.

\- Los turnos pendientes deberán conservar su orden de atención, salvo las prioridades que se definan posteriormente.



\*\*Criterios de aceptación:\*\*

\- El administrador puede registrar un servicio.

\- Los servicios aparecen relacionados con su sucursal.

\- Se pueden consultar las filas de cada servicio.

\- No se permite registrar un servicio sin los datos obligatorios.

\- Los turnos generados se asignan a la fila correspondiente.



\#### EF04. Administración de usuarios (RF04)



\*\*Descripción:\*\* El sistema permitirá registrar y administrar las cuentas de los usuarios encargados de gestionar el proceso de atención.



\*\*Reglas de negocio:\*\*

\- Cada usuario tendrá un identificador único.

\- Los usuarios tendrán un nombre y un rol.

\- Se manejarán inicialmente los roles Administrador y Personal de atención.

\- No se permitirán identificadores duplicados.

\- Las operaciones disponibles dependerán de los permisos asignados.



\*\*Criterios de aceptación:\*\*

\- Un usuario válido se registra correctamente.

\- El sistema rechaza identificadores duplicados.

\- Se puede buscar y modificar la información de un usuario.

\- Un usuario sin permisos no podrá utilizar funciones administrativas restringidas.



\#### EF05. Configuración de tótems (RF05)



\*\*Descripción:\*\* El sistema permitirá configurar los tótems utilizados para solicitar tickets de atención.



\*\*Reglas de negocio:\*\*

\- Cada tótem tendrá un código único.

\- Cada tótem estará asociado a una sucursal.

\- El tótem mostrará los servicios disponibles en su sucursal.

\- Solo se podrán solicitar turnos para servicios válidos y habilitados.

\- El sistema deberá comprobar la información antes de generar el ticket.



\*\*Criterios de aceptación:\*\*

\- Se registra correctamente un tótem.

\- El tótem muestra los servicios de su sucursal.

\- El usuario puede seleccionar un servicio disponible.

\- Una selección inválida no genera un ticket.

\- Las solicitudes válidas generan un nuevo turno.



\#### EF06. Generación de tickets (RF06)



\*\*Descripción:\*\* El sistema permitirá generar tickets para administrar la atención de los usuarios.



\*\*Reglas de negocio:\*\*

\- Cada ticket tendrá un identificador interno único.

\- El ticket estará asociado a una sucursal y a un servicio.

\- El ticket registrará su fecha y hora de generación.

\- Al generarse, el ticket tendrá el estado Pendiente.

\- Los tickets se incorporarán a la fila del servicio correspondiente.

\- La numeración visible del turno se definirá antes de implementar el módulo.



\*\*Criterios de aceptación:\*\*

\- Se genera un ticket para un servicio válido.

\- No existen identificadores internos duplicados.

\- El ticket se incorpora a la fila correspondiente.

\- El estado inicial del ticket es Pendiente.

\- El sistema permite consultar los tickets generados.



\### 3. Restricciones generales



\- El sistema utilizará C# Windows Forms y .NET Framework 4.8.

\- Se aplicará programación orientada a objetos.

\- La información será administrada mediante estructuras List<T>.

\- No se utilizarán bases de datos ni archivos XML para almacenar registros.

\- Los datos permanecerán únicamente en memoria durante la ejecución.

\- Se utilizará LINQ para las consultas.

\- Los formularios deberán contener componentes visibles y editables en el diseñador de Visual Studio.

\- El código se generará con apoyo de inteligencia artificial a partir de las especificaciones aprobadas.



\### 4. Aspectos pendientes de definir



Antes de comenzar la implementación, el equipo deberá completar las siguientes decisiones:



\- Atributos definitivos de cada entidad.

\- Reglas de eliminación de registros relacionados.

\- Permisos específicos de cada rol.

\- Numeración de tickets por servicio y fecha.

\- Prioridades de atención.

\- Validaciones adicionales de los formularios.



\### 5. Verificación



Durante la fase de verificación se comprobará que las funcionalidades generadas cumplan los criterios de aceptación establecidos.



Las pruebas deberán considerar registros correctos, registros duplicados, datos incompletos, búsquedas, modificaciones y relaciones entre entidades.



\### 6. Estado del documento



\*\*Versión:\*\* 0.1

\*\*Responsable:\*\* FreddyH06

