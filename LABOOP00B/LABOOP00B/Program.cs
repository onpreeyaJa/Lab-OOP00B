// See https://aka.ms/new-console-template for more information
using LABOOP00B;

Student student1 = new Student();
student1.name = "Onpreeya";
student1.weight = 54;

Student student2 = new Student();
student2.name = "Ramin";
student2.weight = 60;

Student student3 = new Student();
student3.name = "Siriporn";
student3.weight = 45;

Student student4 = new Student();
student4.name = "Thanaporn";
student4.weight = 85;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight) / 4;
Console.WriteLine("Weight avg of Student: " + avgWeight);
Console.WriteLine("Weight max of Student: " + student4.weight + student4.name);
Console.WriteLine("Weight min of Student: " + student3.weight + student3.name);
Console.WriteLine("อรปรียา จันทะโคตร 653450107-5");
