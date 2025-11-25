

###### 1\. Captura de Información del Sistema



Crear un script en Batch (.bat) o PowerShell (.ps1) que obtenga la siguiente información:



Sistema operativo



Hostname



MAC Address



Fabricante del dispositivo



Dirección IP



Fecha y hora de uso de puertos



Regla: No registrar el mismo puerto si ya fue utilizado en los últimos 10 minutos.



Tiempo estimado: 2 semanas



###### 2\. Validación de Direcciones



Comprobar que la MAC Address y la dirección IP no estén asignadas a otro hostname en la red.



Tiempo estimado: 2 días



###### 3\. Modelo de Base de Datos (MySQL)



Diseñar una estructura ideal con las siguientes tablas:



Equipo



Fabricante



Protocolo



Protocolo Usado



Tiempo estimado: 1 semana



###### 4\. Aplicación Cliente



Desarrollar una aplicación en Visual Basic, C# o similar que realice la captura indicada en el punto 1.



Tiempo estimado: 1 semana



###### 5\. Servicio en Windows



Crear un servicio que se ejecute automáticamente al inicio del sistema.



Tiempo estimado: 3 días



###### 6\. Integración con el Área de Notificación



Agregar un ícono en el System Tray para el monitor.

El usuario no debe poder cerrar la aplicación desde el ícono.



Tiempo estimado: 2 días



###### 7\. Interfaz Web



Crear una interfaz amigable y responsiva que muestre los datos recopilados por los equipos que utilizan el cliente.



Tiempo estimado: 1 semana



###### 8\. Clasificación de Protocolos



Asignar colores según el nivel de seguridad:



Verde: seguro (ejemplo: puerto 445)



Amarillo: precaución



Rojo: inseguro (ejemplo: puerto 19)



Naranja: intermedio



Ejemplos:



Puerto 22 → seguro



Puerto 8080 → innecesario



Tiempo estimado: 1 semana



###### 9\. Reportes y Gráficas



Implementar un módulo que:



Genere gráficos de pastel con protocolos seguros



Genere gráficos de pastel con protocolos inseguros



Muestre la actividad general de protocolos usados por todos los equipos en la red



Tiempo estimado: 1 semana

###### 

###### Roles



Product Owner (Integrante 1): Se encargará del script que realiza el escaneo de la red y de priorizar los requisitos del proyecto.



Scrum Master (Integrante 2): Se encargará del diseño de la base de datos y del servicio de Windows.



Integrante 3: Responsable de la interfaz web.



Equipo de Desarrollo: Los tres integrantes.



###### Reuniones



Se realizarán juntas semanales para revisar avances, obstáculos y tareas pendientes.

