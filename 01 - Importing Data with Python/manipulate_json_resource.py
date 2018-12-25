import urllib.request as request
import json

# TO-DO:
# - Add error handling for non-existing files

# Object hook
def group_teams_by_division(team):
    return (team['fullName'], team['divName'])

# Open API URL
with request.urlopen('http://data.nba.net/prod/v2/2018/teams.json') as response:
    if response.getcode() == 200:
        source = response.read()
        data = json.loads(source)
    else:
        print('An error occurred while attempting to retrieve data from the API.')
    
# Uncomment for debugging:
# type(data)
# data.keys()
# type(data['league'])
# data['league'].keys()
# type(data['league']['standard'])
# len(data['league']['standard'])
# data['league']['standard'][5]

# Teams that are NBA franchises
nba_teams = [team for team in data['league']['standard'] if team['isNBAFranchise']]

# Save nba_teams.json
with open('nba_teams.json', 'w') as f:
    json.dump(nba_teams, f, indent = 4, sort_keys = True)

# Open nba_teams.json for processing   
with open('nba_teams.json') as f:
    data = json.load(f, object_hook = group_teams_by_division)
 
# Group teams by division   
teams_by_division = {}    
for i in range(len(data)):
    team, division = data[i]
    if division not in teams_by_division.keys():
        teams_by_division[division] = []
    teams_by_division[division].append(team)

# Save teams_by_division.json    
with open('teams_by_division.json', 'w') as f:
    json.dump(teams_by_division, f, indent = 4, sort_keys = True)