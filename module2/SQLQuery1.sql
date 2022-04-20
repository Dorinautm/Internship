/* return name, last name for the people living in sector name - value 2 */
SELECT  Customer_Id, First_Name, Last_Name
FROM [customers]
WHERE Customer_Id IN (
						SELECT sector_id
						FROM [sectors] 
						WHERE sector_name LIKE 'value 2');

/*return name of people with monthly pay >90*/
SELECT First_Name, Last_Name
FROM [customers]
WHERE EXISTS ( 
				SELECT monthly_payment
				FROM [packages]
				WHERE packages.pack_id = customers.Customer_Id
										AND monthly_payment > 90)

/*return names of people with the monthly pay > 99*/
SELECT First_Name, Last_Name
FROM [customers]
WHERE Customer_Id = ANY
	(SELECT pack_id
	FROM [packages]
	WHERE monthly_payment = 99)

/*return pack_id wuth the biggest monthly payment */
SELECT pack_id
FROM [packages]
WHERE monthly_payment >= ALL
	(SELECT monthly_payment
	FROM [packages] as c
	)

/*task 2 */

/*Write a query to display first name, last name,
package number and internet speed for all customers. */
SELECT c.First_Name, c.Last_Name,
		p.pack_id, p.speed
FROM [customers] as c
INNER JOIN [packages] as p
ON c.Customer_Id = p.pack_id

/*Write?a query to display first name, last name, package
number and internet speed for all customers whose package 
number equals 22 or 27. Order the query in ascending order by last name.*/
SELECT c.First_Name, c.Last_Name,
		p.pack_id, p.speed
FROM [customers] as c
INNER JOIN [packages] as p
ON c.Customer_Id = p.pack_id
WHERE p.pack_id LIKE '2[27]'
ORDER BY Last_Name DESC

/*Display the package number and the number of customers for each package number. */
SELECT p.pack_id, COUNT(c.Customer_Id) AS nr_of_customers
FROM [packages] as p
INNER JOIN [customers] as c
ON p.pack_id = c.pack_id 
GROUP BY p.pack_id

/*Modify the query to display the package number and number of customers for each package number, 
only for the customers whose monthly discount is greater than 20. */
SELECT p.pack_id, COUNT(c.Customer_Id) AS nr_of_customers
FROM [packages] as p
INNER JOIN [customers] as c
ON p.pack_id = c.pack_id 
WHERE monthly_discount >20
GROUP BY p.pack_id

/*Modify the query to display the package number and number of customers for each package number,
only for the packages with more than 100 customers. */
SELECT p.pack_id, COUNT(c.Customer_Id) AS nr_of_customers
FROM [packages] as p
INNER JOIN [customers] as c
ON p.pack_id = c.pack_id 
GROUP BY p.pack_id
HAVING COUNT(c.Customer_Id) > 100

/*Display the package id and the average monthly discount for each package, only for packages
whose id equals 22 or 13.---------- */
SELECT p.pack_id, AVG(c.monthly_discount) as avg_month_discount
FROM [customers] as c
INNER JOIN  [packages] as p
ON c.Customer_Id = p.pack_id
WHERE p.pack_id = 13 or p.pack_id = 22
GROUP BY p.pack_id

/*Display?the?customer name, package number, internet speed, monthly payment and sector 
name for all customers?-------------*/
SELECT c.First_Name, c.Last_Name, p.pack_id, p.speed, p.monthly_payment, s.sector_name
FROM (([customers] as c
INNER JOIN [packages] as p
ON c.Customer_Id = p.pack_id)
INNER JOIN [sectors] as s
ON c.Customer_Id= s.sector_id)

c.First_Name, c.Last_Name, p.pack_id, p.speed, p.monthly_payment, s.sector_name
FROM [customers] as c
INNER JOIN [packages] on p