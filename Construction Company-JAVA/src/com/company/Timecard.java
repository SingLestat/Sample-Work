package com.company;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Scanner;

public class Timecard {

    static ArrayList<Double> inlogHour = new ArrayList<Double>();
    static ArrayList<Double> inlogMin = new ArrayList<Double>();

    static ArrayList<Double> outlogHour = new ArrayList<Double>();
    static ArrayList<Double> outlogMin = new ArrayList<Double>();

    static ArrayList<Double> EndPay = new ArrayList<Double>();

    static Scanner scan = new Scanner(System.in);

    public static int logTime(int day) // EMP & Manager
    {
        System.out.println("---Day " + day + "---");

        System.out.print("Enter the Hour you clocked in: (24 hour format)");
        while (!scan.hasNextDouble()) {
            System.out.println("you must enter a number! ");
            scan.next();
        }
        inlogHour.add(scan.nextDouble());
        System.out.print("Enter the Minute you clocked in: ");
        while (!scan.hasNextDouble()) {
            System.out.println("you must enter a number! ");
            scan.next();
        }
        inlogMin.add(scan.nextDouble());
        System.out.print("Enter the Hour you clocked out: (24 hour format)");
        while (!scan.hasNextDouble()) {
            System.out.println("you must enter a number! ");
            scan.next();
        }
        outlogHour.add(scan.nextDouble());
        System.out.print("Enter the Minute you clocked out: ");
        while (!scan.hasNextDouble()) {
            System.out.println("you must enter a number! ");
            scan.next();
        }
        outlogMin.add(scan.nextDouble());

        return 1;
    }

    public static void LogReport() // EMP & Manager
    {
        System.out.println("---Time Log Report---");
        for(int c = 0; c < inlogHour.size(); c++)
        {
            double pay = (Math.abs(inlogHour.get(c) - outlogHour.get(c)) + (Math.abs(inlogMin.get(c) - outlogMin.get(c))/100)) * Login.savedRate;
            EndPay.add(pay);
            DecimalFormat PayFormat = new DecimalFormat("##.00");

            System.out.println("Day " + (c + 1) + " Time in: " + inlogHour.get(c) + ":" + inlogMin.get(c) + "." );
            System.out.println("Day " + (c + 1) + " Time out: " + outlogHour.get(c) + ":" + outlogMin.get(c) + "." );
            System.out.println("Day " + (c + 1) + " Total Hours Worked " + Math.abs(inlogHour.get(c) - outlogHour.get(c)) + "." + Math.abs(inlogMin.get(c) - outlogMin.get(c)) + ".");
            System.out.println("Day " + (c+1) + " Money earned $" + PayFormat.format(pay));
            System.out.println("------");
        }

        double endHours = 0;
        double lastPay = 0;

        System.out.println("******");
        System.out.println("---Total Report---");
        for (int c = 0; c < inlogHour.size(); c++)
        {
            endHours +=  Math.abs(inlogHour.get(c) - outlogHour.get(c)) + Math.abs(inlogMin.get(c) - outlogMin.get(c));
            lastPay += EndPay.get(c);
        }

        System.out.println("Total Hours: " + endHours + ".");
        System.out.println("Total Pay: $" + lastPay + ".");
        System.out.println("---End Report---");
        return;
    }
}
