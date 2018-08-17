package com.company;

import java.text.DecimalFormat;
import java.util.*;

public class Main{
    static ArrayList<String> buildParts = new ArrayList<String>();
    static ArrayList<Double> partsCost = new ArrayList<Double>();

    static ArrayList<Integer> CostIndex = new ArrayList<Integer>();
    static ArrayList<String> partUsed = new ArrayList<String>();

    static Scanner scan = new Scanner(System.in);
    static DecimalFormat PayFormat = new DecimalFormat("##.00");

    public static void main(String[] args) {
        startScreen();
        String tryUser, tryPass;
        boolean run = true;
        while (run) {
            System.out.println("Enter Username: ");
            tryUser = scan.nextLine();

            System.out.println("Enter Password: ");
            tryPass = scan.nextLine();

            if (Login.inLogin(tryUser, tryPass) == 3) {
                Manager.managerMenu();
            } else if (Login.inLogin(tryUser, tryPass) == 2) {
                EMP.empMenu();
            } else if (Login.inLogin(tryUser, tryPass) == 1) {
                System.out.println("Enter Username: ");
                tryUser = scan.nextLine();

                System.out.println("Enter Password: ");
                tryPass = scan.nextLine();


                Login.inLogin(tryUser, tryPass);
            }

            boolean right = false;
            while (!right) {
                System.out.println("Enter 0 to Exit");
                while (!scan.hasNextInt()) {
                    System.out.println("you must enter a number! ");
                    scan.next();
                }
                int Choose = scan.nextInt();
                if (Choose == 0) {
                    right = true;
                    System.exit(0);
                } else {
                    System.out.println("Invalid Number.");
                }
            }

        }

    }

    public static void startScreen() {
        typeText("Welcome to the Singley Construction Company employee system.");
        System.out.println("");

        for (int c = 0; c < 3; c++) {
            typeText("Loading system...");
            System.out.println("");
        }
    }

    public static void BuildCostReport()// EMP & Manager
    {
        System.out.println("---Build Cost Report---");
        System.out.println("**Available Parts and Cost**");
        for (int c = 0; c < buildParts.size(); c++)
        {
            System.out.println("Part: " + buildParts.get(c) + " Cost $" + partsCost.get(c) + ".");
        }
        System.out.println("**End of Parts and Cost**");

        double TotalCost = 0;
        boolean right = false;
        while (!right) {
            System.out.println("Enter 0 for Total Report.");
            System.out.println("Enter 1 to Add Part.");

            while (!scan.hasNextInt()) {
                System.out.println("you must enter a number! ");
                scan.next();
            }
            int Choose = scan.nextInt();
            if (Choose == 1) {
                TotalCost += CostofPart();
            } else if (Choose == 0) {
                System.out.println("---Total Report---");
                for(int c = 0; c < partUsed.size(); c++) {
                    System.out.println("Part: " + partUsed.get(c) + " Cost: $" + partsCost.get(CostIndex.get(c)) + ".");
                }
                System.out.println("--Total Cost: $" + PayFormat.format(TotalCost) + ".");
                System.out.println("---End Report---");
                right = true;
            } else {
                System.out.println("Invalid Choose.");
            }
        }
    }

    public static double CostofPart()
    {
        System.out.println("Choose Part: ");
        String Part = scan.nextLine();
        int partIndex = 0;

        boolean there = false;
        while (!there)
        {
            if (buildParts.contains(Part))
            {
                partIndex = buildParts.indexOf(Part);
                partUsed.add(Part);
                CostIndex.add(partIndex);
                there = true;
            }
            else
            {
                System.out.println("--Invalid Part--");
                System.out.println("Choose Part: ");
                Part = scan.nextLine();
            }
        }

        System.out.println("Enter the Needed Square Foot: ");
        while (!scan.hasNextDouble()) {
            System.out.println("you must enter a number! ");
            scan.next();
        }
        double sqFoot = scan.nextDouble();
        double partCost = partsCost.get(partIndex) * sqFoot;

        System.out.println("Cost of Part: " + PayFormat.format(partCost));

        return partCost;
    }

    public static void typeText(String text) {
        for (int i = 0; i < text.length(); i++) {
            System.out.printf("%c", text.charAt(i));
            try {
                Thread.sleep(100);
            } catch (InterruptedException ex) {
                Thread.currentThread().interrupt();
            }
        }
    }
}
