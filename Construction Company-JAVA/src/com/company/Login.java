package com.company;

import com.company.Main;

import java.util.ArrayList;
import java.util.Scanner;

public class Login {

    private static ArrayList<String> Usernames = new ArrayList<String>();
    static private ArrayList<String> Passwords = new ArrayList<String>();
    static private ArrayList<Double> Rate = new ArrayList<Double>();

    public static double savedRate;
    
    static Scanner scan = new Scanner(System.in);

    public static boolean CheckForUser(String User)
    {
        for (int c = 0; c < Usernames.size(); c++)
        {
            if (User == Usernames.get(c))
            {
                return true;
            }
        }

        return false;
    }

    public static int inLogin(String User, String Password) {
        System.out.print("Logging In...");

        Usernames.add("Andrew");
        Passwords.add("Password");
        Rate.add(20.00);

            Usernames.set(0,"Andrew");
            Passwords.set(0,"Password");
            Rate.set(0,20.00);

        if (User.equals(Usernames.get(0)) && Password.equals(Passwords.get(0))) {
            System.out.println("Login Complete...");
            savedRate = Rate.get(0);
            return 3;
        }

        for (int c = 1; c < Usernames.size(); c++) {
            if (User.equals(Usernames.get(c)) && Password.equals(Passwords.get(c))) {
                System.out.print("Login Complete...");
                savedRate = Rate.get(c);
                return 2;
            }
        }

        for (int c = 0; c < Usernames.size(); c++) {
            if (User != Usernames.get(c)) {
                System.out.print("Login fail...");
                System.out.print("Invalid Password.");
                return 1;
            } else {
                System.out.print("Login fail...");
                System.out.print("Invalid User.");
                return 1;
            }
        }
        return 1;
    }

    public static Boolean modifyEMP() // Manager Only
    {
        boolean right = false;

        while (!right) {
            System.out.println("1.Add Employee.");
            System.out.println("2.Remove Employee.");
            System.out.println("3.Change Employee Rate.");
            System.out.println("4.Return");

                int Choose;

                while (!scan.hasNextInt()) {
                    System.out.println("you must enter a number! ");
                    scan.next();
                }

                Choose = scan.nextInt();

                if (Choose > 4 || Choose < 1) {
                    System.out.print("Invalid Choose.");
                    Choose = scan.nextInt();
                }


                switch (Choose) {
                    case 1:
                        System.out.println("---Add Employee---");
                        System.out.print("Enter Name of Employee:");
                        String name = scan.nextLine();

                        Usernames.add(name);

                        System.out.print("Enter Employee Password:");
                        String pass = scan.nextLine();

                        Passwords.add(pass);

                        System.out.print("Enter Employee Rate:");
                        double inRate = scan.nextDouble();
                        if (inRate <= 7.25) {
                            System.out.print("Rate is to low.");
                            modifyEMP();
                        } else {
                            Rate.add(inRate);
                        }
                        break;
                    case 2:
                        System.out.print("---Remove Employee---");
                        System.out.println("Enter Name of Employee:");
                        String Rname = scan.nextLine();

                        for (int c = 0; c < Usernames.size(); c++) {
                            if (Usernames.get(c).equals(Rname)) {
                                Usernames.remove(c);
                                Rate.remove(c);
                                Passwords.remove(c);
                            } else {
                                System.out.print("Employee Not Found.");
                                modifyEMP();
                            }
                        }
                        break;
                    case 3:
                        System.out.print("---Modify Employee---");
                        System.out.println("Enter Name of Employee:");
                        String Mname = scan.nextLine();

                        for (int c = 0; c < Usernames.size(); c++) {
                            if (Usernames.get(c).equals(Mname)) {
                                System.out.print("1.Change Rate.");
                                System.out.print("2.Change Password.");
                                System.out.print("3.Return");

                                while (true) {
                                    int XChoose;

                                    while (!scan.hasNextInt()) {
                                        System.out.println("you must enter a number! ");
                                        scan.next();
                                    }

                                    XChoose = scan.nextInt();

                                    if (XChoose > 4 || XChoose < 1) {
                                        System.out.print("Invalid Choose.");
                                        XChoose = scan.nextInt();
                                    }


                                    switch (XChoose) {
                                        case 1:
                                            System.out.print("Enter New Employee Rate:");
                                            double ReRate = scan.nextDouble();
                                            if (ReRate <= 7.25) {
                                                System.out.print("Rate is to low.");
                                                modifyEMP();
                                            } else {
                                                Rate.add(ReRate);
                                            }
                                            break;
                                        case 2:
                                            System.out.print("Enter New Employee Password:");
                                            String RePass = scan.nextLine();

                                            Passwords.set(c, RePass);
                                            break;
                                        case 3:
                                            modifyEMP();
                                            break;
                                    }
                                }
                            } else {
                                System.out.print("Employee Not Found.");
                                modifyEMP();
                            }
                            break;
                        }
                    case 4:
                        right = true;
                        Manager.managerMenu();
                        break;
                }
        }
        return true;
    }
}
