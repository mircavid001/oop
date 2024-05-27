




car student = new car();

student.name = "elnur";
student.surname = "mextiev";
student.age = 22;
student.phonenumber = 578498785;

car teacher = new car();

teacher.name = "mahal";
teacher.surname = "mamedov";
teacher.age = 62 - 63;
teacher.phonenumber = 578492760;


car boss = new car();

boss.name = "eshref";
boss.surname = "allazov";
boss.age = 70;
boss.phonenumber = 555325991;


Console.WriteLine($"name: {boss.name}\nsurname: {boss.surname}\nage: {boss.age}\nphonenumber:{boss.phonenumber}");
Console.WriteLine($"name: {teacher.name}\nsurname: {teacher.surname}\nage: {teacher.age}\nphonenumber:{teacher.phonenumber}");
Console.WriteLine($"name: {student.name}\nsurname: {student.surname}\nage: {student.age}\nphonenumber:{student.phonenumber}");





class car
{
    public string name;
    public string surname;
    public int age;
    public int phonenumber;

}

