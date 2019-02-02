SELECT ROW_TO_JSON(team_info) FROM (
	SELECT
				t.name,
				t.city,
				t.conference,
				t.conference_rank,
				COUNT(p.player_id) AS number_of_players,
				CONCAT(c.first_name, ' ', c.last_name) AS coach,
				t.home_wins,
				t.away_wins
	FROM		players p, teams t, coaches c
	WHERE		p.team_id = t.team_id
	AND			c.team_id = t.team_id
	GROUP BY	t.name, c.first_name, c.last_name, t.city, t.conference, t.conference_rank, t.home_wins, t.away_wins
	ORDER BY    t.conference, t.conference_rank
) AS team_info