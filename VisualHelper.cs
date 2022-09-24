﻿using System;

namespace Helper
{
    public class VisualHelper
    {
        public static void ShowHeadlineScriptOnLeft()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▄▀█▀▄▄▀█ ▄▄█ ▄▄████ ▄▄▀█▄▄ ██████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▄▀█ ██ █▄▄▀█▄▄▀█▀▀█ ▀▀ █▀▄███████████████████████████████████████████████████████████████████████████████████
 ███████▄▄▄▄██▄▄██▄▄▄█▄▄▄█▄▄█▄██▄█▄▄▄██████████████████████████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
            Console.ResetColor();
        }

        public static void ShowHeadlineScriptOnMiddle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 █████████████████████████████████████████████ ▄▄▀█▀▄▄▀█ ▄▄█ ▄▄████ ▄▄▀█▄▄ ████████████████████████████████████████████
 █████████████████████████████████████████████ ▄▄▀█ ██ █▄▄▀█▄▄▀█▀▀█ ▀▀ █▀▄█████████████████████████████████████████████
 █████████████████████████████████████████████▄▄▄▄██▄▄██▄▄▄█▄▄▄█▄▄█▄██▄█▄▄▄████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
            Console.ResetColor();
        }

        public static void ShowSignInScript()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine($@"
                                                     ╔═══════════╗
                                                     ║  Sign In  ║
                                                     ╚═══════════╝
");
        }

        public static void ShowSignUpScript()
        {
            Console.WriteLine($@"
                                                     ╔═══════════╗
                                                     ║  Sign Up  ║
                                                     ╚═══════════╝
");
        }

        public static void ShowSignUpHeadline()
        {
            Console.WriteLine(@"  
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 █████████████████████████████████████████████████▄████████████████████████████████████████████████████████████████████
 ████████████████████████████████████████████ ▄▄█▄ ▄█ ▄▄▄█ ▄▄▀███ ██ █ ▄▄ █████████████████████████████████████████████
 ████████████████████████████████████████████▄▄ ██ ██ █▄▀█ ██ ███ ██ █ ▄▄██████████████████████████████████████████████
 ████████████████████████████████████████████▄▄▄█▄▄▄█▄▄▄▄█▄██▄███▄▄▄▄█▄████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ResetColor();

        }

        public static void ShowSignInHeadline()
        {
            Console.WriteLine(@" 
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 █████████████████████████████████████████████████▄███████████████▄████████████████████████████████████████████████████
 ████████████████████████████████████████████ ▄▄█▄ ▄█ ▄▄▄█ ▄▄▀███▄ ▄█ ▄▄▀██████████████████████████████████████████████
 ████████████████████████████████████████████▄▄ ██ ██ █▄▀█ ██ ████ ██ ██ ██████████████████████████████████████████████
 ████████████████████████████████████████████▄▄▄█▄▄▄█▄▄▄▄█▄██▄███▄▄▄█▄██▄██████████████████████████████████████████████
");
            Console.ResetColor();
        }

        public static void ShowMyCVsScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▀▄ █ ██ ████ ▄▄▀██ ███ ██▀▀▀█████████████████████████████████████████████████████████████████████████████████
 ███████ █▄█ █ ▀▀ ███ ██████ ███ ██ ▀██████████████████████████████████████████████████████████████████████████████████
 ███████▄███▄█▀▀▀▄████ ▀▀▄███▄▀▄███▀▀ █████████████████████████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowMyCVScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"

 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▀▄ █ ██ ████ ▄▄▀██ ███ ██████████████████████████████████████████████████████████████████████████████████████
 ███████ █▄█ █ ▀▀ ███ ██████ ███ ██████████████████████████████████████████████████████████████████████████████████████
 ███████▄███▄█▀▀▀▄████ ▀▀▄███▄▀▄███████████████████████████████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowWorkerScript()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine($@"
                                                     ╔════════════════╗
                                                     ║     WORKER     ║
                                                     ╚════════════════╝
");
        }

        public static void ShowEmployerScript()
        {
            Console.WriteLine($@"
                                                     ╔════════════════╗
                                                     ║    EMPLOYER    ║
                                                     ╚════════════════╝
");
        }

        public static void ShowBackScript()
        {
            Console.WriteLine($@"
                                                     ╔════════════════╗
                                                     ║      BACK      ║
                                                     ╚════════════════╝
");
        }

        public static void ShowBackScriptOnLeft()
        {
            Console.WriteLine($@"
    ╔═════════════════════╗
    ║                     ║
    ║        BACK         ║
    ║                     ║
    ╚═════════════════════╝
");
        }

        public static void ShowApplyForJobScript()
        {
            Console.WriteLine($@"╔═════════════════════╗
                           ║                     ║
                           ║    APPLY FOR JOB    ║
                           ║                     ║
                           ╚═════════════════════╝
");
        }

        public static void ShowAddCVScript()
        {
            Console.WriteLine($@"╔═════════════════════╗
                           ║                     ║
                           ║        ADD CV       ║
                           ║                     ║
                           ╚═════════════════════╝
");
        }

        public static void ShowSeeMyCVsScript()
        {
            Console.WriteLine($@"╔═════════════════════╗
                           ║                     ║
                           ║      SEE MY CVs     ║
                           ║                     ║
                           ╚═════════════════════╝
");
        }

        public static void ShowSearchVacancyScript(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("╔═════════════════════╗");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("║    SEARCH VACANCY   ║ ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("╚═════════════════════╝ ");
        }

        public static void ShowSearchVacancyHeadline()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▄█ ▄▄█ ▄▄▀█ ▄▄▀█▀▄▄▀█ ██ ███ ███ █ ▄▄▀█▀▄▄▀█ ▄▄▀█ ▄▄▀█▀▄▄▀█ ██ ██████████████████████████████████████████████
 ███████▄▄▀█ ▄▄█ ▀▀ █ ▀▀▄█ ██▀█ ▄▄ ████ ▀ ██ ▀▀ █ ██▀█ ▀▀ █ ██ █ ██▀█ ▀▀ ██████████████████████████████████████████████
 ███████▄▄▄█▄▄▄█▄██▄█▄█▄▄██▄▄██▄██▄█████▄███▄██▄██▄▄██▄██▄█▄██▄██▄▄██▀▀▀▄██████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
        }

        public static void ShowSeeVacanciesScript()
        {
            Console.WriteLine($@"╔═════════════════════╗
                           ║                     ║
                           ║    SEE VACANCIES    ║
                           ║                     ║
                           ╚═════════════════════╝
");
        }

        public static void ShowSeeNotificationsScript(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("╔═════════════════════╗");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("║  SEE NOTIFICATIONS  ║ ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("╚═════════════════════╝ ");
        }

        public static void ShowAddVacancyScript()
        {
            Console.WriteLine($@"╔═════════════════════╗
                           ║                     ║
                           ║     ADD VACANCY     ║
                           ║                     ║
                           ╚═════════════════════╝
");
        }

        public static void ShowMyNotificationsScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ███████████████████████████████████▀███████▀█████████████████▀████████████████████████████████████████████████████████
 ███████ ▄▀▄ █ ██ ███ ▄▄▀█▀▄▄▀█▄ ▄█▀▀▀█ ▄▄█▀▀▀█▀▄▄▀█ ▄▄▀█▄ ▄█▀▀▀█▀▄▄▀█ ▄▄▀█ ▄▄█████████████████████████████████████████
 ███████ █▄█ █ ▀▀ ███ ██ █ ██ ██ ███ ██ ▄███ ██ ██▀█ ▀▀ ██ ███ ██ ██ █ ██ █▄▄▀█████████████████████████████████████████
 ███████▄███▄█▀▀▀▄███▄██▄██▄▄███▄██▄▄▄█▄███▄▄▄██▄▄██▄██▄██▄██▄▄▄██▄▄██▄██▄█▄▄▄█████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowDeleteVacancyScript()
        {
            Console.WriteLine($@"╔═════════════════════╗
                           ║                     ║
                           ║    DELETE VACANCY   ║
                           ║                     ║
                           ╚═════════════════════╝
");
        }

        public static void ShowDeleteVacancyScript2()
        {
            Console.WriteLine($@"
    ╔═════════════════════╗
    ║                     ║
    ║    DELETE VACANCY   ║
    ║                     ║
    ╚═════════════════════╝
");
        }

        public static void ShowSendBIDScript()
        {
            Console.WriteLine($@"
    ╔═════════════════════╗
    ║                     ║
    ║       SEND BID      ║
    ║                     ║
    ╚═════════════════════╝
");
        }

        public static void ShowHireWorkerScript()
        {
            Console.WriteLine($@"
    ╔═════════════════════╗
    ║                     ║
    ║     HIRE WORKER     ║
    ║                     ║
    ╚═════════════════════╝
");
        }

        public static void ShowDeclineWorkerScript()
        {
            Console.WriteLine($@"
    ╔═════════════════════╗
    ║                     ║
    ║   DECLINE WORKER    ║
    ║                     ║
    ╚═════════════════════╝
");
        }

        public static void ShowHireWorkerScript(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("╔═════════════════════╗");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("║     HIRE WORKER     ║ ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("╚═════════════════════╝ ");
        }

        public static void ShowBackScriptLongVersion(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("╔═════════════════════╗");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("║        BACK         ║ ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("║                     ║ ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("╚═════════════════════╝ ");
        }

        public static void ShowMyVacanciesScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ████████████████████████████████████████████████████▀█████████████████████████████████████████████████████████████████
 ███████ ▄▀▄ █ ██ ███ ███ █ ▄▄▀█▀▄▄▀█ ▄▄▀█ ▄▄▀█▀▄▄▀█▀▀▀█ ▄▄█ ▄▄████████████████████████████████████████████████████████
 ███████ █▄█ █ ▀▀ ████ ▀ ██ ▀▀ █ ██▀█ ▀▀ █ ██ █ ██▀██ ██ ▄▄█▄▄▀████████████████████████████████████████████████████████
 ███████▄███▄█▀▀▀▄█████▄███▄██▄██▄▄██▄██▄█▄██▄██▄▄██▄▄▄█▄▄▄█▄▄▄████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowHireWorkerHeadlineScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ██ █▄ ▄█ ▄▄▀█ ▄▄████ █▀█ █▀▄▄▀█ ▄▄▀█ █ █ ▄▄█ ▄▄▀██████████████████████████████████████████████████████████████
 ███████ ▄▄ ██ ██ ▀▀▄█ ▄▄████ █ █ █ ██ █ ▀▀▄█ ▄▀█ ▄▄█ ▀▀▄██████████████████████████████████████████████████████████████
 ███████▄██▄█▄▄▄█▄█▄▄█▄▄▄█████▄█▄███▄▄██▄█▄▄█▄█▄█▄▄▄█▄█▄▄██████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowVacanciesScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ███████████████████████████████████████▀██████████████████████████████████████████████████████████████████████████████
 ███████ ███ █ ▄▄▀█▀▄▄▀█ ▄▄▀█ ▄▄▀█▀▄▄▀█▀▀▀█ ▄▄█ ▄▄█████████████████████████████████████████████████████████████████████
 ████████ ▀ ██ ▀▀ █ ██▀█ ▀▀ █ ██ █ ██▀██ ██ ▄▄█▄▄▀█████████████████████████████████████████████████████████████████████
 █████████▄███▄██▄██▄▄██▄██▄█▄██▄██▄▄██▄▄▄█▄▄▄█▄▄▄█████████████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");

        }

        public static void ShowAddingVacancyScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ███████████████████████▀██████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▄▀█ ▄▄▀█ ▄▄▀█▀▀▀█ ▄▄▀█ ▄▄▄███ ███ █ ▄▄▀█▀▄▄▀█ ▄▄▀█ ▄▄▀█▀▄▄▀█ ██ █████████████████████████████████████████████
 ███████ ▀▀ █ ██ █ ██ ██ ██ ██ █ █▄▀████ ▀ ██ ▀▀ █ ██▀█ ▀▀ █ ██ █ ██▀█ ▀▀ █████████████████████████████████████████████
 ███████▄██▄█▄▄▄██▄▄▄██▄▄▄█▄██▄█▄▄▄▄█████▄███▄██▄██▄▄██▄██▄█▄██▄██▄▄██▀▀▀▄█████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowAddingCVScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"      
 ███████████████████████▀██████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▄▀█ ▄▄▀█ ▄▄▀█▀▀▀█ ▄▄▀█ ▄▄▄███▀▄▄▄▀█ ███ █████████████████████████████████████████████████████████████████████
 ███████ ▀▀ █ ██ █ ██ ██ ██ ██ █ █▄▀███ ███▀█▄▀█▀▄█████████████████████████████████████████████████████████████████████
 ███████▄██▄█▄▄▄██▄▄▄██▄▄▄█▄██▄█▄▄▄▄████▄▄▄████▄███████████████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowDeleteVacancyHeadlineScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
 ███████ ▄▄▀█ ▄▄█ ██ ▄▄█▄ ▄█ ▄▄███ ███ █ ▄▄▀█▀▄▄▀█ ▄▄▀█ ▄▄▀█▀▄▄▀█ ██ ██████████████████████████████████████████████████
 ███████ ██ █ ▄▄█ ██ ▄▄██ ██ ▄▄████ ▀ ██ ▀▀ █ ██▀█ ▀▀ █ ██ █ ██▀█ ▀▀ ██████████████████████████████████████████████████
 ███████▄▄▄██▄▄▄█▄▄█▄▄▄██▄██▄▄▄█████▄███▄██▄██▄▄██▄██▄█▄██▄██▄▄██▀▀▀▄██████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowVacancyAppliersScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 ███████ ███ █ ▄▄▀█▀▄▄▀█ ▄▄▀█ ▄▄▀█▀▄▄▀█ ██ ███ ▄▄▀█▀▄▄▀█▀▄▄▀█ ███▄ ▄█ ▄▄█ ▄▄▀█ ▄▄██████████████████████████████████████
 ████████ █ ██ ▀▀ █ ██▀█ ▀▀ █ ██ █ ██▀█ ▀▀ ███ ▀▀ █ ▀▀ █ ▀▀ █ ████ ██ ▄▄█ ▀▀▄█▄▄▀██████████████████████████████████████
 █████████▄███▄██▄██▄▄██▄██▄█▄██▄██▄▄██▀▀▀▄███ ██ █ ████ ████▄▄▄█▄▄▄█▄▄▄█▄█▄▄█▄▄▄██████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowApplierCVScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 ████████ ▄▄▀█▀▄▄▀█▀▄▄▀█ ███▄ ▄█ ▄▄█ ▄▄▀████▀▄▄▀██ ███ ████████████████████████████████████████████████████████████████
 ████████ ▀▀ █ ▀▀ █ ▀▀ █ ████ ██ ▄██ ▀▀▄████ ██████ █ █████████████████████████████████████████████████████████████████
 ████████ ██ █ ████ ████ ▀▀█▀ ▀█ ▀▀█ █ ▀████▄▀▀▄███▄▀▄█████████████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }

        public static void ShowApplierCVsScript()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 ████████ ▄▄▀█▀▄▄▀█▀▄▄▀█ ███▄ ▄█ ▄▄█ ▄▄▀████▀▄▄▀██ ███ ██▀▀▀██████████████████████████████████████████████████████████████
 ████████ ▀▀ █ ▀▀ █ ▀▀ █ ████ ██ ▄██ ▀▀▄████ ██████ █ ███ ▀▀██████████████████████████████████████████████████████████████
 ████████ ██ █ ████ ████ ▀▀█▀ ▀█ ▀▀█ █ ▀████▄▀▀▄███▄▀▄███▀▀ ██████████████████████████████████████████████████████████
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
        }
    }
}