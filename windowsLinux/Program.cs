//// This is my interface branch

//using windowsLinux.Interface;
//using windowsLinux.Opgave;

////Console.Write("Choose student or teacher: ");
////string? inputPersonType = Console.ReadLine();

////IPerson? selectedPerson = Indentify(inputPersonType);
////Console.WriteLine(selectedPerson.ShowPersonType());

////IPerson? Indentify(string personType)
////{
////    if (personType == "student")
////    {
////        return new Student("Patrik", "Nielsen");
////    }
////    else if (personType == "teacher")
////    {
////        return new Teacher("Niels", "Olesen");
////    }
////    else
////        return null;
////}

//string minUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


//IOS? selectedPerson = Indentify(minUserFolder);
//Console.WriteLine(selectedPerson.ShowOSType());

//IOS Indentify(string minUserFolder)
//{
//    if (minUserFolder.Contains("C:"))
//    {
//        return new Windows("Niels Olesen");
//    }
//    else if (minUserFolder.Contains("/"))
//    {
//        return new Linux("Niels Olesen");
//    }
//    else
//        return null;
//}