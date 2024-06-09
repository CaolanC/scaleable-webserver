sudo docker kill $(sudo docker ps --filter "ancestor=pesto_rest_api" --format "{{.ID}}")
