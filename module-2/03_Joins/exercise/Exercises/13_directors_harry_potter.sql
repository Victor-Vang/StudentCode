-- 13. The directors of the movies in the "Harry Potter Collection" (4 rows)

SELECT person_name FROM person
WHERE person_id IN 
(SELECT DISTINCT director_id FROM Collection c
JOIN movie m ON c.collection_id = m.collection_id
WHERE collection_name = 'Harry Potter Collection')
ORDER BY person_name;



