FROM node:18 AS frontend_source
WORKDIR /app 
COPY ./package.json ./package-lock.json /app/
RUN npm install
COPY . /app  
RUN npm run build

FROM nginx:alpine AS frontend_server

RUN export REACT_APP_API_URL=http://localhost:8080/

RUN apk update && apk upgrade

COPY nginx.conf /etc/nginx/nginx.conf
#COPY default.conf /etc/nginx/conf.d/default.conf
COPY ./ssl_keys/server.crt /etc/nginx/server.crt
COPY ./ssl_keys/server.key /etc/nginx/server.key
COPY --from=frontend_source /app/build/ /usr/share/nginx/html/
EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
