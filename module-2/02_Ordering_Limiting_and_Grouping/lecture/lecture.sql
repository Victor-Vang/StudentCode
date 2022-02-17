-- ORDERING RESULTS

-- Populations of all states from largest to smallest.

SELECT population FROM state 
ORDER BY population DESC;

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.

SELECT * FROM state
ORDER BY census_region DESC, state_name ASC;

-- The biggest park by area

SELECT TOP 1 * FROM park
ORDER BY area DESC;

-- LIMITING RESULTS

-- The 10 largest cities by populations

SELECT TOP 10 * FROM city
ORDER BY population DESC;

-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.

SELECT YEAR(GETDATE()) - YEAR(date_established)) AS age FROM park
ORDER BY date_established, park_name ASC;

-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.

SELECT city_name + ', ' + state_abbreviation AS name FROM city;

-- All park names and area


-- The census region and state name of all states in the West & Midwest sorted in ascending order.



-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.

SELECT AVG(population) AvgPopulation FROM state;

-- Total population in the West and South census regions

SELECT SUM(population) FROM state WHERE census_region IN ('West', 'South');

-- The number of cities with populations greater than 1 million

SELECT COUNT(city_name) FROM city WHERE population > 1000000;

-- The number of state nicknames.

SELECT COUNT(state_nickname) FROM state WHERE state_nickname IS NOT NULL;

-- The area of the smallest and largest parks.



-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.

SELECT state_abbreviation, COUNT(city_name) number_of_cities FROM city GROUP BY state_abbreviation ORDER BY number_of_cities DESC;

-- Determine the average park area depending upon whether parks allow camping or not.

SELECT has_camping, AVG(area) avg_area FROM park GROUP BY has_camping;

-- Sum of the population of cities in each state ordered by state abbreviation.

SELECT state_abbreviation, SUM(population) Population FROM city GROUP BY state_abbreviation ORDER BY state_abbreviation;

-- The smallest city population in each state ordered by city population.


-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)



-- SUBQUERIES (optional)

-- Include state name rather than the state abbreviation while counting the number of cities in each state,

SELECT * FROM city AS c;

SELECT 
(SELECT state_name FROM state WHERE state.state_abbreviation = city.state_abbreviation), 
COUNT(city_name) city_count FROM city 
GROUP BY state_abbreviation 
ORDER BY city_count DESC;

-- Include the names of the smallest and largest parks


-- List the capital cities for the states in the Northeast census region.

