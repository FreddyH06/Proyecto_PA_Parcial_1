\# TurnoSmarts

\## Fase 3: Plan técnico — Parte 1



\*\*Responsable:\*\* FreddyH06  

\*\*Metodología:\*\* Spec Driven Development (SDD)  

\*\*Versión:\*\* 0.1  

\*\*Estado:\*\* Propuesta técnica pendiente de aprobación



\### 1. Introducción



El presente documento establece la planificación técnica para el desarrollo de TurnoSmarts, un sistema de gestión de citas, turnos y atención de usuarios.



El sistema será desarrollado mediante C# Windows Forms, aplicando programación orientada a objetos, clases administradoras TList y consultas LINQ.



La implementación será generada con apoyo de inteligencia artificial, utilizando los requerimientos y especificaciones elaborados durante las fases anteriores.



\### 2. Tecnologías



\- Lenguaje: C#.

\- Plataforma: .NET Framework 4.8.

\- Interfaz gráfica: Windows Forms.

\- Entorno de desarrollo: Visual Studio 2026.

\- Control de versiones: Git y GitHub.

\- Asistente de programación: GitHub Copilot.

\- Metodología: Spec Driven Development.

\- Administración de datos: List<T>.

\- Consultas: LINQ.



No se utilizarán bases de datos ni archivos XML para persistir información.



\### 3. Arquitectura del sistema



Se utilizará una estructura organizada mediante tres carpetas principales:



\*\*Entidades:\*\* Contendrá las clases que representan los objetos del sistema.



\*\*Controlador:\*\* Contendrá las clases TList encargadas de administrar las colecciones de objetos y las operaciones sobre ellas.



\*\*Formularios:\*\* Contendrá las ventanas Windows Forms que permitirán la interacción con los usuarios.



Los formularios utilizarán los controladores para registrar, buscar, modificar y eliminar información.



\### 4. Diseño propuesto de entidades



Inicialmente se trabajará con siete entidades principales.



\#### 4.1. Empresa



Representará las empresas registradas en el sistema.



Atributos propuestos:

\- idEmpresa

\- nombre

\- ruc

\- correo

\- telefono

\- estado



\#### 4.2. Sucursal



Representará las sucursales pertenecientes a las empresas.



Atributos propuestos:

\- idSucursal

\- idEmpresa

\- nombre

\- direccion

\- telefono

\- estado



\#### 4.3. Fila



Representará los servicios y filas de atención disponibles.



Atributos propuestos:

\- idFila

\- idSucursal

\- nombreServicio

\- prefijoTurno

\- capacidadAtencion

\- estado



\#### 4.4. Usuario



Representará a los administradores y trabajadores del sistema.



Atributos propuestos:

\- idUsuario

\- cedula

\- nombre

\- apellido

\- correo

\- rol

\- estado



Se definirán los permisos correspondientes a cada rol antes de generar el código.



\#### 4.5. Totem



Representará los puntos donde los clientes podrán solicitar tickets.



Atributos propuestos:

\- idTotem

\- idSucursal

\- nombre

\- ubicacion

\- estado



\#### 4.6. Ticket



Representará los turnos y las reservas de atención.



Atributos propuestos:

\- idTicket

\- idFila

\- codigoTurno

\- tipoSolicitud

\- cedulaCliente

\- nombreCliente

\- correoCliente

\- fechaGeneracion

\- fechaCita

\- estado



Se propone utilizar el atributo tipoSolicitud para diferenciar entre un turno inmediato y una cita programada.



Esta decisión deberá ser revisada por el equipo para determinar si las citas requieren una entidad independiente.



\#### 4.7. Recordatorio



Representará las notificaciones relacionadas con las citas y turnos.



Atributos propuestos:

\- idRecordatorio

\- idTicket

\- destinatario

\- fechaProgramada

\- estadoEnvio



\### 5. Constructores y propiedades



Las entidades utilizarán la siguiente estructura:



\- Atributos privados.

\- Constructor vacío.

\- Constructor parametrizado.

\- Propiedades públicas para acceder a los atributos.

\- Métodos específicos cuando sean necesarios.



Se mantendrá una estructura de clases clara, sin incorporar funciones innecesarias.



\### 6. Diseño de controladores TList



Cada entidad contará con una clase administradora de listas:



\- TListEmpresa

\- TListSucursal

\- TListFila

\- TListUsuario

\- TListTotem

\- TListTicket

\- TListRecordatorio



Las clases TList utilizarán colecciones List<T> compartidas durante la ejecución del programa.



\### 7. Operaciones de los controladores



Los controladores deberán implementar operaciones como:



\*\*Agregar:\*\* Registrar un objeto en la lista, validando que no exista un identificador duplicado.



\*\*Modificar:\*\* Actualizar los datos de un objeto existente.



\*\*Eliminar:\*\* Eliminar un objeto cuando las reglas de negocio permitan hacerlo.



\*\*Buscar:\*\* Localizar un objeto utilizando su identificador.



\*\*Obtener:\*\* Recuperar un elemento o una colección de elementos.



\*\*Listar:\*\* Obtener información para mostrarla en los formularios.



Las operaciones deberán respetar las relaciones entre entidades.



\### 8. Relaciones entre entidades



Se establecen las siguientes relaciones iniciales:



\- Una empresa podrá tener varias sucursales.

\- Una sucursal pertenecerá a una empresa.

\- Una sucursal podrá tener varias filas de atención.

\- Una sucursal podrá tener varios tótems.

\- Una fila podrá contener varios tickets.

\- Un ticket podrá tener recordatorios asociados.



Los controladores administrarán las relaciones utilizando identificadores.



\### 9. Consultas LINQ



El sistema utilizará LINQ para realizar consultas sobre las listas de objetos.



Se contemplan las siguientes operaciones:



\- Consultar sucursales por empresa.

\- Filtrar servicios por sucursal.

\- Buscar usuarios por cédula.

\- Consultar tickets por estado.

\- Filtrar citas por fecha.

\- Ordenar turnos según el orden de atención.

\- Agrupar tickets por servicio.

\- Contar turnos atendidos.

\- Generar estadísticas y reportes.



Las consultas se mostrarán principalmente mediante controles DataGridView.



\### 10. Gestión de datos en memoria



La información se administrará exclusivamente mediante List<T>.



Las clases administradoras mantendrán los registros disponibles mientras se encuentre ejecutándose la aplicación.



Al cerrar el programa, la información registrada se perderá.



No se implementará almacenamiento permanente mediante SQL, XML, JSON u otros archivos de datos.



\### 11. Restricciones de implementación



\- Utilizar C# Windows Forms.

\- Mantener las entidades separadas de los controladores.

\- Utilizar List<T> para administrar objetos.

\- Implementar consultas LINQ.

\- Evitar duplicados.

\- Validar los campos obligatorios.

\- Respetar las relaciones entre entidades.

\- Mantener los controles gráficos visibles y editables en el diseñador.

\- No generar código antes de revisar el plan técnico.



\### 12. Aspectos pendientes



Antes de la implementación deberán definirse:



\- Si Ticket representará también las citas o si se necesitará una entidad Cita.

\- La numeración exacta de los turnos.

\- Las reglas de prioridad.

\- Las restricciones para eliminar registros relacionados.

\- Los permisos de cada rol.

\- Las transiciones permitidas entre estados de atención.

\- La configuración de los correos electrónicos.



Estas decisiones se revisarán conjuntamente con las especificaciones de la Fase 2.



\### 13. Verificación del plan



Antes de generar código se comprobará que:



1\. Las entidades representan los requisitos funcionales.

2\. Los controladores administran correctamente las relaciones.

3\. Las operaciones permiten desarrollar las funcionalidades solicitadas.

4\. Las consultas pueden implementarse utilizando LINQ.

5\. Las restricciones técnicas coinciden con los requerimientos.

6\. Las decisiones pendientes hayan sido resueltas.



\### 14. Estado del documento



\*\*Proyecto:\*\* TurnoSmarts  

\*\*Responsable:\*\* FreddyH06  

\*\*Versión:\*\* 0.1  




Este documento constituye la propuesta técnica inicial de entidades y controladores. Deberá complementarse con el diseño de formularios y el funcionamiento de los módulos de atención antes de comenzar la implementación.

