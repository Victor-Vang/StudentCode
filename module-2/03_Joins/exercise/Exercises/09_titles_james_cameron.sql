-- 9. The titles of movies directed by James Cameron (6 rows)

SELECT title FROM person p
JOIN movie_actor ma ON p.person_id = ma.actor_id
JOIN movie m ON ma.movie_id = m.movie_id
WHERE director_id = 
(SELECT person_id FROM person
WHERE person_name = 'James Cameron')
GROUP BY ma.movie_id, title;

