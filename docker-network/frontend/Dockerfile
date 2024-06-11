FROM node:18 AS frontend_source
WORKDIR /app 
COPY ./build/ /app/

FROM nginx:alpine AS frontend_server

RUN apk update && apk upgrade

COPY nginx.conf /etc/nginx/nginx.conf
#COPY default.conf /etc/nginx/conf.d/default.conf
COPY ./ssl_keys/server.crt /etc/nginx/server.crt
COPY ./ssl_keys/server.key /etc/nginx/server.key
COPY --from=frontend_source /app/ /usr/share/nginx/html/
RUN cat /usr/share/nginx/html/index.html
RUN find /usr/share/nginx/
EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
