# Estacionamiento
Ingresar a GitHub, dar click en "file" seleccionar "options" e ingresar tu cuenta.
Seleccionar "git" y elegir tu cuenta correspondiente.
Dar click en "file" seleccionar "Clone repository" elegir que repositorio deseas clonar y dar click.


Para crear la base de datos en MySql se debe traducir desde nuestro contexto (C#) a SQL, para ello debemos realizar una migracion. Esto se debe realizar una unica vez al momento de crear la base de datos.
"dotnet ef migrations add NOMBRE_MIGRACION --context NOMBRE_CONTEXTO --output-dir DIRECTORIO_MIGRACIONES --project NOMBRE_PROYECTO --startup-project NOMBRE_PROYECTO_EJECUTABLE"

Cada vez que ingresemos un nuevo cambio en el contexto. Por ejemplo agregar un nuevo atributo a una entidad. Se debe realizar una nueva migracion con un nombre distinto a los existentes.
"dotnet ef migrations add UnNuevoCambio --context AplicacionDbContext --output-dir Persistencia/Migraciones --project Aplicacion --startup-project Aplicacion"

Inicializar el servicio de Mysql.
Entrar a la terminal.
Ejecutar el comando de "dotnet restore"
Ejecutar el comando "cd" dejando la directiva: C:\Users\ET12Compu\Desktop\Estacionamiento>
Ejecutar el comando  "dotnet run --project Presentacion"
Seleccionar la primera dirección que aparezca.

Copiar la primera dirreción en el navegador y agregar "/swagger".
Esto nos va a redireccionar a la WebApi lista para ser testeado, por ultimo se procede a operar dentro del mismo.

Seleccionar en el apartado POST, click en la opción "Try Out", colocar los datos correspondientes( o colocar los parametros correspondientes), darle a "Execute" y verificar que no haya errores tanto en "Curl", la direccion "URL" y el "Code". Ya una vez verificados entrar en el apartado "Get", click en "Try Out" luego a "Execute" y chequear si lo hecho anteriormente en "Post" aparece debajo de "Response body", analizar nuevamente el "URL" del mismo apartado (en el que nos encontramos) y revisar si se encuentran los datos. Clic en el apartado "PUT" darle a "Try Out", copiar y colocar el "Id" del objeto que nosotros creamos(aparece en el apartado "GET") para poder modificar los parametros alterables de ese objeto y clickear en "Execute". Y por ultimo en el apartado de "Delete" darle click a "Try Out" y pasarle por parametro el "Id" del objeto a eliminar, click en "Execute" y comprobar si fue eliminiado correctamente.