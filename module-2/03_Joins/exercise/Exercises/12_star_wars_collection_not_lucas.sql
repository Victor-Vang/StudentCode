-- 12. The titles of the movies in the "Star Wars Collection" that weren't directed by George Lucas (5 rows)

SELECT title FROM collection c
JOIN movie m ON c.collection_id = m.collection_id
WHERE collection_name = 'Star Wars Collection' 
AND director_id != (SELECT person_id FROM person
WHERE person_name = 'George Lucas');


