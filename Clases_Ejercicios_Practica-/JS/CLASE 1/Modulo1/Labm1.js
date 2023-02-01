let nombre = window.prompt("Cual es tu nombre ?");
let apellido = window.prompt("Cual es tu apellido ?");
let edad = window.prompt("Cual es tu edad?");

window.alert("Hola " + nombre + " " + apellido + ", tu edad es " + edad + " años.");
document.write("Hola " + nombre + " " + apellido + ", tu edad es " + edad + " años.<br>");

let sueldo = window.prompt("Cual fue tu sueldo?","Ingresar sueldo aquí.");
let bonus = window.prompt("Cual Es tu Bonus ?", "Ingresa bonus aquí");
let rest = parseInt(sueldo) + parseInt(bonus);

document.write("Tu Sueldo final es de $" + rest +" pesos");