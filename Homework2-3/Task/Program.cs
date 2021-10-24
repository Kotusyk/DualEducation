using System;

namespace Task
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tТask #1\n");
            float number1, number2, number3;
            Console.WriteLine("Enter the first number: ");
            float.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter the second number: ");
            float.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Enter the third number: ");
            float.TryParse(Console.ReadLine(), out number3);
            bool allInRange = IsInRange(number1) && IsInRange(number2) && IsInRange(number3);
            if (allInRange) {

                Console.WriteLine("All the numbers in the range [-5.5]");
            }
            else
            {
                Console.WriteLine("Not all or none numbers in the range[-5.5]");
            }


            Console.WriteLine("\n\t\tТask #2\n");
            int num1, num2, num3;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Min(num1, num2, num3);
            Max(num1, num2, num3);

            Console.WriteLine("\n\t\tТask #3\n");
            Console.WriteLine("Enter a number of HTTP eror from 400 to 499: ");
            string eror = Console.ReadLine();
            //Because of function WhichEror() recive HTTPErors type and we need to obtain this type from string
            HTTPErors eror1 = (HTTPErors)Enum.Parse(typeof(HTTPErors), eror);
            Console.WriteLine("The name of this eror:");
            WhichEror(eror1);

            Console.WriteLine("\n\t\tТask #4\n");
            Console.WriteLine("Enter some text: ");
            string str = Console.ReadLine();
            char[] strC = str.ToCharArray();
            int count = 0;
            // In this case '\0' or '\n' isn`t affective, so better to use foreach
            foreach (char character in strC)
            {
                if (character == 'a' || character == 'o' || character == 'i' || character == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine("The count of 'a', 'o', 'i' and 'e' is {0}", count);


            Console.WriteLine("\n\t\tТask #5\n");
            int[] countDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, 30, 31 };
            do
            {
                Console.WriteLine("Enter the number of month: ");
                int numMonth = Convert.ToInt32(Console.ReadLine());
                if (numMonth > 12 || numMonth < 0)
                {
                    Console.WriteLine("Please, enter right number");
                }
                else
                {
                    Console.WriteLine("This month has {0} days", countDays[numMonth - 1]);
                    break;
                }
            } while (true);


            Console.WriteLine("\n\t\tТask #6\n");
            int[] numbers = new int[10];
            bool shouldSum = true;
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Enter 10 numbers:");
                numbers[j] = Convert.ToInt32(Console.ReadLine());
                if (j < 5)
                {
                    shouldSum = shouldSum && (numbers[j] > 0) ;
                }

            }
            int result = 0;
            if (shouldSum)
            {
                foreach (int val in numbers)
                {
                    result += val;
                }
                Console.WriteLine("The first 5 elements was positive. The sum of them: {0} ", result);

            }
            else
            {
                result = 1;
                for(int k = 5; k < numbers.Length; k++)
                {
                    result *= numbers[k];

                }
                Console.WriteLine("The first 5 elements was negative. The product of them: {0} ", result);
            }


        }

        public static bool IsInRange(float a)
        {
            return a >= -5 && a <= 5;
        }


        public static void Min(int n1, int n2, int n3)
        {
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("Min: {0}", n1);
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("Min: {0}", n2);
            }
            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine("Min: {0}", n3);
            }
        }
        public static void Max(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Max: {0}", n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("Max: {0}", n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("Max: {0}", n3);
            }
        }

        public enum HTTPErors
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405,
            Not_Acceptable = 406,
            Proxy_Authentication_Required = 407,
            Request_Timeout = 408,
            Conflict = 409,
            Gone = 410,
            Length_Required = 411,
            Precondition_Failed = 412,
            Request_Entity_Too_Large = 413,
            Request_URI_Too_Long = 414,
            Unsupported_Media_Type = 415,
            Requested_Range_Not_Satisfiable = 416,
            Expectation_Failed = 417,
            Im_a_teapot = 418,
            Authentication_Timeout = 419,
            Method_Failure = 420,
            Unprocessable_Entity = 422,
            Locked = 423,
            Failed_Dependency = 424,
            Upgrade_Required = 426,
            Precondition_Required = 428,
            Too_Many_Requests = 429,
            Request_Header_Fields_Too_Large = 431,
            Login_Timeout = 440,
            No_Response = 444,
            Retry_With = 449,
            Blocked_By_Windows_Parental_Controls = 450,
            Unavailable_For_Legal_Reasons = 451,
            Request_Header_Too_Large = 494,
            Cert_Error = 495,
            No_Cert = 496,
            HTTP_To_HTTPS = 497,
            Token_expired_or_invalid = 498,
            Client_Closed_Request = 499
        }

        public static void WhichEror(HTTPErors eror)
        {
            switch ((int)eror)
            {
                case 400:
                    Console.WriteLine("Bad Request");
                    break;
                case 401:
                    Console.WriteLine("Unauthorized");
                    break;
                case 402:
                    Console.WriteLine("Payment Required");
                    break;
                case 403:
                    Console.WriteLine("Forbidden");
                    break;
                case 404:
                    Console.WriteLine("Not Found");
                    break;
                case 405:
                    Console.WriteLine("Method Not Allowed ");
                    break;
                case 406:
                    Console.WriteLine("Not Acceptable");
                    break;
                case 407:
                    Console.WriteLine("Proxy Authentication Required");
                    break;
                case 408:
                    Console.WriteLine("Request Timeout");
                    break;
                case 409:
                    Console.WriteLine("Conflict");
                    break;
                case 410:
                    Console.WriteLine("Gone");
                    break;
                case 411:
                    Console.WriteLine("Length Required");
                    break;
                case 412:
                    Console.WriteLine("Precondition Failed");
                    break;
                case 413:
                    Console.WriteLine("Request Entity Too Large");
                    break;
                case 414:
                    Console.WriteLine("Request-URI Too Long");
                    break;
                case 415:
                    Console.WriteLine("Unsupported Media Type");
                    break;
                case 416:
                    Console.WriteLine("Requested Range Not Satisfiable");
                    break;
                case 417:
                    Console.WriteLine("Expectation Failed");
                    break;
                case 418:
                    Console.WriteLine("I'm a teapot");
                    break;
                case 419:
                    Console.WriteLine("Authentication Timeout");
                    break;
                case 420:
                    Console.WriteLine("Method Failure ");
                    break;
                case 422:
                    Console.WriteLine("Unprocessable Entity");
                    break;
                case 423:
                    Console.WriteLine("Locked");
                    break;
                case 424:
                    Console.WriteLine("Failed Dependency");
                    break;
                case 426:
                    Console.WriteLine("Upgrade Required");
                    break;
                case 428:
                    Console.WriteLine("Precondition Required");
                    break;
                case 429:
                    Console.WriteLine("Too Many Requests");
                    break;
                case 431:
                    Console.WriteLine("Request Header Fields Too Large");
                    break;
                case 440:
                    Console.WriteLine("Login Timeout (Microsoft)");
                    break;
                case 444:
                    Console.WriteLine("No Response (Nginx)");
                    break;
                case 449:
                    Console.WriteLine("Retry With (Microsoft)");
                    break;
                case 450:
                    Console.WriteLine("Blocked by Windows Parental Controls (Microsoft)");
                    break;
                case 451:
                    Console.WriteLine("Unavailable For Legal Reasons (Internet draft)");
                    break;
                case 494:
                    Console.WriteLine("Request Header Too Large (Nginx)");
                    break;
                case 495:
                    Console.WriteLine("Cert Error (Nginx)");
                    break;
                case 496:
                    Console.WriteLine("No Cert (Nginx)");
                    break;
                case 497:
                    Console.WriteLine("HTTP to HTTPS (Nginx)");
                    break;
                case 498:
                    Console.WriteLine("Token expired/invalid (Esri)");
                    break;
                case 499:
                    Console.WriteLine("Client Closed Request (Nginx)");
                    break;

                default:
                    Console.WriteLine("This eror isn`t exist");
                    break;

            }
        }

       
    }
}
