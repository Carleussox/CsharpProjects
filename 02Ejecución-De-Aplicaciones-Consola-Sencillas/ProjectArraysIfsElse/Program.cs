using System;



// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaGrades = [90, 86, 87, 98, 100];
/* int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100; */

int[] andrewGrades = [92, 89, 81, 96, 90];
/* int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90; */

int[] emmaGrades = [90, 85, 87, 98, 68];
/* int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68; */

int[] loganGrades = [90, 95, 87, 88, 96];
/* int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96; */


int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal[] studentsNumberScores = new decimal[4];
int arrayScoresIterator = 0;

/* decimal sophiaNumberScore;
decimal andrewNumberScore;
decimal emmaNumberScore;
decimal loganNumberScore; */



/* sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5; */

studentsNumberScores[arrayScoresIterator]= (decimal)sophiaSum / currentAssignments;
studentsNumberScores[arrayScoresIterator]= (decimal)andrewSum / currentAssignments;
studentsNumberScores[arrayScoresIterator]= (decimal)emmaSum / currentAssignments;
studentsNumberScores[arrayScoresIterator]= (decimal)loganSum / currentAssignments;

//Nombres de estudiantes
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

Console.WriteLine("Student\t\tGrade\n");

//Bucle de estudiantes a partir de nombres
foreach (string name in studentNames)
{
    //Switch con bucle para hacer el sumatorio de resultado por estudiante
    switch (name)
    {

        case "Sophia":
            foreach ( int grade in sophiaGrades)
            {

                sophiaSum += grade;
            }
            studentsNumberScores[arrayScoresIterator] = (decimal)sophiaSum / currentAssignments;

            break;

        case "Andrew":
            foreach (int grade in andrewGrades)
            {

                andrewSum += grade;
            }
            studentsNumberScores[arrayScoresIterator]= (decimal)andrewSum / currentAssignments;

            break;

        case "Emma":
            foreach (int grade in emmaGrades)
            {

                emmaSum += grade;
            }
            studentsNumberScores[arrayScoresIterator]= (decimal)emmaSum / currentAssignments;

            break;

        case "Logan":
            foreach (int grade in loganGrades)
            {

                loganSum += grade;
            }
            studentsNumberScores[arrayScoresIterator]= (decimal)loganSum / currentAssignments;

            break;




    }
    
    Console.WriteLine($"{name}:\t\t" + studentsNumberScores[arrayScoresIterator] + $"\t{GradeCalculator(studentsNumberScores[arrayScoresIterator])}");

    arrayScoresIterator++;
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();






/* 
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F */



static  string GradeCalculator( decimal studentNumberScore){
    string grade = "";

if (studentNumberScore >= 97)
{
    grade = "A+";
}

 else if (studentNumberScore >= 93)
{
    grade = "A";
}

else if (studentNumberScore >= 90)
{
    grade = "A-";
}

else if (studentNumberScore >= 87)
{
    grade = "B+";
}

else if (studentNumberScore >= 83)
{
    grade = "B";
}

else if (studentNumberScore >= 80)
{
    grade = "B-";
}

else if (studentNumberScore >= 77)
{
    grade = "C+";
}

else if (studentNumberScore >= 73)
{
    grade = "C";
}

else if (studentNumberScore >= 70)
{
    grade = "C-";
}

else if (studentNumberScore >= 67)
{
    grade = "D+";
}

else if (studentNumberScore >= 63)
{
    grade = "D";
}

else if (studentNumberScore >= 60)
{
    grade = "D-";
}

else
{
    grade = "F";
}

return grade;
}





