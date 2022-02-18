-- 17. The titles and taglines of movies that are in the "Family" genre and Samuel L. Jackson has acted in (4 rows)

SELECT title, tagline FROM movie_actor ma
JOIN movie m ON ma.movie_id = m.movie_id
JOIN movie_genre mg ON m.movie_id = mg.movie_id
JOIN genre g ON mg.genre_id = g.genre_id
WHERE actor_id = (SELECT person_id FROM person WHERE person_name = 'Samuel L. Jackson') AND genre_name = 'Family';


