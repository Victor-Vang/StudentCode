-- 10. The names of directors who have directed a movie over 3 hours [180 minutes] (15 rows)

SELECT person_name FROM person
WHERE person_id IN 
(SELECT DISTINCT director_id FROM person p
JOIN movie_actor ma ON p.person_id = ma.actor_id
JOIN movie m ON ma.movie_id = m.movie_id
WHERE length_minutes > 180)
ORDER BY person_name; 





