# TurnoSmarts
## Fase 3: Plan técnico de formularios y procesos de atención — Actualizado

**Responsable:** Alexiho11  
**Revisor:** FreddyH06  
**Metodología:** Spec Driven Development (SDD)  
**Versión:** 0.2  
**Estado:** Pendiente de revisión y aprobación

### 1. Introducción

El presente documento establece el diseño técnico de los formularios de TurnoSmarts, tomando como referencia las funciones y componentes del sistema original Virtual List .NET.

El objetivo es conservar las quince ventanas del sistema, incluyendo su funcionamiento, componentes gráficos, validaciones, procesos de atención y comunicación con las clases administradoras TList.

La aplicación se desarrollará utilizando C# Windows Forms y .NET Framework 4.8, aplicando programación orientada a objetos y consultas LINQ.

La principal diferencia con el sistema original será la eliminación del almacenamiento XML. Los registros permanecerán exclusivamente en memoria mediante estructuras List<T> durante la ejecución.

La implementación será generada posteriormente con apoyo de inteligencia artificial, utilizando las especificaciones aprobadas mediante la metodología Spec Driven Development.

### 2. Estructura de formularios

El proyecto contará con la carpeta Formularios, donde se implementarán quince ventanas independientes.

Cada formulario estará compuesto por:

- Un archivo `.cs` con los eventos y métodos.
- Un archivo `.Designer.cs` con los componentes visuales.
- Un método InitializeComponent para inicializar los controles.
- Los eventos necesarios para ejecutar las operaciones.

Se conservarán los nombres predeterminados de los componentes, como button1, textBox1, comboBox1 y dataGridView1, de acuerdo con el diseño establecido.

Los formularios deberán ser visibles, funcionales y editables mediante el diseñador de Visual Studio.

### 3. Frm_Login — Inicio de sesión

Permitirá que administradores y trabajadores accedan al sistema mediante credenciales.

También proporcionará acceso público a la solicitud de turnos.

**Componentes:**

- textBox1: nombre de usuario.
- textBox2: contraseña.
- button1: Ingresar.
- button2: Solicitar turno.
- Labels para indicar los campos y mostrar mensajes.

**Funcionamiento:**

Al presionar Ingresar, el sistema consultará TListUsuarios para verificar que exista una cuenta activa con las credenciales correspondientes.

Si las credenciales son válidas, se abrirá Frm_Principal con los permisos del usuario.

Cuando sean incorrectas, se mostrará un mensaje de error.

El botón Solicitar turno permitirá acceder a las funciones públicas sin proporcionar credenciales administrativas.

**Validaciones:**

- Campos obligatorios.
- Existencia del usuario.
- Contraseña correcta.
- Cuenta activa.

### 4. Frm_Principal — Menú principal

Será la ventana principal del sistema.

Utilizará un menú lateral y un panel central donde se cargarán los diferentes formularios.

**Componentes:**

- panelMenu: menú de navegación.
- panelContenedor: área para mostrar formularios.
- button1: Resumen.
- button2: Empresa.
- button3: Sucursales.
- button4: Filas / servicios.
- button5: Usuarios.
- button6: Tótems.
- button7: Sacar ticket.
- button8: Reservar cita.
- button9: Atención.
- button10: Reportes.
- button11: Pantalla externa de turnos.
- button12: Recordatorios.
- button13: Mi perfil.
- button14: Cerrar sesión.

**Funcionamiento:**

El sistema mostrará las opciones correspondientes al rol del usuario.

Los administradores podrán acceder a las configuraciones y módulos administrativos.

Los trabajadores podrán utilizar los módulos de atención y consulta autorizados.

Los usuarios públicos podrán solicitar turnos y reservar citas.

Los formularios se mostrarán dentro de panelContenedor.

La pantalla externa se abrirá como una ventana independiente. Si ya está abierta, se activará la existente para evitar duplicados.

### 5. Frm_Dashboard — Estadísticas generales

Mostrará un resumen de la información registrada durante la ejecución.

**Componentes:**

- label2: cantidad de sucursales.
- label3: cantidad de servicios.
- label4: turnos emitidos durante el día.
- label5: turnos pendientes.
- button1: Actualizar.
- dataGridView1: últimos tickets registrados.

**Funcionamiento:**

Los indicadores se calcularán mediante consultas LINQ sobre las listas.

Al presionar Actualizar, se volverán a calcular las estadísticas.

El DataGridView mostrará los últimos tickets registrados.

El formulario deberá funcionar correctamente incluso cuando las listas estén vacías.

### 6. Frm_Empresa — Configuración institucional

Permitirá administrar la información general de la empresa y configurar el servicio de correo electrónico.

**Componentes:**

- textBox1: RUC.
- textBox2: razón social.
- textBox3: correo de contacto.
- checkBox1: obligar cédula.
- checkBox2: obligar nombre.
- checkBox3: obligar correo electrónico.
- checkBox4: obligar teléfono.
- textBox4: servidor SMTP.
- numericUpDown1: puerto SMTP.
- textBox5: usuario o remitente.
- checkBox5: SSL/TLS.
- textBox6: identificador de aplicación Microsoft Entra.
- textBox7: identificador del directorio o Tenant.
- button1: Guardar cambios.
- button2: Guardar y probar correo.

**Funcionamiento:**

El formulario administrará un único objeto Empresa compartido en memoria.

Permitirá configurar cuáles datos deberán solicitarse obligatoriamente al generar tickets.

También permitirá establecer los parámetros necesarios para enviar confirmaciones por correo electrónico.

Se contemplará el uso de Outlook clásico, Microsoft Graph y opciones SMTP autorizadas.

El botón Guardar y probar correo verificará la configuración mediante una prueba de envío.

Las contraseñas y tokens de correo no deberán incluirse directamente en el código fuente.

### 7. Frm_Sucursales — Administración de sucursales

Permitirá registrar, modificar, eliminar y consultar las sucursales.

**Componentes:**

- textBox1: código de sucursal.
- textBox2: dirección.
- textBox3: teléfono.
- dateTimePicker1: inicio de atención.
- dateTimePicker2: fin de atención.
- button1: Agregar.
- button2: Modificar.
- button3: Eliminar.
- button4: Limpiar.
- dataGridView1: listado de sucursales.

**Funcionamiento:**

Los registros se administrarán mediante TListSucursales.

Al seleccionar una fila del DataGridView se cargarán los datos en los controles.

Se validará que no existan códigos duplicados y que los horarios sean correctos.

No se permitirá eliminar una sucursal si tiene relaciones que deban conservarse.

### 8. Frm_Filas — Servicios y filas de atención

Permitirá administrar los servicios disponibles en las sucursales.

**Componentes:**

- textBox1: código de fila.
- comboBox1: sucursal.
- textBox2: descripción del servicio.
- numericUpDown1: minutos estimados por atención.
- numericUpDown2: costo estimado.
- numericUpDown3: cantidad de ventanillas.
- button1: Agregar.
- button2: Modificar.
- button3: Eliminar.
- button4: Limpiar.
- dataGridView1: listado de servicios.

**Funcionamiento:**

El formulario utilizará TListFilas y TListSucursales.

Cada servicio estará asociado a una sucursal existente.

Se verificará que el tiempo de atención y la cantidad de ventanillas sean mayores que cero.

El tiempo estimado se utilizará para calcular la disponibilidad de citas y la espera aproximada.

### 9. Frm_Usuarios — Administración de usuarios

Permitirá administrar los usuarios y trabajadores del sistema.

**Componentes:**

- textBox1: nombre de usuario.
- textBox2: nombres.
- textBox3: apellidos.
- textBox4: teléfono.
- textBox5: contraseña.
- comboBox1: tipo de usuario.
- comboBox2: sucursal.
- textBox6: ventanilla.
- checkBox1: estado activo.
- button1: Agregar.
- button2: Modificar.
- button3: Eliminar.
- button4: Limpiar.
- dataGridView1: usuarios registrados.

**Funcionamiento:**

El formulario utilizará TListUsuarios.

Los roles serán ADMINISTRADOR y TRABAJADOR.

Los administradores tendrán acceso a la configuración del sistema.

Los trabajadores estarán asociados a una sucursal y ventanilla cuando corresponda.

Las contraseñas se protegerán utilizando el componente Seguridad.

En las modificaciones, dejar vacío el campo de contraseña conservará la contraseña anterior.

El DataGridView no mostrará las contraseñas ni sus hashes.

### 10. Frm_Totems — Terminales de autoservicio

Permitirá configurar las terminales desde las cuales los clientes podrán solicitar turnos.

**Componentes:**

- textBox1: código del tótem.
- comboBox1: sucursal.
- textBox2: ubicación.
- checkedListBox1: servicios disponibles.
- button1: Agregar.
- button2: Modificar.
- button3: Eliminar.
- button4: Limpiar.
- dataGridView1: listado de tótems.

**Funcionamiento:**

Se utilizarán TListTotems, TListSucursales y TListFilas.

Al seleccionar una sucursal se mostrarán los servicios relacionados.

El usuario podrá marcar varios servicios mediante CheckedListBox.

No se permitirá asociar servicios inexistentes o correspondientes a otras sucursales.

### 11. Frm_Turnos — Generación de tickets

Permitirá que los clientes soliciten tickets de atención inmediata.

**Componentes:**

- comboBox1: sucursal.
- comboBox2: servicio o fila.
- textBox1: cédula.
- textBox2: nombres.
- textBox3: correo.
- textBox4: teléfono.
- checkBox1: solicitar recordatorio por correo.
- checkBox2: solicitar recordatorio por SMS.
- button1: Generar ticket.
- button2: Imprimir ticket.
- textBox5: código del último ticket generado.
- richTextBox1: contenido del ticket.
- label8: cantidad de personas en espera y tiempo aproximado.

**Funcionamiento:**

Al seleccionar un servicio, se mostrará la cantidad de turnos pendientes y el tiempo estimado de espera.

Al presionar Generar ticket, se utilizará TListTickets para crear un registro nuevo.

Cada ticket tendrá:

- Identificador interno único.
- Código de ticket.
- Fila.
- Fecha de emisión.
- Datos del cliente.
- Estado inicial PENDIENTE.

La numeración será consecutiva por fila, fecha y tipo de solicitud.

El código visible seguirá el formato acordado en las decisiones técnicas.

**Impresión:**

El botón Imprimir ticket utilizará PrintDocument y PrintDialog.

Se mostrará el diálogo de impresión de Windows para seleccionar una impresora física o PDF.

El documento contendrá el código, servicio, nombre, fecha y estado del ticket.

### 12. Frm_Citas — Reservas y anulaciones

Permitirá registrar citas programadas, consultarlas y anularlas.

**Componentes:**

- comboBox1: sucursal.
- comboBox2: servicio.
- dateTimePicker1: fecha.
- dateTimePicker2: hora.
- textBox1: cédula.
- textBox2: nombre completo.
- textBox3: correo electrónico.
- textBox4: teléfono.
- checkBox1: recordatorio adicional por correo dos horas antes.
- checkBox2: recordatorio por SMS.
- button1: Reservar cita.
- textBox5: código de la cita que se desea consultar o anular.
- button2: Anular cita.
- button3: Buscar mis citas.
- dataGridView1: citas encontradas.

**Funcionamiento:**

Las citas se registrarán mediante TListTickets, utilizando el atributo Programado.

Se verificará que la fecha y hora solicitadas correspondan a un horario permitido.

La disponibilidad dependerá del tiempo estimado del servicio y la cantidad de ventanillas.

Las consultas y anulaciones utilizarán la cédula y el código de la cita.

Las citas anuladas no podrán participar en la cola de atención.

**Confirmación automática por correo:**

Cuando una cita se registre correctamente, el sistema generará una confirmación con el código, servicio, sucursal, fecha y hora.

La aplicación intentará enviarla mediante el componente CorreoInstitucional.

Si el envío falla, la cita se conservará en memoria y el aviso permanecerá pendiente para reintentar desde Frm_Recordatorios.

La confirmación inicial será independiente de la opción de solicitar un recordatorio adicional.

### 13. Frm_Atencion — Administración de turnos

Permitirá que el personal autorizado gestione la atención de los usuarios.

**Componentes:**

- comboBox1: sucursal.
- comboBox2: fila o servicio.
- textBox1: ventanilla.
- button1: Llamar siguiente.
- button2: Iniciar atención.
- button3: Finalizar.
- button4: Omitir.
- button5: Reabrir turno.
- button6: Actualizar.
- label5: ticket seleccionado.
- dataGridView1: listado de turnos.

**Funcionamiento:**

El formulario utilizará TListTickets.

Al llamar al siguiente ticket, el sistema seleccionará un turno válido respetando el orden de atención y las prioridades establecidas.

Las citas programadas podrán incorporarse a la cola cuando falten quince minutos o menos para su horario reservado.

Los estados serán:

- PENDIENTE.
- LLAMADO.
- EN ATENCION.
- ATENDIDO.
- OMITIDO.
- ANULADO, cuando corresponda a una cita.

Las operaciones deberán verificar las transiciones permitidas.

Un turno deberá estar llamado antes de iniciar su atención.

No se permitirá finalizar una atención que todavía no haya comenzado.

Los turnos omitidos podrán reabrirse cuando las reglas de negocio lo permitan.

Los cambios de estado actualizarán las listas y se reflejarán en la pantalla externa.

### 14. Frm_Reportes — Consultas y exportación

Permitirá consultar la información registrada mediante LINQ.

**Componentes:**

- comboBox1: sucursal.
- dateTimePicker1: fecha inicial.
- dateTimePicker2: fecha final.
- button1: Consultar.
- button2: Exportar CSV.
- dataGridView1: resultados.
- label5: resumen de cantidades.

**Funcionamiento:**

El formulario consultará TListTickets y los datos relacionados con sucursales y servicios.

Permitirá obtener información de:

- Tickets emitidos.
- Tickets pendientes.
- Tickets atendidos.
- Tickets anulados.
- Citas programadas.
- Atención por sucursal y servicio.

Los resultados se obtendrán utilizando consultas LINQ.

El botón Exportar CSV permitirá generar un archivo compatible con Excel.

El archivo CSV será únicamente un reporte y no se utilizará para restaurar datos del programa.

### 15. Frm_Pantalla — Pantalla externa de turnos

Será una ventana independiente destinada a mostrar información pública sobre la atención.

**Componentes:**

- comboBox1: sucursal.
- comboBox2: servicio.
- label4: turno actual.
- label5: ventanilla.
- label7: información de turnos en espera.
- label8: tiempo estimado.
- label9: próximo turno.
- dataGridView1: historial de llamados.
- dataGridView2: próximos turnos pendientes.
- button1: Maximizar / Restaurar.

**Funcionamiento:**

La pantalla se abrirá desde Frm_Principal.

Se actualizará cada 1000 milisegundos mediante un Timer de Windows Forms.

La información se obtendrá directamente desde las listas compartidas por los controladores.

Mostrará:

- Código del turno llamado.
- Ventanilla correspondiente.
- Estado de atención.
- Cantidad de turnos pendientes.
- Cantidad de turnos llamados y en atención.
- Turnos atendidos.
- Próximo ticket.
- Tiempo estimado de espera.
- Citas del día que aún no estén habilitadas.
- Historial de llamados.

El tiempo estimado se calculará considerando la cantidad de turnos, la duración aproximada del servicio y las ventanillas disponibles.

La ventana podrá maximizarse y trasladarse a un segundo monitor.

No se permitirá abrir copias innecesarias de la misma pantalla.

El Timer deberá detenerse al cerrar la ventana.

### 16. Frm_Recordatorios — Notificaciones y avisos

Permitirá administrar recordatorios y confirmaciones pendientes.

**Componentes:**

- dataGridView1: listado de avisos.
- button1: Actualizar.
- button2: Enviar seleccionado.
- Labels para información y mensajes.

**Funcionamiento:**

El formulario utilizará TListRecordatorios.

Mostrará el identificador, ticket, tipo de envío, destinatario, fecha, estado y resultado.

Los avisos podrán representar:

- Confirmaciones de citas.
- Recordatorios por correo.
- Recordatorios SMS.

El envío de recordatorios posteriores será manual.

Antes de enviar, el sistema comprobará:

- Existencia del recordatorio.
- Que todavía no haya sido enviado.
- Que haya llegado la fecha programada.
- Que la cita no esté anulada.
- Que exista una configuración autorizada del proveedor.

Los correos utilizarán CorreoInstitucional.

Los SMS necesitarán un proveedor externo configurado.

Cuando ocurra un error, el aviso conservará su estado pendiente y mostrará el motivo.

No se marcarán mensajes como enviados si el proveedor rechaza la solicitud.

No existirá un servicio de envío automático en segundo plano.

### 17. Frm_Perfil — Cambio de contraseña

Permitirá al usuario activo actualizar su contraseña.

**Componentes:**

- textBox1: contraseña actual.
- textBox2: nueva contraseña.
- textBox3: confirmar nueva contraseña.
- button1: Cambiar contraseña.

**Funcionamiento:**

El sistema verificará la contraseña actual utilizando el componente Seguridad.

La nueva contraseña deberá cumplir las validaciones establecidas.

La confirmación deberá coincidir con la nueva contraseña.

Cuando la operación sea válida, el sistema actualizará el hash de contraseña del usuario.

No se mostrarán contraseñas en texto visible durante su escritura.

### 18. Comunicación con los controladores

Los formularios utilizarán los seis controladores principales:

- TListSucursales.
- TListFilas.
- TListUsuarios.
- TListTotems.
- TListTickets.
- TListRecordatorios.

Cada controlador administrará su correspondiente List<T>.

Los formularios mostrarán la información y capturarán las acciones de los usuarios.

Las operaciones y validaciones de negocio se ejecutarán mediante los controladores correspondientes.

Se conservarán los componentes auxiliares:

- Seguridad.
- CorreoInstitucional.
- Utilidades.

La configuración general de Empresa permanecerá compartida en memoria.

No se utilizarán métodos de guardado o carga mediante XML.

### 19. Diseño visual y eventos

Los quince formularios deberán ser completamente editables desde el diseñador de Windows Forms.

Se utilizarán componentes reales como:

- TextBox.
- ComboBox.
- Button.
- Label.
- DataGridView.
- CheckBox.
- CheckedListBox.
- NumericUpDown.
- DateTimePicker.
- RichTextBox.
- Panel.
- Timer.

Se conservarán los nombres de controles definidos en el diseño para evitar inconsistencias con los eventos.

Los botones deberán ejecutar operaciones reales.

Las tablas deberán permitir visualizar los registros y utilizar barras de desplazamiento cuando sea necesario.

Se priorizará una interfaz sencilla, funcional y adaptable al tamaño de la ventana.

Los formularios deberán presentar mensajes de confirmación y error.

### 20. Consultas LINQ

Los formularios utilizarán LINQ para:

- Buscar registros.
- Filtrar por sucursal.
- Consultar servicios.
- Ordenar tickets.
- Buscar citas.
- Agrupar tickets por servicio.
- Contabilizar estados.
- Consultar turnos del día.
- Obtener estadísticas.
- Mostrar resultados en DataGridView.

Las consultas trabajarán exclusivamente sobre las listas administradas en memoria.

### 21. Restricciones del sistema

- Desarrollo en C# Windows Forms.
- Uso de .NET Framework 4.8.
- Aplicación de programación orientada a objetos.
- Uso de List<T> para administrar registros.
- Uso de LINQ para consultas.
- Separación entre Entidades, Controlador y Formularios.
- No utilizar almacenamiento XML, JSON ni bases de datos.
- Conservar los quince formularios principales.
- Mantener controles visibles y editables.
- Validar las operaciones antes de modificar registros.
- Conservar los registros durante la ejecución.
- Perder los registros al cerrar la aplicación.
- Mantener las funciones de correo, impresión, citas, atención y reportes.
- Revisar el código generado por inteligencia artificial antes de integrarlo.

### 22. Plan de verificación

Durante la Fase 5 se comprobará:

1. Inicio de sesión con credenciales válidas e inválidas.
2. Restricciones de acceso según el rol.
3. Navegación correcta entre formularios.
4. Actualización de estadísticas.
5. Configuración de empresa.
6. Registro, modificación y eliminación de sucursales.
7. Validación de servicios y ventanillas.
8. Administración de usuarios.
9. Cambio de contraseña.
10. Configuración de tótems.
11. Generación de tickets.
12. Numeración diaria.
13. Impresión mediante PrintDialog.
14. Registro de citas.
15. Validación de horarios.
16. Búsqueda y anulación de reservas.
17. Confirmación automática por correo, cuando el proveedor esté configurado.
18. Gestión de avisos pendientes cuando falle el correo.
19. Llamada y atención de turnos.
20. Omisión y reapertura.
21. Actualización automática de Frm_Pantalla.
22. Consultas mediante LINQ.
23. Exportación CSV.
24. Funcionamiento de los quince archivos Designer.
25. Funcionamiento exclusivo con List<T>, sin XML.
26. Conservación temporal de los registros mientras la aplicación esté abierta.

Estas pruebas deberán ejecutarse realmente en Windows y documentar sus resultados. La existencia del código no se considerará suficiente para aprobar una funcionalidad.

### 23. Implementación mediante SDD

La implementación comenzará cuando las especificaciones y el plan técnico estén revisados.

GitHub Copilot podrá generar los formularios y eventos a partir de los documentos aprobados.

La generación deberá realizarse por módulos, conservando los nombres de los controles y las operaciones especificadas.

El código generado deberá compilar y funcionar correctamente.

Los integrantes trabajarán mediante ramas independientes y Pull Requests.

Cada módulo se verificará antes de incorporarlo a master.

### 24. Estado del documento

**Proyecto:** TurnoSmarts  
**Responsable:** Alexiho11  
**Revisor:** FreddyH06  
**Versión:** 0.2  
**Estado:** Pendiente de revisión y aprobación.

Esta actualización incorpora el diseño de los quince formularios del sistema original Virtual List .NET, adaptándolos al almacenamiento temporal mediante List<T>.

Este documento complementa el plan técnico de entidades y controladores y constituye una referencia para la posterior generación de código con inteligencia artificial.