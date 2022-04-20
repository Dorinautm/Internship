/* first task Order By*/

SELECT First_Name, Last_Name, City, Join_Date, monthly_discount
FROM [customers]
WHERE Join_Date >= '20100101' AND monthly_discount IS NOT NULL
ORDER BY monthly_discount DESC;

/* second task select, where, having*/

/* select all customers whose monthly discount is above average*/
SELECT Last_name, monthly_discount, pack_id
 FROM [customers] AS c1
 WHERE monthly_discount >
                (SELECT AVG(monthly_discount)
                 FROM [customers]
                 WHERE pack_id =
                        c1.pack_id);
						
/* avg monthly discount from all people with the same pack_id */
SELECT Last_name, pack_id, monthly_discount,
(SELECT  AVG(monthly_discount)
	FROM [customers]
	WHERE pack_id = c1.pack_id) AS Average_monthly_discount
FROM [customers] AS c1
WHERE pack_id is not null 
ORDER BY pack_id ASC

/* [nested] select name and their monthly discount that is above average */
SELECT Last_name, monthly_discount
 FROM [customers] AS c1
 GROUP BY monthly_discount, Last_Name
 HAVING monthly_discount > (SELECT AVG(monthly_discount)
                 FROM [customers])
                 
/* ex3*/
SELECT * FROM [customers]

/* Select first name, last name and birth date of customers which names start with “Jo” */
SELECT First_Name, Last_Name, Birth_Date
FROM [customers]
WHERE First_Name LIKE 'Jo%' or Last_Name LIKE 'Jo%';

/*Select first name, last name and birth date of customers in which second letter in first name is “o”*/
SELECT First_Name, Last_Name, Birth_Date
FROM [customers]
WHERE First_Name LIKE '_o%'

/* Select the first three first name, last name, pack_id, secondary_phone_num   of customers which pack_id is null and state secondary_phone_num  is not null  */
SELECT First_Name, Last_Name, pack_id, secondary_phone_num
FROM [customers]
WHERE pack_id is NULL AND secondary_phone_num is NOT NULL

/*Display  sector id and sector name which sector name is (value 1, or value 3, or value  4 , or  value 5) and not value  2, or value 7 */
SELECT sector_id, sector_name
FROM [sectors]
WHERE sector_name LIKE 'value [1345]'


/*Display the lowest last name alphabetically */
SELECT TOP 1 Last_Name
FROM [customers]
ORDER BY Last_Name DESC

/*Display the average monthly payment*/
SELECT AVG(monthly_payment) AS avg_monthly_pay
FROM [packages]

/* Display the highest last name alphabetically */
SELECT TOP 1 Last_Name
FROM [customers]
ORDER BY Last_Name

/* Display the number of internet packages */
SELECT COUNT(pack_id) AS nr_internet_packs
FROM [packages]

/* Display the number of records in Customers table */
SELECT COUNT(Customer_Id) AS nr_of_records
FROM [customers]

/* Display the number of distinct states */
SELECT COUNT(DISTINCT [State]) AS nr_distinct_states
FROM [customers]

/*Display the number of distinct internet speeds*/
SELECT COUNT(DISTINCT speed) AS nr_distinct_speeds
FROM [packages]

/*Display the number of values (exclude Nulls) in Fax column */
SELECT COUNT(fax) AS nr_val_fax 
FROM [customers]
WHERE fax IS NOT NULL

/* Display the number of Null values in Fax column */
SELECT COUNT(Customer_Id) AS nr_nullval_fax 
FROM [customers]
WHERE fax IS NULL;

/*Display the highest, lowest and average monthly discount (Customers table). */
SELECT	MAX(monthly_discount) AS highest_month_discount,
		MIN(monthly_discount) AS lowest_month_discount,
		AVG(monthly_discount) AS avg_month_discount
FROM [customers]

/*Display the state and the number of customers for each state (Customers table). */
SELECT [State], COUNT(Customer_Id) AS nr_customers
FROM [customers]
GROUP BY [State]

/*Display the internet speed and the average monthly payment for each speed (Packages table). */
SELECT speed, AVG(monthly_payment) AS avg_month_pay
FROM [packages]
GROUP BY speed

/*Display the state and the number of distinct cities for each state (Customers table). */
SELECT [State], COUNT(DISTINCT City) AS nr_distinct_cities
FROM [customers]
GROUP BY [State]

/*Display the sector number and the highest monthly payment for each sector (Packages table). */
SELECT sector_id, MAX(monthly_payment) AS highest_month_pay
FROM [packages]
GROUP BY sector_id

/* Number of packages and average monthly discount */
SELECT pack_id, AVG(monthly_discount) AS avg_month_pay
FROM [customers]
Group BY pack_id
HAVING pack_id IS NOT NULL

/*Display the highest, lowest and average monthly payment for each internet speed (Packages table). */
SELECT speed, MAX(monthly_payment) AS highest_month_pay,
		MIN(monthly_payment) AS lowest_month_pay,
		AVG(monthly_payment) AS avg_month_pay
FROM [packages]
GROUP BY speed

/*The number of customer in each internet package (Customers table) */---------------
SELECT COUNT(Customer_Id) AS nr_customers
FROM [customers]
GROUP BY pack_id
HAVING pack_id IS NOT NULL

/*Display the package id and the number of customers for each package id. */
SELECT pack_id, COUNT(Customer_Id) AS nr_of_customers
FROM [customers]
GROUP BY pack_id
HAVING pack_id IS NOT NULL

/*Modify the query to display the package id and number of customers for each package id,
only for the customers whose monthly discount is greater than 20. */
SELECT pack_id, COUNT(Customer_Id) AS nr_customers
FROM [customers]
WHERE monthly_discount > 20
GROUP BY pack_id

/*Modify the query to display the package id and number of customers for each package id, 
only for the packages with more than 100 customers. */
SELECT pack_id, COUNT(Customer_Id) AS nr_customers
FROM [customers]
GROUP BY pack_id
HAVING COUNT(Customer_Id) > 100

/* Display the state, city and number of customers for each state and city. */
SELECT [State], City, Count(Customer_Id) AS nr_cunstomers
FROM [customers]
GROUP BY [State], City

/*Display the city and the average monthly discount for each city */
SELECT City, AVG(monthly_discount) AS avg_month_discount
FROM [customers]
GROUP BY City

/*Display the city and the average monthly discount for each city, 
only for the customers whose monthly discount is greater than 20 */
SELECT City, AVG(monthly_discount) AS avg_month_discount
FROM [customers]
WHERE
GROUP BY City


/* Display the state and the lowest monthly discount for each state.  */
SELECT [State], MIN(monthly_discount)
FROM [customers]
GROUP BY [State]

/*Display the state and lowest monthly discount for each state, only
for states where the lowest monthly discount is greater than 10 */
SELECT [State], MIN(monthly_discount)
FROM [customers]
GROUP BY [State]
HAVING MIN(monthly_discount) > 10

/*Display the internet speed and number of package for each internet
speed, only for the internet speeds with more than 8 packages. */
SELECT speed, COUNT(pack_id)
FROM [packages]
GROUP BY speed
HAVING COUNT(pack_id) > 8

