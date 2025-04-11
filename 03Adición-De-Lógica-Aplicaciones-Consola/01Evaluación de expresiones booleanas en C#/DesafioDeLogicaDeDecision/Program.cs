/* string permission = "Admin|Manager";
int level = 55; */
Console.WriteLine("Por favor, introduzca su Rol");
string permission= Console.ReadLine();
Console.WriteLine("Por favor, introduzca su nivel de seguridad");
int level = int.Parse(Console.ReadLine());

string rol = permission.Contains("Admin") || permission.Contains("Manager") ? 

    (permission.Contains("Admin") ? 

        (level > 55 ?

             "Welcome, Super Admin user"
             
             : "Welcome, Admin user") 
    
    : level> 20 ? "Contact an admin for access": "you do not have sufficient privileges")

: "You do not have sufficient privileges";



Console.WriteLine($"{rol}");