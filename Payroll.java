import java.util.Scanner;

public class Payroll {
    // Arrays to hold employee data
    private int[] employeeId = {5658845, 4520125, 7895122, 8777541, 8451277, 1302850, 7580489};
    private int[] hours = new int[7];
    private double[] payRate = new double[7];
    private double[] wages = new double[7];

    /**
     * Gets the number of hours worked for a specific employee.
     *
     * @param index 
     * @return hours
     */
    public int getHours(int index) {
        return hours[index];
    }

    /**
     * Sets the number of hours worked for a specific employee.
     *
     * @param index
     * @param hoursWorked
     */
    public void setHours(int index, int hoursWorked) {
        if (hoursWorked >= 0) {
            hours[index] = hoursWorked;
        } else {
            System.out.println("Hours worked cannot be negative.");
        }
    }

    /**
     * Gets the pay rate for a specific employee.
     *
     * @param index 
     * @return payRate
     */
    public double getPayRate(int index) {
        return payRate[index];
    }

    /**
     * Sets the pay rate for a specific employee.
     *
     * @param index 
     * @param rate 
     */
    public void setPayRate(int index, double rate) {
        if (rate >= 6.00) {
            payRate[index] = rate;
        } else {
            System.out.println("Pay rate must be at least $6.00.");
        }
    }

    /**
     * Gets the employee ID for a specific employee.
     * @param index 
     * @return employeeId
     */
    public int getEmployeeId(int index) {
        return employeeId[index];
    }

    /**
     * Calculates the gross wages for all employees based on hours worked
     * and pay rate, and stores the result in the wages array.
     */
    public void calculateWages() {
        for (int i = 0; i < employeeId.length; i++) {
            wages[i] = hours[i] * payRate[i];
        }
    }

    /**
     * Gets the gross pay for a specific employee based on their ID.
     * @param empId 
     * @return wages
     */
    public double getGrossPay(int empId) {
        for (int i = 0; i < employeeId.length; i++) {
            if (employeeId[i] == empId) {
                return wages[i];
            }
        }
        System.out.println("Employee ID not found.");
        return -1;
    }

    /**
     * Prompts the user to enter the number of hours worked and pay rate for each employee.
     * Validates that hours are non-negative and pay rate is at least $6.00.
     */
    public void inputHoursAndPayRate() {
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i < employeeId.length; i++) {
            System.out.println("Enter hours worked for employee ID " + employeeId[i] + ": ");
            int hoursWorked = scanner.nextInt();
            setHours(i, hoursWorked);

            System.out.println("Enter pay rate for employee ID " + employeeId[i] + ": ");
            double rate = scanner.nextDouble();
            setPayRate(i, rate);
        }
        scanner.close();
    }

    /**
     * Displays each employee's ID and gross wages.
     * Calls the calculateWages method to ensure wages are up to date.
     */
    public void displayGrossWages() {
        calculateWages();
        System.out.println("\nEmployee ID\tGross Wages");
        for (int i = 0; i < employeeId.length; i++) {
            System.out.printf("%d\t\t%.2f%n", employeeId[i], wages[i]);
        }
    }

    /**
     * Main method for testing the Payroll class.
     * It gathers input from the user and then displays each employee’s gross wages.
     *
     * @param args
     */
    public static void main(String[] args) {
        Payroll payroll = new Payroll();
        payroll.inputHoursAndPayRate();
        payroll.displayGrossWages();
    }
}
