-- 15. The title of the movie and the name of director for movies where the director was also an actor in the same movie (73 rows)

SELECT title, person_name FROM person p
JOIN movie_actor ma ON p.person_id = ma.actor_id
JOIN movie m ON ma.movie_id = m.movie_id
WHERE actor_id = director_id;
