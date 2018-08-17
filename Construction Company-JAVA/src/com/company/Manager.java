package com.company;

import java.util.*;

public class Manager {
    static Scanner scan = new Scanner(System.in);

    public static void managerMenu() // Manager Menu
    {
        int Day = 0;

        Timecard card = new Timecard();

        System.out.println("----Site Manager Menu----");
        System.out.println("1.Add & Modify Cost of Parts");
        System.out.println("2.Add & Modify Employees");
        System.out.println("3.Log Time");
        System.out.println("4.Log Report");
        System.out.println("5.Build Cost Report");
        System.out.println("6.Exit");
        System.out.print("Enter Menu Choose: ");


        while (true) {
            int Choose;

            while (!scan.hasNextInt()) {
                System.out.println("you must enter a number! ");
                scan.next();
            }

            Choose = scan.nextInt();

            if (Choose > 6 || Choose < 1) {
                System.out.println("Invalid Choose.");
                Choose = scan.nextInt();
            }


            switch (Choose) {
                case 1:
                    modifyCost();
                    break;
                case 2:
                    Login.modifyEMP();
                    break;
                case 3:
                    Day++;
                    card.logTime(Day);
                    break;
                case 4:
                    card.LogReport();
                    break;
                case 5:
                    Main.BuildCostReport();
                    break;
                case 6:
                    return;
            }
        }
    }
    public static void modifyCost() // Manager Only
    {
        while (true) {
            System.out.println("1.Add Building Part.");
            System.out.println("2.Remove Building Part.");
            System.out.println("3.Change Cost of Part.");
            System.out.println("4.Return");

            while (true) {
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
                        System.out.println("---Add Part---");
                        System.out.print("Enter Name of Part:");
                        String name = scan.nextLine();

                        Main.buildParts.add(name);

                        System.out.print("Enter Cost of Part:");
                        double cost = scan.nextDouble();

                        Main.partsCost.add(cost);
                        break;
                    case 2:
                        System.out.println("---Remove Part---");
                        System.out.print("Enter Name of Part:");
                        String Rname = scan.nextLine();

                        for (int c = 0; c < Main.buildParts.size(); c++) {
                            if (Main.buildParts.get(c).equals(Rname)) {
                                Main.buildParts.remove(c);
                                Main.partsCost.remove(c);
                            } else {
                                System.out.println("Part Not Found.");
                                modifyCost();
                            }
                        }
                        break;
                    case 3:
                        System.out.println("---Modify Part---");
                        boolean right = false;
                        while(!right) {
                            System.out.print("Enter Name of Part:");
                            String Mname = scan.nextLine();

                            for (int c = 0; c < Main.buildParts.size(); c++) {
                                if (Main.buildParts.get(c).equals(Mname)) {
                                    System.out.print("Enter New Cost of Part:");
                                    while (!scan.hasNextDouble()) {
                                        System.out.println("you must enter a number! ");
                                        scan.next();
                                    }
                                    double Mcost = scan.nextDouble();

                                    Main.partsCost.set(c, Mcost);
                                    System.out.println("Cost Changed");
                                    right = true;

                                } else {
                                    System.out.println("Part Not Found.");
                                }
                            }
                        }
                        break;
                    case 4:
                        managerMenu();
                        break;
                }
            }
        }
    }
}
