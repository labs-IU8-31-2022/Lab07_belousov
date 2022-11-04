// See https://aka.ms/new-console-template for more information

using Animals;

class Program
{
    static void Main(string[] args)
    {
        //Animal
        {
            Type animal_type = typeof(Animal);
            foreach (var attribute in animal_type.GetCustomAttributes(false))
            {
                if (attribute is MyAttribute myAttr)
                {
                    Console.Write("Comment in attribute is: ");
                    Console.WriteLine(myAttr.Comment);
                    Console.WriteLine();
                }
            }
            foreach (var member in animal_type.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }
            Console.WriteLine("===========================");
        }
        
        //Lion
        {
            Type animal_type = typeof(Lion);
            foreach (var attribute in animal_type.GetCustomAttributes(false))
            {
                if (attribute is MyAttribute myAttr)
                {
                    Console.Write("Comment in attribute is: ");
                    Console.WriteLine(myAttr.Comment);
                    Console.WriteLine();
                }
            }
            foreach (var member in animal_type.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }
            Console.WriteLine("===========================");
        }

        //Cow
        {
            Type animal_type = typeof(Cow);
            foreach (var attribute in animal_type.GetCustomAttributes(false))
            {
                if (attribute is MyAttribute myAttr)
                {
                    Console.Write("Comment in attribute is: ");
                    Console.WriteLine(myAttr.Comment);
                    Console.WriteLine();
                }
            }
            foreach (var member in animal_type.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }
            Console.WriteLine("===========================");
        }

        //Pig
        {
            Type animal_type = typeof(Pig);
            foreach (var attribute in animal_type.GetCustomAttributes(false))
            {
                if (attribute is MyAttribute myAttr)
                {
                    Console.Write("Comment in attribute is: ");
                    Console.WriteLine(myAttr.Comment);
                    Console.WriteLine();
                }
            }
            foreach (var member in animal_type.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }
        }
    }
}