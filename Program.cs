namespace CSI120_Week5_FirstLecture
{
    // Hoang Khoi Gia Nguyen
    // CSI 120 - Computer Programming 1
    // Lecture 11 Notes

    internal class Program
    {

        string student1 = "Hoang";
        string student2 = "Vicky";

        static string[] firstNames  = new string[4];
        static string[] lastNames   = new string[4];
        static int[]    csiGrades   = new int[4];

        // students - Memory Address: 2000
        // type size: 16 | ---- | 
        // students [0] - 2000 + index * Type Size
        // students[1]  - 2000 + (1 * 16)

        // If you define an array with no value, it has default values
        // string:  |""|
        // int:     |0|
        // double:  |0.0|
        // bool:    |false|
        // object:  |null|

        static void Main(string[] args)
        {

            

            Menu();

            

            //DisplayAllStudents();



        }//Main

        public static void Menu()
        {
            Preload();
            int userInput = 0;
            while (userInput != 4)
            { 
            
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Display All Students");
            Console.WriteLine("2. Check Student Enrollment by Last Name");
            Console.WriteLine("3. Display All Information by Last Name");
            Console.WriteLine("4. Exit");

            
            Console.Write("Selection: ");
                userInput = int.Parse(Console.ReadLine());

            
            
                switch (userInput)
                {
                case 1:
                    DisplayAllStudents();
                    break;
                case 3:
                    LastNameSearch();
                    break;
                case 2:                 
                    LastNameStatus();
                    break;
                case 4:
                    break;
                default:
                Console.WriteLine("Invalid. Try again");
                break;


                }
            }
        }

        public static void LastNameStatus()
        {
            Console.Write("Input last name: ");
            string userInput = Console.ReadLine();
            if (EnrolledInClassByLastName(userInput))
            {
                Console.WriteLine("Yes, this student is in my class.");
            }
            else
            {
                Console.WriteLine("No, this student is not in my class");
            }

            // .Length gives the size of the arrays
        }

        public static void LastNameSearch()
        {
            Console.Write("Please enter a last name to search for: ");
            string studentToSearchFor = Console.ReadLine();
            int studentIndex = FindStudentIDByLastName(studentToSearchFor);

            if (studentIndex >= 0)
            {
                DisplayStudentInformation(studentIndex);
            }
            else
            {
                Console.WriteLine("That student is not enrolled in the class.");
            }
        }

        // Linear Search

        // Create method returns if a student is in the class
        // Return a bool
        public static bool EnrolledInClassByLastName(string studentsLastName) // <= Search Key
        {
            
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If current value == the searchKey
                if (lastNames[i].ToLower() == studentsLastName.ToLower())
                {
                    return true;
                }

            }
            return false;
        }


        public static int FindStudentIDByLastName(string studentsLastName)
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If current value == the searchKey
                if (lastNames[i].ToLower() == studentsLastName.ToLower())
                {
                    return i;
                }

            }
            return -1;
        }

        public static void DisplayStudentInformation(int studentIndex)
        {
            // Student ID
            Console.WriteLine($"Student ID: {studentIndex}");
            // Full Name
            Console.WriteLine($"Student Full Name: {FullName(studentIndex)}");
            // First Name
            Console.WriteLine($"Student First Name: {firstNames[studentIndex]}");

            // Last Name
            Console.WriteLine($"Student Last Name: {lastNames[studentIndex]}");

            // Grades

            Console.WriteLine();


        }

        public static void DisplayAllStudents()
        {
            for (int i = 0; i < firstNames.Length; i++)
            {
                // string fullName = FullName(i);
                DisplayStudentInformation(i);
            }

        }

        // New Method: Return a full name
        // Triple Forward Slash /// defines a method in intellisense
        /// <summary>
        /// It will return a string of students full name
        /// </summary>
        /// <param name="studentIndex">Index of Student</param>
        public static string FullName(int studentIndex)
        {
            
            string firstName = firstNames[studentIndex];
            string lastName = lastNames[studentIndex];
            string fullName = $"{firstName} {lastName}";


            Console.WriteLine(fullName);

            // I am returning the full name of the student outside of method
            // So can work with it in other methods

            return fullName;
        }

        // Preload()

        public static void Preload()
        {
            //
            firstNames[0] = "Hoang";
            firstNames[1] = "Vicky";
            firstNames[2] = "Brian";
            firstNames[3] = "Carla";

            lastNames[0] = "Nguyen";
            lastNames[1] = "Le";
            lastNames[2] = "Lee";
            lastNames[3] = "Baysinger";
        }

        public static void MatrixExmaple()
        {
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;


            //     0 1
            // 0 | 1 2
            // 1 | 3 4

        }

        public static void MenuExample()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SwitchExample();
                    break;

            }

        }

        public static void SwitchExample() // Switches
        {
            // Switches is decision structure that works on comparisons

            //Keywords
            // switch: define code block
            // case: define individual set of instruction
            // break: define end of above instruction
            // default: runs if no case runs (like else)

            // switch (case) <-- Not a condition : "cat == dog" don't put this

            Console.Write("Enter an animal: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                // create our cases
                // you write case to define new case followed by
                // No curly braces
                // Use colon ":" instead
                // Followed by break
                // case do not have their own scope
                case "dog":
                case "owl":
                    
                    Console.WriteLine("bark");
                    break;
                case "cat":
                    
                    Console.WriteLine("meow");
                    Console.WriteLine("Purr");
                    break;
                default:
                    Console.WriteLine("Please enter a valid animal");
                    break;
            }

        }

        public static void BreakExample()
        {
            // New Keyword
            // break
            // break indicates that we want to jump out of the current code block


            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    break;
                    // Once break is triggered
                    // Code Block will be stopped
                }


            }
        }



    }//Class

}//Name

