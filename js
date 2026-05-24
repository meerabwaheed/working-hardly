let name = "meerab";
let name = "js";
function greetUser(){
    console.log("hello," + name + "!");
     console.log("js," + name + "!");
}

let age = 21;
const height = 5.4;
//here is the simple addition program
let num1 = 10;
let num2 = 20;
let num3 = 450;
let sum = num1 + num2 + num3;
console.log("sum is:" + sum);
console.log("this code is written by meerab waheed");
//here is another code
let number = 7;
if (number % 2 === 0){
    console.log(number is: +"even");
}else{
    console.log(number + "odd");
}
//here is the loop
let fruits =["apple","mango","banana","peach"];
for (let i = 1; i < fruits.length; i++){
    console.log(fruits[1]);
}
console.log("this code is written by ......");
console.log("this code is written by maryam ");
console.log("this code is written by hassan");
console.log("this code is written by husaain");
console.log("this code is written by ryyan");
//class program
class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    showDetails() {
        console.log(`Name: ${this.name}`);
        console.log(`Age: ${this.age}`);
        console.log("code is written by me")
    }
}
// Child Class
class Student extends Person {

    constructor(id, name, age, marks) {
        super(name, age);

        this.id = id;
        this.marks = marks;
        console.log("......");
    }
    // Calculate Grade
    calculateGrade() {

        if (this.marks >= 100) {
            return "A+";
        }
        else if (this.marks >= 90) {
            return "A";
        }
        else if (this.marks >= 80) {
            return "B";
        }
        else if (this.marks >= 60) {
            return "C";
        }
        else {
            return "fail";
        }
    }

    // Display Student Information
    displayStudent() {

        console.log("student achy bachy display");

        console.log(`Student ID: ${this.id}`);
        console.log(`Name: ${this.name}`);
        console.log(`Age: ${this.age}`);
        console.log(`Marks: ${this.marks}`);
        console.log(`Grade: ${this.calculateGrade()}`);

        console.log(".........................");
    }
}

// Student Array
let students = [];

// Add Student Function
function addStudent(id, name, age, marks) {

    let student = new Student(id, name, age, marks);

    students.push(student);

    console.log(`${name} added successfully!\n`);
    console.log("done");
}
let name = "meerab waheed";






