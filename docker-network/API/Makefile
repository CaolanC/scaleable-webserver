API_CONTAINER_NAME=pesto_rest_api

kill:
	sudo docker stop $(API_CONTAINER_NAME)
	sudo docker rm $(API_CONTAINER_NAME)

build:
	sudo docker build . -t $(API_CONTAINER_NAME) 

up:
	make kill || sudo docker run -d -p 8080:80 --name $(API_CONTAINER_NAME) $(API_CONTAINER_NAME)
