-- 11. Hollywood is remaking the classic movie "The Blob" and doesn't have a director yet. Add yourself to the person table, and assign yourself as the director of "The Blob" (the movie is already in the movie table). (1 record each)

SELECT movie_id FROM movie WHERE title = 'The Blob';

SELECT person_id FROM person WHERE person_name = 'Victor Vang';

INSERT INTO person (person_name)
VALUES ('Victor Vang');

UPDATE movie
SET director_id = (SELECT person_id FROM person WHERE person_name = 'Victor Vang')
WHERE title = 'The Blob';
