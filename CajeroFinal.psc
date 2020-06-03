SubProceso Comparacion <- compara ( DNI,Clavenum,Documento,Clave,Contador)
	Definir Comparacion Como Entero;
	Comparacion<-0;
	Definir f Como Entero;
	
	Para f<-0 Hasta Contador-1 Con Paso 1 Hacer
		si DNI[f]>0 Entonces
			Si Documento==DNI[f]&Clavenum[f]==Clave Entonces
				Comparacion<-Comparacion+1;
			FinSi
		FinSi
	FinPara
	
	si Comparacion==1 Entonces
		Escribir "Bienvenido la sistema";
	FinSi
	
	Si Comparacion==0 Entonces
		Escribir "DNI o clave incorrectas";
	FinSi

FinSubProceso



Proceso Cajero
	Definir Documento Como Entero;
	Documento<-0;
	Definir Clave Como Entero;
	Clave<-0;
	Definir saldo Como Real;
	saldo<-100;
	Definir Deposito Como Real;
	Definir extraccion Como Real;
	Definir DNI Como Entero;
	Definir Clavenum Como Entero;
	Definir Opcion Como Entero;
	Definir Contador Como Entero;
	Definir salir Como Entero;
	Contador<-0;
	
	Dimension DNI[5];
	Dimension Clavenum[5];
	
	Definir b Como Entero;
	b<-0;
	
	Escribir "Bienvenido al sistema de cajero automatico";
	Repetir
		
	
		Repetir
	    Escribir "*Si ya es cliente del banco presione 1";
		Escribir "*Si desea crear una cuenta presione 2";
		Leer  opcion;
		Limpiar Pantalla;
		Segun Opcion Hacer
			1:
				Opcion<-1;
			2:
				Escribir "Sistema de registro";
				Escribir "Ingrese su DNI";
				Leer Documento;
				Escribir "Ingrese su clave";
				leer Clave;
				
				DNI[Contador]<-Documento;
				Clavenum[Contador]<-Clave;
				
				Contador<-Contador+1;
				Escribir "Cuenta creada con exito";
				Escribir "Presione una tecla para continuar";
				Esperar Tecla;
				Limpiar Pantalla;
			De Otro Modo:
				Escribir "Ingrese una opcion Correcta";
		FinSegun
	
	Hasta Que Opcion==1;

	
	
	
	Mientras b==0  hacer
		Escribir "*Ingrese su DNI";
		Leer Documento;
		Escribir "*Ingrese su clave";
		Leer Clave;
		b<-compara(DNI,Clavenum,Documento,clave,Contador);
		
	FinMientras
	
	Repetir
		Escribir "*Ingrese 1 para extraccion";
		Escribir "*Ingrese 2 para deposito";
		Escribir "*Ingrese 3 para ver su saldo";
		Leer Opcion;
		Segun Opcion Hacer
			1:
				Escribir "Cuanto desea extraer?";
				Leer extraccion;
				Saldo<- Saldo -extraccion;
				Escribir "Su saldo es de $",Saldo ;
			2:
				Escribir "Cuanto desea depositar?";
				Leer Deposito;
				Saldo<-Saldo+Deposito;
				Escribir "Su saldo es de $",Saldo;
				
			3:
				Escribir "Su saldo es de $",Saldo;
			De Otro Modo:
				Escribir "La opcion ingresada no es valida";
		FinSegun
		Escribir "Desea realizar otra operacion?";
		Escribir "*Ingrese 1 para realizar otra operacion";
		Escribir "*Ingrese 2 para salir";
		Limpiar Pantalla;
		Leer Opcion;
		Si Opcion==1 Entonces
			b<-1;
		SiNo
			b<-0;
		FinSi
Hasta Que b==0;

Salir<-0;
Hasta Que Salir==1;	

	
	
FinProceso
