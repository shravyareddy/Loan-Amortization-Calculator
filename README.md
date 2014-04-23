Loan-Amortization-Calculator
============================
1. Create a graphical interface to request the parameters for the loan.  These include the principal amount, the term (in months) and the annual percentage interest rate.  There will be two buttons on your screen which are enabled only when valid data is present in all fields.  That is, numeric values, no negative numbers, etc.

2. Both buttons will cause the monthly payment and the total of payments to be shown in a label control on the entry screen.

3. The first button causes a chart to be displayed showing the payment number, the amount of that payment that is principal, the amount that is interest, and the remaining balance. You can use a JList or other appropriate Swing control.

4. The second button causes a graph to be displayed charting the decline in the remaining balance over the term of the loan.  This is tricky, since you cannot use any third-party charting controls like OWC11.dll.  However, you can use graphing controls that are part of the Java libraries, or those in Visual Studio.  The point is that we (the TA and your instructor) must be able to run your program without installing anything other than your code.

5. There must be no computation, no business logic, in your user interface.  You must pass the same data (I suggest creating a class) to each of the view routines.  Programs that use tab controls or pop up separate windows for the different views are acceptable, but keep the classes separate.
