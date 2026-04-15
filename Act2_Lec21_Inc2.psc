Algoritmo Buzon_de_voz
	Definir voz Como Entero
	Escribir "===BUZON DE VOZ==="
	Escribir "1 - VENTAS"
	Escribir "2 - RECEPCION"
	Escribir "3 - DIRECCION"
	Escribir "4 - COMPRAS"
	Escribir "Digite una opcion: "
	Leer voz
	
	Si (voz == 1) Entonces
		Escribir "BIENVENIDO AL DEPARTAMENTO DE VENTAS"
		Escribir "Nombre Responsable: EMILIANO CUEVAS"
		Escribir "Correo: n.cuevas.5bdb@gmail.com"
	FinSi
	Si (voz == 2) Entonces
		Escribir "BIENVENIDO AL DEPARTAMENTO DE RECEPCION"
		Escribir "Nombre Responsable: HEIDY ESQUIBEL"
		Escribir "Correo: heicuevas@resetsa.com"
	FinSi
	Si (voz == 3) Entonces
		Escribir "BIENVENIDO AL DEPARTAMENTO DE DIRECCION"
		Escribir "Nombre Responsable: MELANY CUEVAS"
		Escribir "Correo: melushcuevas@gmail.com"
	FinSi
	Si (voz == 4) Entonces
		Escribir "BIENVENIDO AL DEPARTAMENTO DE COMPRAS"
		Escribir "Nombre Respoonsable: NELSON CUEVAS"
		Escribir "Correo: nicuevas@gmail.com"
	FinSi
	Si (voz <> 1 y voz <> 2 y voz <> 3 y voz <> 4) Entonces
		Escribir "ERROR"
	FinSi
FinAlgoritmo