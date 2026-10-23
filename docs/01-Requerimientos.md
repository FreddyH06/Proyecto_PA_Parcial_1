\# TurnoSmarts

\## Fase 1: Análisis de requerimientos



\### 1. Descripción del proyecto



TurnoSmarts es un sistema de gestión de citas y turnos de atención que permitirá administrar empresas, sucursales, servicios, usuarios y tickets desde una aplicación de escritorio.



El sistema busca facilitar la organización de las filas de espera, permitiendo que el personal encargado gestione los turnos y consulte el estado de la atención.



Para su desarrollo se utilizará C# Windows Forms, aplicando programación orientada a objetos, estructuras List<T> y consultas LINQ.



\### 2. Problema identificado



En diferentes empresas e instituciones, la atención al público puede presentar dificultades debido a la falta de organización de los turnos, los tiempos de espera y el control de las citas.



Cuando estos procesos se realizan manualmente, pueden producirse confusiones en el orden de atención, duplicación de turnos y dificultades para consultar la información.



Por este motivo, se propone desarrollar TurnoSmarts como una herramienta que permita organizar y controlar estos procesos.



\### 3. Objetivo general



Desarrollar un sistema de escritorio en C# que permita gestionar citas, turnos y servicios de atención, mediante una interfaz gráfica sencilla y el uso de listas de objetos para administrar temporalmente la información, facilitando la organización de las filas y el seguimiento de los usuarios.



\### 4. Usuarios del sistema



\*\*Administrador:\*\* encargado de configurar las empresas, sucursales, servicios y usuarios.



\*\*Personal de atención:\*\* responsable de llamar, atender y finalizar los turnos.



\*\*Cliente:\*\* persona que solicita una cita o un ticket de atención.



\### 5. Requerimientos funcionales



\- \*\*RF01:\*\* El sistema permitirá registrar, modificar, consultar y eliminar empresas.

\- \*\*RF02:\*\* El sistema permitirá administrar las sucursales pertenecientes a una empresa.

\- \*\*RF03:\*\* El sistema permitirá configurar los servicios y las filas de atención.

\- \*\*RF04:\*\* El sistema permitirá registrar y administrar usuarios.

\- \*\*RF05:\*\* El sistema permitirá configurar tótems para solicitar turnos.

\- \*\*RF06:\*\* El sistema permitirá generar tickets con identificadores únicos.

\- \*\*RF07:\*\* El sistema permitirá registrar, consultar y cancelar citas.

\- \*\*RF08:\*\* El sistema permitirá administrar los turnos pendientes, llamados y atendidos.

\- \*\*RF09:\*\* El sistema permitirá mostrar los turnos en una pantalla independiente.

\- \*\*RF10:\*\* El sistema permitirá gestionar notificaciones y recordatorios por correo electrónico.

\- \*\*RF11:\*\* El sistema permitirá realizar consultas mediante LINQ.

\- \*\*RF12:\*\* El sistema permitirá generar reportes de citas, tickets y atención.



\### 6. Requerimientos no funcionales



\- \*\*RNF01:\*\* El sistema se desarrollará utilizando C# Windows Forms.

\- \*\*RNF02:\*\* Se aplicará programación orientada a objetos.

\- \*\*RNF03:\*\* Las entidades tendrán atributos, constructores, propiedades y métodos.

\- \*\*RNF04:\*\* Se utilizarán clases administradoras TList con List<T>.

\- \*\*RNF05:\*\* Los datos se mantendrán únicamente en memoria durante la ejecución.

\- \*\*RNF06:\*\* No se utilizarán bases de datos, archivos XML ni otros mecanismos de persistencia.

\- \*\*RNF07:\*\* Se utilizará LINQ para realizar consultas.

\- \*\*RNF08:\*\* Los formularios tendrán componentes gráficos visibles y editables.

\- \*\*RNF09:\*\* Se validarán los datos ingresados.

\- \*\*RNF10:\*\* El código será administrado mediante Git y GitHub.



\### 7. Restricciones del sistema



La información se almacenará temporalmente mediante estructuras List<T>.



Al cerrar la aplicación, los registros almacenados en memoria se perderán.



El sistema será una aplicación de escritorio desarrollada en .NET Framework 4.8.



\### 8. Metodología de desarrollo



El proyecto utilizará Spec Driven Development (SDD), siguiendo seis fases:



1\. Requerimientos.

2\. Especificación.

3\. Plan técnico.

4\. Implementación.

5\. Verificación.

6\. Evolución.



Antes de generar código con inteligencia artificial, se definirán las características y reglas que deberá cumplir el sistema.



Posteriormente, el código generado se revisará y probará para comprobar que cumple las especificaciones.



\### 9. Estado del documento



\*\*Versión:\*\* 0.1



\*\*Estado:\*\* Borrador inicial, pendiente de revisión y aprobación.



\*\*Proyecto:\*\* TurnoSmarts

