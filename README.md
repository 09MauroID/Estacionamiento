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
Seleccionar en el apartado POST, click en la opción "Try Out",  