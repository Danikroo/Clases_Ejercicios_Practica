//Impresión en la consola de texto
console.log('Buenos días!! - Es mi primer código en JS');

console.log("No hay problema con los puntos y coma en JS")

console.log(`Se puede escribir también con los temple string`);

// console.log(alt + 96  = temple string);


//Es un cometario de una sóla línea

/*
Es un comentario 
de varias 
líneas
que no las tiene en 
cuenta
/

//Varibles: espacios de memoria para guardar info que después usamos
//declaración de una variable
var nombre
var apellido;

//asignamos un valor a la variable
nombre = 'Pepe';
apellido = "Pérez"

//declaramos la variable y asignamos el valor
var provincia = 'Mendoza';

//imprimimos las variables
console.log('1. Mi nombre es: ' + nombre + ' y mi apellido es: ' + apellido);

console.log("2. Mi nombre es: " + nombre + " y mi apellido es: " + apellido)

console.log(3. Mi nombre es ${nombre} y mi apellido es ${apellido} y mi provincia es ${provincia});


//NO SE PUEDE
/
var 32135454 = 'PEPE';
var nombre empleado = "Mario";
var -pais = 'Argentina'
var var = 150;
var for = 100;
*/

//SI SE PUEDE
var $empresa = 'Mercado Libre';
var _continente = 'América';
var em123 = 500;

//No recomendabele
var kjandjkfdj = 'tarjeta'

//Positivo: Camel Case
var nombreTarjetaDeCredito = 'Visa';

//Otras palabras reservadas para varibles
let pais = 'Argentina';
let Pais = 'Brasil';
let PAis = 'Uruguay';
const DNI = 123456789;

//no se puede reasignar valor a una constante
//DNI = 8465131313; 

console.log("Mi DNI es", DNI);

console.log(pais - Pais - PAis);