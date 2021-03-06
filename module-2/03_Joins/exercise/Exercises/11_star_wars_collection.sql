-- 11. The titles of the movies in the "Star Wars Collection" ordered by release date, most recent to earliest (9 rows)

SELECT title FROM collection c
JOIN movie m ON c.collection_id = m.collection_id
WHERE collection_name = 'Star Wars Collection'
ORDER by release_date DESC;
