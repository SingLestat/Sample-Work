package com.company;

import java.util.Scanner;

public class EMP {
    static Scanner scan = new Scanner(System.in);

    public static void empMenu() // EMP Menu
    {
        int Day = 0;

        Timecard card = new Timecard();
        boolean right = false;

        while (!right) {
        System.out.println("----Site Employee Menu----");
        System.out.println("1.Log Time");
        System.out.println("2.Log Report");
        System.out.println("3.Build Cost Report");
        System.out.println("4.Report Manager");
        System.out.println("5.Exit");
        System.out.print("Enter Menu Choose: ");


            int Choose;

            while (!scan.hasNextInt()) {
                System.out.println("you must enter a number! ");
                scan.next();
            }

            Choose = scan.nextInt();

            if (Choose > 5 || Choose < 1) {
                System.out.println("Invalid Choose.");
                Choose = scan.nextInt();
            }


            switch (Choose) {
                case 1:
                    Day++;
                    card.logTime(Day);
                    break;
                case 2:
                    card.LogReport();
                    break;
                case 3:
                    Main.BuildCostReport();
                    break;
                case 4:
                    ReportManager();
                    break;
                case 5:
                    right = true;
                    return;

            }
        }
    }

    public static void ReportManager() // EMP only
    {
        System.out.print("Enter the Username of Manager: ");
        String REmanager = scan.nextLine();

        if (Login.CheckForUser(REmanager))
        {
            System.out.print("Enter the Problem with Manager: ");
            String Message = scan.nextLine();

            System.out.println("Your Report has been sent to Upper Management"); // aka Trash
            Message = "";
        }
    }

}
